namespace ArchiveManager {
	partial class FormMngStream {
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
			listBox_main = new ListBox();
			button_rename = new Button();
			button_cancel = new Button();
			button_add = new Button();
			button_remove = new Button();
			label_tip_leader = new Label();
			label_tip_follower = new Label();
			folderBrowserDialog1 = new FolderBrowserDialog();
			SuspendLayout();
			// 
			// listBox_main
			// 
			listBox_main.Dock = DockStyle.Left;
			listBox_main.FormattingEnabled = true;
			listBox_main.ItemHeight = 17;
			listBox_main.Location = new Point(0, 0);
			listBox_main.Name = "listBox_main";
			listBox_main.Size = new Size(300, 441);
			listBox_main.TabIndex = 0;
			listBox_main.SelectedIndexChanged += listBox_main_SelectedIndexChanged;
			// 
			// button_rename
			// 
			button_rename.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button_rename.Location = new Point(317, 36);
			button_rename.Name = "button_rename";
			button_rename.Size = new Size(75, 23);
			button_rename.TabIndex = 1;
			button_rename.Text = "Rename";
			button_rename.UseVisualStyleBackColor = true;
			button_rename.Click += button_rename_Click;
			// 
			// button_cancel
			// 
			button_cancel.Location = new Point(317, 406);
			button_cancel.Name = "button_cancel";
			button_cancel.Size = new Size(75, 23);
			button_cancel.TabIndex = 2;
			button_cancel.Text = "Cancel";
			button_cancel.UseVisualStyleBackColor = true;
			button_cancel.Click += button_cancel_Click;
			// 
			// button_add
			// 
			button_add.Location = new Point(317, 65);
			button_add.Name = "button_add";
			button_add.Size = new Size(75, 23);
			button_add.TabIndex = 3;
			button_add.Text = "Add";
			button_add.UseVisualStyleBackColor = true;
			button_add.Click += button_add_Click;
			// 
			// button_remove
			// 
			button_remove.Location = new Point(317, 94);
			button_remove.Name = "button_remove";
			button_remove.Size = new Size(75, 23);
			button_remove.TabIndex = 4;
			button_remove.Text = "Remove";
			button_remove.UseVisualStyleBackColor = true;
			button_remove.Click += button_remove_Click;
			// 
			// label_tip_leader
			// 
			label_tip_leader.AutoSize = true;
			label_tip_leader.Location = new Point(317, 9);
			label_tip_leader.Name = "label_tip_leader";
			label_tip_leader.Size = new Size(48, 17);
			label_tip_leader.TabIndex = 5;
			label_tip_leader.Text = "Leader";
			// 
			// label_tip_follower
			// 
			label_tip_follower.AutoSize = true;
			label_tip_follower.Location = new Point(317, 386);
			label_tip_follower.Name = "label_tip_follower";
			label_tip_follower.Size = new Size(57, 17);
			label_tip_follower.TabIndex = 6;
			label_tip_follower.Text = "Follower";
			// 
			// FormMngStream
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = button_cancel;
			ClientSize = new Size(404, 441);
			Controls.Add(label_tip_follower);
			Controls.Add(label_tip_leader);
			Controls.Add(button_remove);
			Controls.Add(button_add);
			Controls.Add(button_cancel);
			Controls.Add(button_rename);
			Controls.Add(listBox_main);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormMngStream";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Manage Streams";
			Load += FormMngStream_Load;
			SizeChanged += FormMngStream_SizeChanged;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBox_main;
		private Button button_rename;
		private Button button_cancel;
		private Button button_add;
		private Button button_remove;
		private Label label_tip_leader;
		private Label label_tip_follower;
		private FolderBrowserDialog folderBrowserDialog1;
	}
}