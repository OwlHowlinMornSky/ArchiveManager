namespace ArchiveManager {
	public partial class FormMain : Form {

		enum ViewState {
			NoChanges = 0,
			ViewChangesNoInfo,
			ViewChanges
		}

		private List<RepoListItem> m_repoList = [];
		private Guid m_repoSelected;
		private Repository m_repo = new();

		public FormMain() {
			InitializeComponent();
		}

		private void ChangeViewState(ViewState state) {
			switch (state) {
			case ViewState.NoChanges:
				Panel_ViewNoChanges.Visible = true;
				Panel_ViewChanges.Visible = false;
				break;
			case ViewState.ViewChangesNoInfo:
				Panel_ViewNoChanges.Visible = false;
				Panel_ViewChanges.Visible = true;
				Panel_CommitInfo.Visible = false;
				break;
			case ViewState.ViewChanges:
				Panel_ViewNoChanges.Visible = false;
				Panel_ViewChanges.Visible = true;
				Panel_CommitInfo.Visible = true;
				break;
			default:
				throw new ArgumentException("ChangeViewState: Invalid View State.");
			}
		}

		private void UpdateRepoList() {
			m_repoList = RepoList.GetAll();
			//m_repoList.Sort((r1, r2) => string.Compare(r1.name, r2.name, StringComparison.CurrentCulture));
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
		}

		private void ChangeCurrentRepo(int index) {
			if (index >= 0) {
				if (m_repo.GetGuid() != m_repoList[index].guid) {
					if (m_repo.Load(m_repoList[index])) {
						m_repoSelected = m_repoList[index].guid;
					}
				}
			}
		}

		private void FormMain_Load(object sender, EventArgs e) {
			ChangeViewState(ViewState.NoChanges);

			RepoList.Load();

			/*RepoList.Add(new RepoListItem(Guid.NewGuid(), "123test3"));
			RepoList.Add(new RepoListItem(Guid.NewGuid(), "te54st0"));
			RepoList.Add(new RepoListItem(Guid.NewGuid(), "te76st1"));
			RepoList.Add(new RepoListItem(Guid.NewGuid(), "t45est2"));*/
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

		private void Button_Submit_Click(object sender, EventArgs e) {

		}

		private void Button_Replicate_Click(object sender, EventArgs e) {

		}

		private void Button_Stream_Click(object sender, EventArgs e) {

		}

		private void ComboBox_Repository_SelectedIndexChanged(object sender, EventArgs e) {
			ChangeCurrentRepo(ComboBox_Repository.SelectedIndex);
		}
	}
}
