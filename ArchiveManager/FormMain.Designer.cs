namespace ArchiveManager {
	partial class FormMain {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			SplitContainer_Main = new SplitContainer();
			TabControl_Left = new TabControl();
			TabPage_Replicate = new TabPage();
			GroupBox_ReplicateTo = new GroupBox();
			CheckedListBox_To = new CheckedListBox();
			CheckBox_ToState = new CheckBox();
			GroupBox_ReplicateFrom = new GroupBox();
			CheckBox_FromLeader = new CheckBox();
			Button_Replicate = new Button();
			TabPage_History = new TabPage();
			ListBox_History = new ListBox();
			ComboBox_Repository = new ComboBox();
			SplitContainer_View = new SplitContainer();
			ContextMenuStrip_View = new ContextMenuStrip(components);
			StripMenuItem_Refresh = new ToolStripMenuItem();
			ListBox_Changes = new ListBox();
			Panel_ViewTop = new Panel();
			TextBox_ViewInfo = new TextBox();
			TextBox_ViewTitle = new TextBox();
			MenuStrip_Main = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			newRepositoryToolStripMenuItem = new ToolStripMenuItem();
			manageRepositoriesToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			renameRepositoryToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			manageStreamsToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			FolderBrowserDialog_Add = new FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)SplitContainer_Main).BeginInit();
			SplitContainer_Main.Panel1.SuspendLayout();
			SplitContainer_Main.Panel2.SuspendLayout();
			SplitContainer_Main.SuspendLayout();
			TabControl_Left.SuspendLayout();
			TabPage_Replicate.SuspendLayout();
			GroupBox_ReplicateTo.SuspendLayout();
			GroupBox_ReplicateFrom.SuspendLayout();
			TabPage_History.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer_View).BeginInit();
			SplitContainer_View.Panel1.SuspendLayout();
			SplitContainer_View.SuspendLayout();
			ContextMenuStrip_View.SuspendLayout();
			Panel_ViewTop.SuspendLayout();
			MenuStrip_Main.SuspendLayout();
			SuspendLayout();
			// 
			// SplitContainer_Main
			// 
			SplitContainer_Main.BorderStyle = BorderStyle.FixedSingle;
			resources.ApplyResources(SplitContainer_Main, "SplitContainer_Main");
			SplitContainer_Main.FixedPanel = FixedPanel.Panel1;
			SplitContainer_Main.Name = "SplitContainer_Main";
			// 
			// SplitContainer_Main.Panel1
			// 
			SplitContainer_Main.Panel1.Controls.Add(TabControl_Left);
			SplitContainer_Main.Panel1.Controls.Add(ComboBox_Repository);
			// 
			// SplitContainer_Main.Panel2
			// 
			SplitContainer_Main.Panel2.BackColor = SystemColors.AppWorkspace;
			SplitContainer_Main.Panel2.Controls.Add(SplitContainer_View);
			SplitContainer_Main.Panel2.Controls.Add(Panel_ViewTop);
			SplitContainer_Main.TabStop = false;
			// 
			// TabControl_Left
			// 
			TabControl_Left.Controls.Add(TabPage_Replicate);
			TabControl_Left.Controls.Add(TabPage_History);
			resources.ApplyResources(TabControl_Left, "TabControl_Left");
			TabControl_Left.Name = "TabControl_Left";
			TabControl_Left.SelectedIndex = 0;
			// 
			// TabPage_Replicate
			// 
			TabPage_Replicate.BackColor = SystemColors.Control;
			TabPage_Replicate.Controls.Add(GroupBox_ReplicateTo);
			TabPage_Replicate.Controls.Add(GroupBox_ReplicateFrom);
			TabPage_Replicate.Controls.Add(Button_Replicate);
			resources.ApplyResources(TabPage_Replicate, "TabPage_Replicate");
			TabPage_Replicate.Name = "TabPage_Replicate";
			// 
			// GroupBox_ReplicateTo
			// 
			GroupBox_ReplicateTo.Controls.Add(CheckedListBox_To);
			GroupBox_ReplicateTo.Controls.Add(CheckBox_ToState);
			resources.ApplyResources(GroupBox_ReplicateTo, "GroupBox_ReplicateTo");
			GroupBox_ReplicateTo.Name = "GroupBox_ReplicateTo";
			GroupBox_ReplicateTo.TabStop = false;
			// 
			// CheckedListBox_To
			// 
			CheckedListBox_To.BackColor = SystemColors.Control;
			CheckedListBox_To.BorderStyle = BorderStyle.None;
			CheckedListBox_To.CheckOnClick = true;
			resources.ApplyResources(CheckedListBox_To, "CheckedListBox_To");
			CheckedListBox_To.FormattingEnabled = true;
			CheckedListBox_To.Name = "CheckedListBox_To";
			CheckedListBox_To.ItemCheck += CheckedListBox_To_ItemCheck;
			CheckedListBox_To.SelectedIndexChanged += CheckedListBox_To_SelectedIndexChanged;
			// 
			// CheckBox_ToState
			// 
			CheckBox_ToState.AutoCheck = false;
			resources.ApplyResources(CheckBox_ToState, "CheckBox_ToState");
			CheckBox_ToState.Name = "CheckBox_ToState";
			CheckBox_ToState.ThreeState = true;
			CheckBox_ToState.UseVisualStyleBackColor = true;
			CheckBox_ToState.Click += CheckBox_ToState_Click;
			// 
			// GroupBox_ReplicateFrom
			// 
			GroupBox_ReplicateFrom.Controls.Add(CheckBox_FromLeader);
			resources.ApplyResources(GroupBox_ReplicateFrom, "GroupBox_ReplicateFrom");
			GroupBox_ReplicateFrom.Name = "GroupBox_ReplicateFrom";
			GroupBox_ReplicateFrom.TabStop = false;
			// 
			// CheckBox_FromLeader
			// 
			CheckBox_FromLeader.AutoCheck = false;
			resources.ApplyResources(CheckBox_FromLeader, "CheckBox_FromLeader");
			CheckBox_FromLeader.Checked = true;
			CheckBox_FromLeader.CheckState = CheckState.Checked;
			CheckBox_FromLeader.Name = "CheckBox_FromLeader";
			CheckBox_FromLeader.UseVisualStyleBackColor = true;
			// 
			// Button_Replicate
			// 
			resources.ApplyResources(Button_Replicate, "Button_Replicate");
			Button_Replicate.Name = "Button_Replicate";
			Button_Replicate.UseVisualStyleBackColor = true;
			Button_Replicate.Click += Button_Replicate_Click;
			// 
			// TabPage_History
			// 
			TabPage_History.Controls.Add(ListBox_History);
			resources.ApplyResources(TabPage_History, "TabPage_History");
			TabPage_History.Name = "TabPage_History";
			TabPage_History.UseVisualStyleBackColor = true;
			// 
			// ListBox_History
			// 
			resources.ApplyResources(ListBox_History, "ListBox_History");
			ListBox_History.FormattingEnabled = true;
			ListBox_History.Items.AddRange(new object[] { resources.GetString("ListBox_History.Items") });
			ListBox_History.Name = "ListBox_History";
			// 
			// ComboBox_Repository
			// 
			resources.ApplyResources(ComboBox_Repository, "ComboBox_Repository");
			ComboBox_Repository.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Repository.FormattingEnabled = true;
			ComboBox_Repository.Name = "ComboBox_Repository";
			ComboBox_Repository.SelectedIndexChanged += ComboBox_Repository_SelectedIndexChanged;
			// 
			// SplitContainer_View
			// 
			SplitContainer_View.BorderStyle = BorderStyle.FixedSingle;
			SplitContainer_View.ContextMenuStrip = ContextMenuStrip_View;
			resources.ApplyResources(SplitContainer_View, "SplitContainer_View");
			SplitContainer_View.FixedPanel = FixedPanel.Panel1;
			SplitContainer_View.Name = "SplitContainer_View";
			// 
			// SplitContainer_View.Panel1
			// 
			SplitContainer_View.Panel1.BackColor = SystemColors.Control;
			SplitContainer_View.Panel1.Controls.Add(ListBox_Changes);
			// 
			// ContextMenuStrip_View
			// 
			ContextMenuStrip_View.Items.AddRange(new ToolStripItem[] { StripMenuItem_Refresh });
			ContextMenuStrip_View.Name = "ContextMenuStrip_View";
			resources.ApplyResources(ContextMenuStrip_View, "ContextMenuStrip_View");
			// 
			// StripMenuItem_Refresh
			// 
			StripMenuItem_Refresh.Name = "StripMenuItem_Refresh";
			resources.ApplyResources(StripMenuItem_Refresh, "StripMenuItem_Refresh");
			// 
			// ListBox_Changes
			// 
			ListBox_Changes.BackColor = SystemColors.Control;
			resources.ApplyResources(ListBox_Changes, "ListBox_Changes");
			ListBox_Changes.FormattingEnabled = true;
			ListBox_Changes.Name = "ListBox_Changes";
			// 
			// Panel_ViewTop
			// 
			Panel_ViewTop.BackColor = SystemColors.Control;
			Panel_ViewTop.BorderStyle = BorderStyle.FixedSingle;
			Panel_ViewTop.Controls.Add(TextBox_ViewInfo);
			Panel_ViewTop.Controls.Add(TextBox_ViewTitle);
			resources.ApplyResources(Panel_ViewTop, "Panel_ViewTop");
			Panel_ViewTop.Name = "Panel_ViewTop";
			// 
			// TextBox_ViewInfo
			// 
			TextBox_ViewInfo.BackColor = SystemColors.Window;
			TextBox_ViewInfo.BorderStyle = BorderStyle.None;
			resources.ApplyResources(TextBox_ViewInfo, "TextBox_ViewInfo");
			TextBox_ViewInfo.Name = "TextBox_ViewInfo";
			TextBox_ViewInfo.ReadOnly = true;
			// 
			// TextBox_ViewTitle
			// 
			TextBox_ViewTitle.BackColor = SystemColors.Window;
			TextBox_ViewTitle.BorderStyle = BorderStyle.None;
			resources.ApplyResources(TextBox_ViewTitle, "TextBox_ViewTitle");
			TextBox_ViewTitle.Name = "TextBox_ViewTitle";
			TextBox_ViewTitle.ReadOnly = true;
			// 
			// MenuStrip_Main
			// 
			MenuStrip_Main.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
			resources.ApplyResources(MenuStrip_Main, "MenuStrip_Main");
			MenuStrip_Main.Name = "MenuStrip_Main";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newRepositoryToolStripMenuItem, manageRepositoriesToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// newRepositoryToolStripMenuItem
			// 
			newRepositoryToolStripMenuItem.Name = "newRepositoryToolStripMenuItem";
			resources.ApplyResources(newRepositoryToolStripMenuItem, "newRepositoryToolStripMenuItem");
			// 
			// manageRepositoriesToolStripMenuItem
			// 
			manageRepositoriesToolStripMenuItem.Name = "manageRepositoriesToolStripMenuItem";
			resources.ApplyResources(manageRepositoriesToolStripMenuItem, "manageRepositoriesToolStripMenuItem");
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { renameRepositoryToolStripMenuItem, toolStripSeparator2, manageStreamsToolStripMenuItem });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
			// 
			// renameRepositoryToolStripMenuItem
			// 
			renameRepositoryToolStripMenuItem.Name = "renameRepositoryToolStripMenuItem";
			resources.ApplyResources(renameRepositoryToolStripMenuItem, "renameRepositoryToolStripMenuItem");
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
			// 
			// manageStreamsToolStripMenuItem
			// 
			manageStreamsToolStripMenuItem.Name = "manageStreamsToolStripMenuItem";
			resources.ApplyResources(manageStreamsToolStripMenuItem, "manageStreamsToolStripMenuItem");
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
			// 
			// FolderBrowserDialog_Add
			// 
			resources.ApplyResources(FolderBrowserDialog_Add, "FolderBrowserDialog_Add");
			FolderBrowserDialog_Add.ShowNewFolderButton = false;
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(SplitContainer_Main);
			Controls.Add(MenuStrip_Main);
			MainMenuStrip = MenuStrip_Main;
			Name = "FormMain";
			FormClosing += FormMain_FormClosing;
			FormClosed += FormMain_FormClosed;
			Load += FormMain_Load;
			SplitContainer_Main.Panel1.ResumeLayout(false);
			SplitContainer_Main.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainer_Main).EndInit();
			SplitContainer_Main.ResumeLayout(false);
			TabControl_Left.ResumeLayout(false);
			TabPage_Replicate.ResumeLayout(false);
			GroupBox_ReplicateTo.ResumeLayout(false);
			GroupBox_ReplicateTo.PerformLayout();
			GroupBox_ReplicateFrom.ResumeLayout(false);
			GroupBox_ReplicateFrom.PerformLayout();
			TabPage_History.ResumeLayout(false);
			SplitContainer_View.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainer_View).EndInit();
			SplitContainer_View.ResumeLayout(false);
			ContextMenuStrip_View.ResumeLayout(false);
			Panel_ViewTop.ResumeLayout(false);
			Panel_ViewTop.PerformLayout();
			MenuStrip_Main.ResumeLayout(false);
			MenuStrip_Main.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip MenuStrip_Main;
		private ToolStripMenuItem helpToolStripMenuItem;
		private SplitContainer SplitContainer_Main;
		private ComboBox ComboBox_Repository;
		private TabControl TabControl_Left;
		private TabPage TabPage_Replicate;
		private TabPage TabPage_History;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private FolderBrowserDialog FolderBrowserDialog_Add;
		private ListBox ListBox_History;
		private GroupBox GroupBox_ReplicateTo;
		private GroupBox GroupBox_ReplicateFrom;
		private Button Button_Replicate;
		private CheckBox CheckBox_FromLeader;
		private CheckedListBox CheckedListBox_To;
		private CheckBox CheckBox_ToState;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newRepositoryToolStripMenuItem;
		private ToolStripMenuItem manageRepositoriesToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem renameRepositoryToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem manageStreamsToolStripMenuItem;
		private ListBox ListBox_Changes;
		private SplitContainer SplitContainer_View;
		private Panel Panel_ViewTop;
		private TextBox TextBox_ViewInfo;
		private TextBox TextBox_ViewTitle;
		private ContextMenuStrip ContextMenuStrip_View;
		private ToolStripMenuItem StripMenuItem_Refresh;
	}
}
