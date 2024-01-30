using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ArchiveManager {
	public partial class FormNewRepo : Form {
		public FormNewRepo() {
			InitializeComponent();
		}

		private void button_leaderbrowse_Click(object sender, EventArgs e) {
			if (m_folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
				textBox_leaderpath.Text = m_folderBrowserDialog.SelectedPath;
		}

		private void button_ok_Click(object sender, EventArgs e) {
			if (textBox_reponame.Text.Length <= 0) {
				MessageBox.Show(
					StringsNewRepo.RepoNameEmpty,
					Text,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
				return;
			}
			if (textBox_leadername.Text.Length <= 0) {
				MessageBox.Show(
					StringsNewRepo.LeaderNameEmpty,
					Text,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
				return;
			}
			if (textBox_leaderpath.Text.Length <= 0) {
				MessageBox.Show(
					StringsNewRepo.LeaderPathEmpty,
					Text,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
				return;
			}

			if (GUI.CheckStreamName(textBox_leadername.Text, out string leadername)) {
				var res = MessageBox.Show(
					string.Format(
						StringsNewRepo.ReplaceLeaderName,
						textBox_leadername.Text,
						leadername
					),
					Text,
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Information
				);
				if (res == DialogResult.Cancel)
					return;
			}

			Guid guid = Guid.NewGuid();
			string reponame = textBox_reponame.Text;
			string leaderpath = textBox_leaderpath.Text;

			Repository.Create(guid, reponame, leadername, leaderpath);

			RepoList.Add(new(guid, reponame));


			DialogResult = DialogResult.OK;
			Close();
		}

		private void button_cancel_Click(object sender, EventArgs e) {
			Close();
		}

	}
}
