/*
*    Archive Manager
*
*    Copyright (C) 2023-2024  Tyler Parret True
*
*    This program is free software: you can redistribute it and/or modify
*    it under the terms of the GNU Affero General Public License as published
*    by the Free Software Foundation, either version 3 of the License, or
*    (at your option) any later version.
*
*    This program is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU Affero General Public License for more details.
*
*    You should have received a copy of the GNU Affero General Public License
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*
* @Authors
*    Tyler Parret True <mysteryworldgod@outlook.com><https://github.com/OwlHowlinMornSky>
*/

namespace ArchiveManager {
	public partial class FormMain : Form {

		#region Members

		private List<RepoListItem> m_repoList = [];

		#endregion

		#region Methods

		public FormMain() {
			InitializeComponent();
		}

		private void NotImplemented() {
			MessageBox.Show(
				Strings0.NotImplemented,
				Text,
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		private void UpdateRepoList() {
			ComboBox_Repository.Items.Clear();
			m_repoList = RepoList.GetAll();
			m_repoList.Sort((r1, r2) => Util.StrCmpLogicalW(r1.name, r2.name));
			int selectedIndex = -1, cnt = 0;
			foreach (var repo in m_repoList) {
				ComboBox_Repository.Items.Add(repo.name);
				if (repo.guid == GUI.repoSelected) {
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
			GUI.repo.Clear();
			ComboBox_Repository.SelectedIndex = -1;
			GUI.repoSelected = new Guid();
			CheckBox_FromLeader.Visible = false;
			CheckBox_ToState.Visible = false;
			CheckedListBox_To.Visible = false;
			CheckedListBox_To.Items.Clear();
			Button_Replicate.Enabled = false;
			ClearChangeGUI();
		}

		private void ClearChangeGUI() {
			TextBox_ViewTitle.Text = Strings0.NoChanges;
			TextBox_ViewInfo.Text = "";
			ListBox_Changes.Items.Clear();
		}

		private void ChangeCurrentRepo(int index) {
			if (index < 0 || m_repoList.Count <= index)
				return;
			if (GUI.repo.GetGuid() == m_repoList[index].guid)
				return;
			if (!GUI.repo.Load(m_repoList[index])) {
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

			GUI.repoSelected = m_repoList[index].guid;

			CheckBox_FromLeader.Text = GUI.repo.GetLeaderName();
			CheckBox_FromLeader.Visible = true;

			CheckedListBox_To.Items.Clear();
			{
				var list = GUI.repo.GetFollowersName();
				list.Sort(Util.StrCmpLogicalW);
				foreach (var f in list)
					CheckedListBox_To.Items.Add(f);
			}
			CheckedListBox_To.Visible = true;
			Button_Replicate.Enabled = true;

			ChooseAll(true);
			CheckBox_ToState.Visible = true;

			RefreshRealtime();
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

		private void RefreshChange() {
			var list = GUI.repo.GetLeaderChanges();
			if (list.Count == 0) {
				ClearChangeGUI();
				return;
			}
			ListBox_Changes.Items.Clear();
			foreach (var f in list) {
				switch (f.type) {
				case FileChange.Type.Add:
					ListBox_Changes.Items.Add("[A] " + f.path);
					break;
				case FileChange.Type.Modified:
					ListBox_Changes.Items.Add("[M] " + f.path);
					break;
				case FileChange.Type.Deleted:
					ListBox_Changes.Items.Add("[D] " + f.path);
					break;
				}
			}
			TextBox_ViewTitle.Text = string.Format(Strings0.FileChanges, list.Count);
		}

		private void RefreshRealtime() {
			if (!GUI.repo.RefreshRealtimeMap())
				return;
			RefreshChange();
		}

		#endregion

		#region Events

		private void FormMain_Load(object sender, EventArgs e) {
			RepoList.Load();
			GUI.repoSelected = Settings0.Default.LastSelectedRepo;
			UpdateRepoList();

			ListBox_History.Items.Add(Strings0.NotImplemented);
		}

		private void FormMain_Activated(object sender, EventArgs e) {
			RefreshRealtime();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			RepoList.Save();
			Settings0.Default.LastSelectedRepo = GUI.repoSelected;
			Settings0.Default.Save();
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
		}

		private void ComboBox_Repository_SelectedIndexChanged(object sender, EventArgs e) {
			ChangeCurrentRepo(ComboBox_Repository.SelectedIndex);
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

		private void CheckedListBox_To_SelectedIndexChanged(object sender, EventArgs e) {
			CheckedListBox_To.ClearSelected();
		}

		private async void Button_Replicate_Click(object sender, EventArgs e) {
			Button_Replicate.Enabled = false;
			List<string> target = [];
			for (int i = 0, n = CheckedListBox_To.Items.Count; i < n; i++) {
				if (CheckedListBox_To.GetItemChecked(i)) {
					var text = CheckedListBox_To.GetItemText(CheckedListBox_To.Items[i]);
					if (text != null)
						target.Add(text);
				}
			}
			if (target.Count <= 0)
				return;
			//GUI.test?.Show(this);
			await Task.Run(() => GUI.repo.Replicate(target));
			//GUI.test?.Close();
			RefreshRealtime();
			Button_Replicate.Enabled = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void StripMenuItem_Refresh_Click(object sender, EventArgs e) {
			RefreshRealtime();
		}

		#endregion

		private void newRepositoryToolStripMenuItem_Click(object sender, EventArgs e) {
			var dialog = new FormNewRepo();
			var res = dialog.ShowDialog(this);
			if (res == DialogResult.OK) {
				UpdateRepoList();
			}
		}

		private void manageRepositoriesToolStripMenuItem_Click(object sender, EventArgs e) {
			NotImplemented();
		}

		private void renameRepositoryToolStripMenuItem_Click(object sender, EventArgs e) {
			NotImplemented();
		}

		private void manageStreamsToolStripMenuItem_Click(object sender, EventArgs e) {
			if (!GUI.repo.IsAvailable())
				return;
			var dialog = new FormMngStream();
			var res = dialog.ShowDialog(this);
			if (res == DialogResult.OK) {
				var s = GUI.repoSelected;
				ClearCurrentRepo();
				GUI.repoSelected = s;
				UpdateRepoList();
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

	}
}
