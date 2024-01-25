namespace ArchiveManager {
	public partial class FormMain : Form {
		public FormMain() {
			InitializeComponent();
		}

		enum ViewState {
			NoChanges = 0,
			ViewChangesNoInfo,
			ViewChanges
		}

		private void ChangeViewState(ViewState state) {
			switch (state) {
			case ViewState.NoChanges:
				Panel_ViewNoChanges.Visible = true;
				Panel_ViewChanges.Visible = false;
				break;
			case ViewState.ViewChangesNoInfo:
				Panel_ViewNoChanges.Visible = true;
				Panel_ViewChanges.Visible = false;
				Panel_CommitInfo.Visible = false;
				break;
			case ViewState.ViewChanges:
				Panel_ViewNoChanges.Visible = true;
				Panel_ViewChanges.Visible = false;
				Panel_CommitInfo.Visible = true;
				break;
			default:
				throw new ArgumentException("ChangeViewState: Invalid View State.");
			}
		}

		private void FormMain_Load(object sender, EventArgs e) {
			ChangeViewState(ViewState.NoChanges);
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			switch (e.CloseReason) {
			case CloseReason.None:
				break;
			case CloseReason.UserClosing:
				var res = MessageBox.Show("User Closing.", "Info", MessageBoxButtons.OKCancel);
				switch (res) {
				case DialogResult.Cancel:
					e.Cancel = true;
					//Button_Submit.Visible = !Button_Submit.Visible;
					break;
				}
				break;
			}
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
			Settings0.Default.Save();
		}

	}
}
