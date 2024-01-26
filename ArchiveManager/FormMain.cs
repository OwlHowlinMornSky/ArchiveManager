namespace ArchiveManager {
	public partial class FormMain : Form {

		private List<RepoListItem> m_repoList = [];
		private Guid m_repoSelected;
		private Repository m_repo = new();

		private Dictionary<string, DateTime> m_leaderStorage = [];
		private Dictionary<string, DateTime> m_leaderRealtime = [];

		public FormMain() {
			InitializeComponent();
		}

		private void UpdateRepoList() {
			ComboBox_Repository.Items.Clear();
			m_repoList = RepoList.GetAll();
			m_repoList.Sort((r1, r2) => Util.StrCmpLogicalW(r1.name, r2.name));
			int selectedIndex = -1, cnt = 0;
			foreach (var repo in m_repoList) {
				ComboBox_Repository.Items.Add(repo.name);
				if (repo.guid == m_repoSelected) {
					selectedIndex = cnt;
				}
				cnt++;
			}
			ComboBox_Repository.SelectedIndex = selectedIndex;
			if (selectedIndex == -1) {
				ClearCurrentRepo();
			}
		}

		private void ClearCurrentRepo() {
			m_repo.Clear();
			ComboBox_Repository.SelectedIndex = -1;
			m_repoSelected = new Guid();
			CheckBox_FromLeader.Visible = false;
			CheckBox_ToState.Visible = false;
			CheckedListBox_To.Visible = false;
			CheckedListBox_To.Items.Clear();
			Button_Replicate.Enabled = false;
			TextBox_ViewTitle.Text = Strings0.NoChanges;
		}

		private void ChangeCurrentRepo(int index) {
			if (index >= 0) {
				if (m_repo.GetGuid() != m_repoList[index].guid) {
					if (!m_repo.Load(m_repoList[index])) {
						ClearCurrentRepo();
						MessageBox.Show(
							Strings0.Name + ": " + m_repoList[index].name + "\n" +
							Strings0.GUID + ": " + m_repoList[index].guid,
							Strings0.FailedLoadRepository,
							MessageBoxButtons.OK,
							MessageBoxIcon.Error
						);
						return;
					}

					if (ComboBox_Repository.SelectedIndex != index)
						ComboBox_Repository.SelectedIndex = index;

					m_repoSelected = m_repoList[index].guid;

					CheckBox_FromLeader.Text = m_repo.GetLeaderName();
					CheckBox_FromLeader.Visible = true;

					CheckedListBox_To.Items.Clear();
					{
						var list = m_repo.GetFollowersName();
						list.Sort(Util.StrCmpLogicalW);
						foreach (var f in list)
							CheckedListBox_To.Items.Add(f);
					}
					CheckedListBox_To.Visible = true;

					ChooseAll(true);
					CheckBox_ToState.Checked = true;
					CheckBox_ToState.Visible = true;
				}
			}
		}

		private void FormMain_Load(object sender, EventArgs e) {
			RepoList.Load();
			m_repoSelected = Settings0.Default.LastSelectedRepo;
			UpdateRepoList();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			RepoList.Save();
			Settings0.Default.LastSelectedRepo = m_repoSelected;
			Settings0.Default.Save();
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
		}

		private void Button_Replicate_Click(object sender, EventArgs e) {

		}

		private void ComboBox_Repository_SelectedIndexChanged(object sender, EventArgs e) {
			ChangeCurrentRepo(ComboBox_Repository.SelectedIndex);
		}

		private void CheckedListBox_To_ItemCheck(object sender, ItemCheckEventArgs e) {
			int n = CheckedListBox_To.Items.Count;
			if (n == 0)
				CheckBox_ToState.CheckState = CheckState.Unchecked;
			int i = 0;
			int cnt = 0;
			for (; i < n; ++i)
				if (CheckedListBox_To.GetItemChecked(i))
					++cnt;
			if (e.NewValue == CheckState.Checked)
				cnt++;
			else
				cnt--;
			if (cnt <= 0)
				CheckBox_ToState.CheckState = CheckState.Unchecked;
			else if (cnt >= n)
				CheckBox_ToState.CheckState = CheckState.Checked;
			else
				CheckBox_ToState.CheckState = CheckState.Indeterminate;
		}

		private void ChooseAll(bool check) {
			if (CheckedListBox_To.Items.Count > 0) {
				for (int i = 0, n = CheckedListBox_To.Items.Count; i < n; ++i)
					CheckedListBox_To.SetItemChecked(i, check);
				CheckBox_ToState.CheckState = check ? CheckState.Checked : CheckState.Unchecked;
			}
			else {
				CheckBox_ToState.CheckState = CheckState.Unchecked;
			}
		}

		private void CheckBox_ToState_Click(object sender, EventArgs e) {
			switch (CheckBox_ToState.CheckState) {
			case CheckState.Checked:
				ChooseAll(false);
				break;
			default:
				ChooseAll(true);
				break;
			}
		}

		private void CheckedListBox_To_SelectedIndexChanged(object sender, EventArgs e) {
			CheckedListBox_To.ClearSelected();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
