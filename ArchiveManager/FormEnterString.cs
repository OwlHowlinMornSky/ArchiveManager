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

		/// <summary>
		/// 显示的窗口标题。请在new之后写入。
		/// </summary>
		public string? ui_title;
		/// <summary>
		/// 显示的提示内容。请在new之后写入。
		/// </summary>
		public string? ui_main;
		/// <summary>
		/// 最终文本框的内容。
		/// </summary>
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
			if (textBox_main.Text.Length <= 0) { // 必须在文本框写入内容。
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
