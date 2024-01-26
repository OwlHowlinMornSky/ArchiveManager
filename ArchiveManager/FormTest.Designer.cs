namespace ArchiveManager {
	partial class FormTest {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			label1 = new Label();
			listBox1 = new ListBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(664, 42);
			label1.Name = "label1";
			label1.Size = new Size(43, 17);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 17;
			listBox1.Location = new Point(117, 117);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(120, 89);
			listBox1.TabIndex = 1;
			// 
			// FormTest
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(listBox1);
			Controls.Add(label1);
			Name = "FormTest";
			Text = "FormTest";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ListBox listBox1;
	}
}