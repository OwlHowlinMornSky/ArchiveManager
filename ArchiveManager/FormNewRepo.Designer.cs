namespace ArchiveManager {
	partial class FormNewRepo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewRepo));
			label_reponame = new Label();
			textBox_reponame = new TextBox();
			textBox_leaderpath = new TextBox();
			button_leaderbrowse = new Button();
			button_ok = new Button();
			button_cancel = new Button();
			textBox_leadername = new TextBox();
			label1 = new Label();
			groupBox_leaderStream = new GroupBox();
			label_path = new Label();
			label_leadername = new Label();
			m_folderBrowserDialog = new FolderBrowserDialog();
			groupBox_leaderStream.SuspendLayout();
			SuspendLayout();
			// 
			// label_reponame
			// 
			resources.ApplyResources(label_reponame, "label_reponame");
			label_reponame.Name = "label_reponame";
			// 
			// textBox_reponame
			// 
			resources.ApplyResources(textBox_reponame, "textBox_reponame");
			textBox_reponame.Name = "textBox_reponame";
			// 
			// textBox_leaderpath
			// 
			resources.ApplyResources(textBox_leaderpath, "textBox_leaderpath");
			textBox_leaderpath.Name = "textBox_leaderpath";
			textBox_leaderpath.ReadOnly = true;
			// 
			// button_leaderbrowse
			// 
			resources.ApplyResources(button_leaderbrowse, "button_leaderbrowse");
			button_leaderbrowse.Name = "button_leaderbrowse";
			button_leaderbrowse.UseVisualStyleBackColor = true;
			button_leaderbrowse.Click += button_leaderbrowse_Click;
			// 
			// button_ok
			// 
			resources.ApplyResources(button_ok, "button_ok");
			button_ok.Name = "button_ok";
			button_ok.UseVisualStyleBackColor = true;
			button_ok.Click += button_ok_Click;
			// 
			// button_cancel
			// 
			resources.ApplyResources(button_cancel, "button_cancel");
			button_cancel.Name = "button_cancel";
			button_cancel.UseVisualStyleBackColor = true;
			button_cancel.Click += button_cancel_Click;
			// 
			// textBox_leadername
			// 
			resources.ApplyResources(textBox_leadername, "textBox_leadername");
			textBox_leadername.Name = "textBox_leadername";
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Name = "label1";
			// 
			// groupBox_leaderStream
			// 
			resources.ApplyResources(groupBox_leaderStream, "groupBox_leaderStream");
			groupBox_leaderStream.Controls.Add(label_path);
			groupBox_leaderStream.Controls.Add(label_leadername);
			groupBox_leaderStream.Controls.Add(label1);
			groupBox_leaderStream.Controls.Add(button_leaderbrowse);
			groupBox_leaderStream.Controls.Add(textBox_leadername);
			groupBox_leaderStream.Controls.Add(textBox_leaderpath);
			groupBox_leaderStream.Name = "groupBox_leaderStream";
			groupBox_leaderStream.TabStop = false;
			// 
			// label_path
			// 
			resources.ApplyResources(label_path, "label_path");
			label_path.Name = "label_path";
			// 
			// label_leadername
			// 
			resources.ApplyResources(label_leadername, "label_leadername");
			label_leadername.Name = "label_leadername";
			// 
			// m_folderBrowserDialog
			// 
			resources.ApplyResources(m_folderBrowserDialog, "m_folderBrowserDialog");
			// 
			// FormNewRepo
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox_leaderStream);
			Controls.Add(button_cancel);
			Controls.Add(button_ok);
			Controls.Add(textBox_reponame);
			Controls.Add(label_reponame);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormNewRepo";
			ShowIcon = false;
			ShowInTaskbar = false;
			SizeGripStyle = SizeGripStyle.Hide;
			groupBox_leaderStream.ResumeLayout(false);
			groupBox_leaderStream.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label_reponame;
		private TextBox textBox_reponame;
		private TextBox textBox_leaderpath;
		private Button button_leaderbrowse;
		private Button button_ok;
		private Button button_cancel;
		private TextBox textBox_leadername;
		private Label label1;
		private GroupBox groupBox_leaderStream;
		private Label label_leadername;
		private Label label_path;
		private FolderBrowserDialog m_folderBrowserDialog;
	}
}