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
	public partial class FormTest : Form {

		public FormTest() {
			InitializeComponent();
		}

		public void AddText(string str) {
			if (InvokeRequired) {
				var r = BeginInvoke(new Action(() => { label1.Text += '\n' + str; }));
				EndInvoke(r);
			}
			else {
				label1.Text += '\n' + str;
			}
		}

		public void UseOver() {
			if (InvokeRequired) {
				var r = BeginInvoke(new Action(() => { Close(); }));
				EndInvoke(r);
			}
			else {
				Close();
			}
		}

	}
}
