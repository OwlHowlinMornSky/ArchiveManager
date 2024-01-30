using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManager {
	public partial class FormMngStream : Form {

		int selectedIndex;

		public FormMngStream() {
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

		private void FormMngStream_Load(object sender, EventArgs e) {
			label_tip_follower.Location = label_tip_leader.Location;
			label_tip_follower.Visible = false;
			label_tip_leader.Visible = false;

			button_remove.Enabled = false;
			button_rename.Enabled = false;

			listBox_main.Items.Add(GUI.repo.GetLeaderName());
			var list = GUI.repo.GetFollowersName();
			list.Sort(Util.StrCmpLogicalW);
			foreach (var f in list)
				listBox_main.Items.Add(f);
		}

		private void FormMngStream_SizeChanged(object sender, EventArgs e) {
			var size = listBox_main.Size;
			size.Width = Size.Width - 120;
			listBox_main.Size = size;
		}

		private void listBox_main_SelectedIndexChanged(object sender, EventArgs e) {
			if (listBox_main.SelectedIndex < 0) {
				return;
			}
			selectedIndex = listBox_main.SelectedIndex;
			var str = listBox_main.GetItemText(listBox_main.Items[selectedIndex]);
			if (str == GUI.repo.GetLeaderName()) {
				label_tip_leader.Visible = true;
				label_tip_follower.Visible = false;

				button_remove.Enabled = false;
				button_rename.Enabled = true;
			}
			else {
				label_tip_leader.Visible = false;
				label_tip_follower.Visible = true;

				button_remove.Enabled = true;
				button_rename.Enabled = true;
			}
		}

		private void button_rename_Click(object sender, EventArgs e) {
			NotImplemented();
		}

		private void button_add_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;

			var dialog = new FormEnterString() {
				ui_title = "t1",
				ui_main = "t2"
			};

			var res = folderBrowserDialog1.ShowDialog(this);
			if (res != DialogResult.OK) {
				return;
			}
			string path = folderBrowserDialog1.SelectedPath;

			res = dialog.ShowDialog(this);
			if (res == DialogResult.OK && dialog.str_result != null) {
				if (GUI.CheckStreamName(dialog.str_result, out string name)) {
					var res1 = MessageBox.Show(
						string.Format(
							StringsNewRepo.ReplaceLeaderName,
							dialog.str_result,
							name
						),
						Text,
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Information
					);
					if (res1 == DialogResult.Cancel)
						return;
				}
				if (GUI.repo.AddFollower(name, path)) {
					DialogResult = DialogResult.OK;
				}
			}
			Close();
		}

		private void button_remove_Click(object sender, EventArgs e) {
			NotImplemented();
		}

		private void button_cancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
