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
	public partial class FormEnterString : Form {

		public string? ui_title;
		public string? ui_main;

		public string? str_result;

		public FormEnterString() {
			InitializeComponent();
		}

		private void FormEnterString_Load(object sender, EventArgs e) {
			if (ui_title != null)
				Text = ui_title;
			if (ui_main != null)
				label_main.Text = ui_main;
		}

		private void button_ok_Click(object sender, EventArgs e) {
			if (textBox_main.Text.Length <= 0) {
				textBox_main.Focus();
				Util.MessageBeep(Util.BeepType.MB_ICONERROR);
				return;
			}
			DialogResult = DialogResult.OK;
			str_result = textBox_main.Text;
			Close();
		}

		private void button_cancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
