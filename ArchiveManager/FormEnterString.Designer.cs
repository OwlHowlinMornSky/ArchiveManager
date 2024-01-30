namespace ArchiveManager {
	partial class FormEnterString {
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
			button_ok = new Button();
			button_cancel = new Button();
			textBox_main = new TextBox();
			label_main = new Label();
			SuspendLayout();
			// 
			// button_ok
			// 
			button_ok.Location = new Point(176, 136);
			button_ok.Name = "button_ok";
			button_ok.Size = new Size(75, 23);
			button_ok.TabIndex = 0;
			button_ok.Text = "OK";
			button_ok.UseVisualStyleBackColor = true;
			button_ok.Click += button_ok_Click;
			// 
			// button_cancel
			// 
			button_cancel.Location = new Point(257, 136);
			button_cancel.Name = "button_cancel";
			button_cancel.Size = new Size(75, 23);
			button_cancel.TabIndex = 1;
			button_cancel.Text = "Cancel";
			button_cancel.UseVisualStyleBackColor = true;
			button_cancel.Click += button_cancel_Click;
			// 
			// textBox_main
			// 
			textBox_main.Location = new Point(12, 39);
			textBox_main.Name = "textBox_main";
			textBox_main.Size = new Size(320, 23);
			textBox_main.TabIndex = 2;
			// 
			// label_main
			// 
			label_main.AutoSize = true;
			label_main.Location = new Point(12, 19);
			label_main.Name = "label_main";
			label_main.Size = new Size(36, 17);
			label_main.TabIndex = 3;
			label_main.Text = "main";
			// 
			// FormEnterString
			// 
			AcceptButton = button_ok;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = button_cancel;
			ClientSize = new Size(344, 171);
			Controls.Add(label_main);
			Controls.Add(textBox_main);
			Controls.Add(button_cancel);
			Controls.Add(button_ok);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormEnterString";
			ShowIcon = false;
			ShowInTaskbar = false;
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterParent;
			Text = "title";
			Load += FormEnterString_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button_ok;
		private Button button_cancel;
		private TextBox textBox_main;
		private Label label_main;
	}
}