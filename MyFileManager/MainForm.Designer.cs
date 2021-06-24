namespace MyFileManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrivilege = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcjeProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tssLine6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBigIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetailedInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tssLine7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcessThread = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAdvance = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpArrow = new System.Windows.Forms.ToolStripButton();
            this.tssLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tscboAddress = new System.Windows.Forms.ToolStripComboBox();
            this.tssLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.tscboSearch = new System.Windows.Forms.ToolStripComboBox();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBigIcon1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmallIcon1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiList1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetailedInfo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tssLine3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCopy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tssLine4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiNewFolder1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewFile1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newshortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssLine5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPrivilege1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProperties1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ilstIcons = new System.Windows.Forms.ImageList(this.components);
            this.ssFooter = new System.Windows.Forms.StatusStrip();
            this.tsslblFilesNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvwDirectory = new System.Windows.Forms.TreeView();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerP = new System.Windows.Forms.Timer(this.components);
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.ssFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.msMain.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.msMain.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.msMain.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msMain.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiView,
            this.tsmiTool,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.msMain.Size = new System.Drawing.Size(984, 27);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewFolder,
            this.tsmiNewFile,
            this.tsmiPrivilege,
            this.tsmiProperties,
            this.toolStripSeparator1,
            this.opcjeProgramuToolStripMenuItem});
            this.tsmiFile.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(40, 21);
            this.tsmiFile.Text = "Plik";
            this.tsmiFile.DropDownClosed += new System.EventHandler(this.tsmiFile_DropDownClosed);
            this.tsmiFile.DropDownOpening += new System.EventHandler(this.tsmiFile_DropDownOpening);
            this.tsmiFile.MouseEnter += new System.EventHandler(this.tsmiFile_MouseEnter);
            this.tsmiFile.MouseLeave += new System.EventHandler(this.tsmiFile_MouseLeave);
            // 
            // tsmiNewFolder
            // 
            this.tsmiNewFolder.Name = "tsmiNewFolder";
            this.tsmiNewFolder.Size = new System.Drawing.Size(234, 22);
            this.tsmiNewFolder.Text = "Nowy folder";
            this.tsmiNewFolder.Click += new System.EventHandler(this.tsmiNewFolder_Click);
            // 
            // tsmiNewFile
            // 
            this.tsmiNewFile.Name = "tsmiNewFile";
            this.tsmiNewFile.Size = new System.Drawing.Size(234, 22);
            this.tsmiNewFile.Text = "Nowy plik";
            this.tsmiNewFile.Click += new System.EventHandler(this.tsmiNewFile_Click);
            // 
            // tsmiPrivilege
            // 
            this.tsmiPrivilege.Name = "tsmiPrivilege";
            this.tsmiPrivilege.Size = new System.Drawing.Size(234, 22);
            this.tsmiPrivilege.Text = "Zarządzanie uprawnieniami";
            this.tsmiPrivilege.Click += new System.EventHandler(this.tsmiPrivilege_Click);
            // 
            // tsmiProperties
            // 
            this.tsmiProperties.Name = "tsmiProperties";
            this.tsmiProperties.Size = new System.Drawing.Size(234, 22);
            this.tsmiProperties.Text = "Właściwości";
            this.tsmiProperties.Click += new System.EventHandler(this.tsmiProperties_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // opcjeProgramuToolStripMenuItem
            // 
            this.opcjeProgramuToolStripMenuItem.Name = "opcjeProgramuToolStripMenuItem";
            this.opcjeProgramuToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.opcjeProgramuToolStripMenuItem.Text = "Opcje programu";
            this.opcjeProgramuToolStripMenuItem.Click += new System.EventHandler(this.opcjeProgramuToolStripMenuItem_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiCut,
            this.tsmiDelete});
            this.tsmiEdit.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(57, 21);
            this.tsmiEdit.Text = "Edycja";
            this.tsmiEdit.DropDownClosed += new System.EventHandler(this.tsmiEdit_DropDownClosed);
            this.tsmiEdit.DropDownOpening += new System.EventHandler(this.tsmiEdit_DropDownOpening);
            this.tsmiEdit.MouseEnter += new System.EventHandler(this.tsmiEdit_MouseEnter);
            this.tsmiEdit.MouseLeave += new System.EventHandler(this.tsmiEdit_MouseLeave);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(158, 22);
            this.tsmiCopy.Text = "Kopiuj";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(158, 22);
            this.tsmiPaste.Text = "Wklej";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(158, 22);
            this.tsmiCut.Text = "Wytnij";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiDelete.Size = new System.Drawing.Size(158, 22);
            this.tsmiDelete.Text = "Usuń";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatusbar,
            this.tsmiToolbar,
            this.toolStripMenuItem1,
            this.tssLine6,
            this.tsmiBigIcon,
            this.tsmiSmallIcon,
            this.tsmiList,
            this.tsmiDetailedInfo,
            this.tssLine7,
            this.tsmiRefresh});
            this.tsmiView.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(58, 21);
            this.tsmiView.Text = "Widok";
            this.tsmiView.DropDownClosed += new System.EventHandler(this.tsmiView_DropDownClosed);
            this.tsmiView.DropDownOpening += new System.EventHandler(this.tsmiView_DropDownOpening);
            this.tsmiView.MouseEnter += new System.EventHandler(this.tsmiView_MouseEnter);
            this.tsmiView.MouseLeave += new System.EventHandler(this.tsmiView_MouseLeave);
            // 
            // tsmiStatusbar
            // 
            this.tsmiStatusbar.Checked = global::MyFileManager.Properties.Settings.Default.MainStatusbar;
            this.tsmiStatusbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatusbar.Name = "tsmiStatusbar";
            this.tsmiStatusbar.Size = new System.Drawing.Size(180, 22);
            this.tsmiStatusbar.Text = "Pasek stanu";
            this.tsmiStatusbar.Click += new System.EventHandler(this.tsmiStatusbar_Click);
            // 
            // tsmiToolbar
            // 
            this.tsmiToolbar.Checked = global::MyFileManager.Properties.Settings.Default.MainToolbar;
            this.tsmiToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolbar.Name = "tsmiToolbar";
            this.tsmiToolbar.Size = new System.Drawing.Size(180, 22);
            this.tsmiToolbar.Text = "Pasek narzędzi";
            this.tsmiToolbar.Click += new System.EventHandler(this.tsmiToolbar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = global::MyFileManager.Properties.Settings.Default.PoleWyborutsmiView;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Pole wyboru";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tssLine6
            // 
            this.tssLine6.Name = "tssLine6";
            this.tssLine6.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiBigIcon
            // 
            this.tsmiBigIcon.Name = "tsmiBigIcon";
            this.tsmiBigIcon.Size = new System.Drawing.Size(180, 22);
            this.tsmiBigIcon.Text = "Duża ikona";
            this.tsmiBigIcon.Click += new System.EventHandler(this.tsmiBigIcon_Click);
            // 
            // tsmiSmallIcon
            // 
            this.tsmiSmallIcon.Name = "tsmiSmallIcon";
            this.tsmiSmallIcon.Size = new System.Drawing.Size(180, 22);
            this.tsmiSmallIcon.Text = "Mała ikona";
            this.tsmiSmallIcon.Click += new System.EventHandler(this.tsmiSmallIcon_Click);
            // 
            // tsmiList
            // 
            this.tsmiList.Name = "tsmiList";
            this.tsmiList.Size = new System.Drawing.Size(180, 22);
            this.tsmiList.Text = "Lista";
            this.tsmiList.Click += new System.EventHandler(this.tsmiList_Click);
            // 
            // tsmiDetailedInfo
            // 
            this.tsmiDetailedInfo.Name = "tsmiDetailedInfo";
            this.tsmiDetailedInfo.Size = new System.Drawing.Size(180, 22);
            this.tsmiDetailedInfo.Text = "Detale";
            this.tsmiDetailedInfo.Click += new System.EventHandler(this.tsmiDetailedInfo_Click);
            // 
            // tssLine7
            // 
            this.tssLine7.Name = "tssLine7";
            this.tssLine7.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(180, 22);
            this.tsmiRefresh.Text = "Odśwież";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // tsmiTool
            // 
            this.tsmiTool.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tsmiTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProcessThread,
            this.tsmiMonitor});
            this.tsmiTool.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tsmiTool.Name = "tsmiTool";
            this.tsmiTool.Size = new System.Drawing.Size(79, 21);
            this.tsmiTool.Text = "Narzędzia";
            this.tsmiTool.DropDownClosed += new System.EventHandler(this.tsmiTool_DropDownClosed);
            this.tsmiTool.DropDownOpening += new System.EventHandler(this.tsmiTool_DropDownOpening);
            this.tsmiTool.MouseEnter += new System.EventHandler(this.tsmiTool_MouseEnter);
            this.tsmiTool.MouseLeave += new System.EventHandler(this.tsmiTool_MouseLeave);
            // 
            // tsmiProcessThread
            // 
            this.tsmiProcessThread.Name = "tsmiProcessThread";
            this.tsmiProcessThread.Size = new System.Drawing.Size(272, 22);
            this.tsmiProcessThread.Text = "Zarządzanie procesami / wątkami";
            this.tsmiProcessThread.Click += new System.EventHandler(this.tsmiProcessThread_Click);
            // 
            // tsmiMonitor
            // 
            this.tsmiMonitor.Name = "tsmiMonitor";
            this.tsmiMonitor.Size = new System.Drawing.Size(272, 22);
            this.tsmiMonitor.Text = "Monitorowanie plików / folderów";
            this.tsmiMonitor.Click += new System.EventHandler(this.tsmiMonitor_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(60, 21);
            this.tsmiHelp.Text = "Pomoc";
            this.tsmiHelp.DropDownClosed += new System.EventHandler(this.tsmiHelp_DropDownClosed);
            this.tsmiHelp.DropDownOpening += new System.EventHandler(this.tsmiHelp_DropDownOpening);
            this.tsmiHelp.MouseEnter += new System.EventHandler(this.tsmiHelp_MouseEnter);
            this.tsmiHelp.MouseLeave += new System.EventHandler(this.tsmiHelp_MouseLeave);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "O programie";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsMain
            // 
            this.tsMain.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tsMain.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tsMain.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tsMain.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnBack,
            this.tsbtnAdvance,
            this.tsbtnUpArrow,
            this.tssLine1,
            this.tscboAddress,
            this.tssLine2,
            this.tscboSearch});
            this.tsMain.Location = new System.Drawing.Point(0, 27);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(984, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.BackColorChanged += new System.EventHandler(this.tsMain_BackColorChanged);
            // 
            // tsbtnBack
            // 
            this.tsbtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBack.Image")));
            this.tsbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBack.Name = "tsbtnBack";
            this.tsbtnBack.Size = new System.Drawing.Size(23, 22);
            this.tsbtnBack.Text = "toolStripButton1";
            this.tsbtnBack.Click += new System.EventHandler(this.tsbtnBack_Click);
            // 
            // tsbtnAdvance
            // 
            this.tsbtnAdvance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdvance.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdvance.Image")));
            this.tsbtnAdvance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdvance.Name = "tsbtnAdvance";
            this.tsbtnAdvance.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAdvance.Text = "toolStripButton1";
            this.tsbtnAdvance.Click += new System.EventHandler(this.tsbtnAdvance_Click);
            // 
            // tsbtnUpArrow
            // 
            this.tsbtnUpArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUpArrow.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpArrow.Image")));
            this.tsbtnUpArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpArrow.Name = "tsbtnUpArrow";
            this.tsbtnUpArrow.Size = new System.Drawing.Size(23, 22);
            this.tsbtnUpArrow.Text = "toolStripButton1";
            this.tsbtnUpArrow.Click += new System.EventHandler(this.tsbtnUpArrow_Click);
            // 
            // tssLine1
            // 
            this.tssLine1.Name = "tssLine1";
            this.tssLine1.Size = new System.Drawing.Size(6, 25);
            // 
            // tscboAddress
            // 
            this.tscboAddress.AutoSize = false;
            this.tscboAddress.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tscboAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscboAddress.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tscboAddress.Name = "tscboAddress";
            this.tscboAddress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tscboAddress.Size = new System.Drawing.Size(700, 25);
            this.tscboAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tscboAddress_KeyDown);
            // 
            // tssLine2
            // 
            this.tssLine2.Name = "tssLine2";
            this.tssLine2.Size = new System.Drawing.Size(6, 25);
            // 
            // tscboSearch
            // 
            this.tscboSearch.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tscboSearch.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tscboSearch.Name = "tscboSearch";
            this.tscboSearch.Size = new System.Drawing.Size(170, 25);
            this.tscboSearch.Text = "szybkie wyszukiwanie";
            this.tscboSearch.Enter += new System.EventHandler(this.tscboSearch_Enter);
            this.tscboSearch.Leave += new System.EventHandler(this.tscboSearch_Leave);
            this.tscboSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tscboSearch_KeyDown);
            this.tscboSearch.Click += new System.EventHandler(this.tscboSearch_Click);
            // 
            // cmsMain
            // 
            this.cmsMain.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.cmsMain.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmsMain.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmsMain.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiView1,
            this.tsmiRefresh1,
            this.tssLine3,
            this.tsmiCopy1,
            this.tsmiPaste1,
            this.tsmiCut1,
            this.tsmiDelete1,
            this.tsmiRename,
            this.tssLine4,
            this.tsmiNewFolder1,
            this.tsmiNewFile1,
            this.newshortcutToolStripMenuItem,
            this.tssLine5,
            this.tsmiPrivilege1,
            this.tsmiProperties1});
            this.cmsMain.Name = "contextMenuStrip1";
            this.cmsMain.ShowImageMargin = false;
            this.cmsMain.Size = new System.Drawing.Size(194, 308);
            this.cmsMain.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMain_Opening);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(193, 22);
            this.tsmiOpen.Text = "Otwórz";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiView1
            // 
            this.tsmiView1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBigIcon1,
            this.tsmiSmallIcon1,
            this.tsmiList1,
            this.tsmiDetailedInfo1});
            this.tsmiView1.Name = "tsmiView1";
            this.tsmiView1.Size = new System.Drawing.Size(193, 22);
            this.tsmiView1.Text = "Widok";
            // 
            // tsmiBigIcon1
            // 
            this.tsmiBigIcon1.Name = "tsmiBigIcon1";
            this.tsmiBigIcon1.Size = new System.Drawing.Size(132, 22);
            this.tsmiBigIcon1.Text = "Duże ikony";
            this.tsmiBigIcon1.Click += new System.EventHandler(this.tsmiBigIcon_Click);
            // 
            // tsmiSmallIcon1
            // 
            this.tsmiSmallIcon1.Name = "tsmiSmallIcon1";
            this.tsmiSmallIcon1.Size = new System.Drawing.Size(132, 22);
            this.tsmiSmallIcon1.Text = "Małe ikony";
            this.tsmiSmallIcon1.Click += new System.EventHandler(this.tsmiSmallIcon_Click);
            // 
            // tsmiList1
            // 
            this.tsmiList1.Name = "tsmiList1";
            this.tsmiList1.Size = new System.Drawing.Size(132, 22);
            this.tsmiList1.Text = "Lista";
            this.tsmiList1.Click += new System.EventHandler(this.tsmiList_Click);
            // 
            // tsmiDetailedInfo1
            // 
            this.tsmiDetailedInfo1.Name = "tsmiDetailedInfo1";
            this.tsmiDetailedInfo1.Size = new System.Drawing.Size(132, 22);
            this.tsmiDetailedInfo1.Text = "Detale";
            this.tsmiDetailedInfo1.Click += new System.EventHandler(this.tsmiDetailedInfo_Click);
            // 
            // tsmiRefresh1
            // 
            this.tsmiRefresh1.Name = "tsmiRefresh1";
            this.tsmiRefresh1.Size = new System.Drawing.Size(193, 22);
            this.tsmiRefresh1.Text = "Odśwież";
            this.tsmiRefresh1.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // tssLine3
            // 
            this.tssLine3.Name = "tssLine3";
            this.tssLine3.Size = new System.Drawing.Size(190, 6);
            // 
            // tsmiCopy1
            // 
            this.tsmiCopy1.Name = "tsmiCopy1";
            this.tsmiCopy1.Size = new System.Drawing.Size(193, 22);
            this.tsmiCopy1.Text = "Kopiuj";
            this.tsmiCopy1.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste1
            // 
            this.tsmiPaste1.Name = "tsmiPaste1";
            this.tsmiPaste1.Size = new System.Drawing.Size(193, 22);
            this.tsmiPaste1.Text = "Wklej";
            this.tsmiPaste1.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiCut1
            // 
            this.tsmiCut1.Name = "tsmiCut1";
            this.tsmiCut1.Size = new System.Drawing.Size(193, 22);
            this.tsmiCut1.Text = "Wytnij";
            this.tsmiCut1.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiDelete1
            // 
            this.tsmiDelete1.Name = "tsmiDelete1";
            this.tsmiDelete1.Size = new System.Drawing.Size(193, 22);
            this.tsmiDelete1.Text = "Usuń";
            this.tsmiDelete1.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiRename
            // 
            this.tsmiRename.Name = "tsmiRename";
            this.tsmiRename.Size = new System.Drawing.Size(193, 22);
            this.tsmiRename.Text = "Zmień nazwę";
            this.tsmiRename.Click += new System.EventHandler(this.tsmiRename_Click);
            // 
            // tssLine4
            // 
            this.tssLine4.Name = "tssLine4";
            this.tssLine4.Size = new System.Drawing.Size(190, 6);
            // 
            // tsmiNewFolder1
            // 
            this.tsmiNewFolder1.Name = "tsmiNewFolder1";
            this.tsmiNewFolder1.Size = new System.Drawing.Size(193, 22);
            this.tsmiNewFolder1.Text = "Nowy folder";
            this.tsmiNewFolder1.Click += new System.EventHandler(this.tsmiNewFolder_Click);
            // 
            // tsmiNewFile1
            // 
            this.tsmiNewFile1.Name = "tsmiNewFile1";
            this.tsmiNewFile1.Size = new System.Drawing.Size(193, 22);
            this.tsmiNewFile1.Text = "Nowy plik";
            this.tsmiNewFile1.Click += new System.EventHandler(this.tsmiNewFile_Click);
            // 
            // newshortcutToolStripMenuItem
            // 
            this.newshortcutToolStripMenuItem.Name = "newshortcutToolStripMenuItem";
            this.newshortcutToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newshortcutToolStripMenuItem.Text = "Utwórz skrót";
            this.newshortcutToolStripMenuItem.Click += new System.EventHandler(this.newshortcutToolStripMenuItem_Click);
            // 
            // tssLine5
            // 
            this.tssLine5.Name = "tssLine5";
            this.tssLine5.Size = new System.Drawing.Size(190, 6);
            // 
            // tsmiPrivilege1
            // 
            this.tsmiPrivilege1.Name = "tsmiPrivilege1";
            this.tsmiPrivilege1.Size = new System.Drawing.Size(193, 22);
            this.tsmiPrivilege1.Text = "Zarządzanie uprawnieniami";
            this.tsmiPrivilege1.Click += new System.EventHandler(this.tsmiPrivilege_Click);
            // 
            // tsmiProperties1
            // 
            this.tsmiProperties1.Name = "tsmiProperties1";
            this.tsmiProperties1.Size = new System.Drawing.Size(193, 22);
            this.tsmiProperties1.Text = "Właściwości";
            this.tsmiProperties1.Click += new System.EventHandler(this.tsmiProperties_Click);
            // 
            // ilstIcons
            // 
            this.ilstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstIcons.ImageStream")));
            this.ilstIcons.TransparentColor = System.Drawing.SystemColors.Control;
            this.ilstIcons.Images.SetKeyName(0, "disk.png");
            this.ilstIcons.Images.SetKeyName(1, "CD_ROM.png");
            this.ilstIcons.Images.SetKeyName(2, "u_pan.png");
            this.ilstIcons.Images.SetKeyName(3, "folder.png");
            this.ilstIcons.Images.SetKeyName(4, "recent.png");
            // 
            // ssFooter
            // 
            this.ssFooter.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.ssFooter.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ssFooter.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ssFooter.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.ssFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblFilesNum});
            this.ssFooter.Location = new System.Drawing.Point(0, 539);
            this.ssFooter.Name = "ssFooter";
            this.ssFooter.Size = new System.Drawing.Size(984, 22);
            this.ssFooter.TabIndex = 2;
            // 
            // tsslblFilesNum
            // 
            this.tsslblFilesNum.Name = "tsslblFilesNum";
            this.tsslblFilesNum.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvwDirectory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwFiles);
            this.splitContainer1.Size = new System.Drawing.Size(984, 487);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tvwDirectory
            // 
            this.tvwDirectory.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tvwDirectory.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tvwDirectory.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tvwDirectory.DataBindings.Add(new System.Windows.Forms.Binding("LineColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tvwDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwDirectory.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwDirectory.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tvwDirectory.ImageIndex = 0;
            this.tvwDirectory.ImageList = this.ilstIcons;
            this.tvwDirectory.LineColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tvwDirectory.Location = new System.Drawing.Point(0, 0);
            this.tvwDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvwDirectory.Name = "tvwDirectory";
            this.tvwDirectory.SelectedImageIndex = 0;
            this.tvwDirectory.Size = new System.Drawing.Size(230, 487);
            this.tvwDirectory.TabIndex = 0;
            this.tvwDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwDirectory_BeforeExpand);
            this.tvwDirectory.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvwDirectory_AfterExpand);
            this.tvwDirectory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDirectory_AfterSelect);
            // 
            // lvwFiles
            // 
            this.lvwFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwFiles.AllowDrop = true;
            this.lvwFiles.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwFiles.ContextMenuStrip = this.cmsMain;
            this.lvwFiles.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lvwFiles.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFiles.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.HoverSelection = true;
            this.lvwFiles.LabelEdit = true;
            this.lvwFiles.Location = new System.Drawing.Point(0, 0);
            this.lvwFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(749, 487);
            this.lvwFiles.SmallImageList = this.ilstIcons;
            this.lvwFiles.TabIndex = 0;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwFiles_AfterLabelEdit);
            this.lvwFiles.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwFiles_ColumnWidthChanging);
            this.lvwFiles.ItemActivate += new System.EventHandler(this.lvwFiles_ItemActivate);
            this.lvwFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwFiles_KeyDown);
            this.lvwFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwFiles_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rodzaj";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rozmiar";
            this.columnHeader4.Width = 140;
            // 
            // timerP
            // 
            this.timerP.Interval = 500;
            this.timerP.Tick += new System.EventHandler(this.timerP_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ssFooter);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przeglądarka plików";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BackColorChanged += new System.EventHandler(this.MainForm_BackColorChanged);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.cmsMain.ResumeLayout(false);
            this.ssFooter.ResumeLayout(false);
            this.ssFooter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiProperties;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbtnBack;
        private System.Windows.Forms.ToolStripButton tsbtnAdvance;
        private System.Windows.Forms.ToolStripButton tsbtnUpArrow;
        private System.Windows.Forms.ToolStripSeparator tssLine1;
        private System.Windows.Forms.ToolStripSeparator tssLine2;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiView1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBigIcon1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmallIcon1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetailedInfo1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator tssLine3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRename;
        private System.Windows.Forms.ToolStripSeparator tssLine4;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewFolder1;
        private System.Windows.Forms.ToolStripSeparator tssLine5;
        private System.Windows.Forms.ToolStripMenuItem tsmiProperties1;
        private System.Windows.Forms.ImageList ilstIcons;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolbar;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusbar;
        private System.Windows.Forms.ToolStripSeparator tssLine6;
        private System.Windows.Forms.ToolStripMenuItem tsmiBigIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetailedInfo;
        private System.Windows.Forms.ToolStripSeparator tssLine7;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh1;
        private System.Windows.Forms.StatusStrip ssFooter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvwDirectory;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ToolStripStatusLabel tsslblFilesNum;
        private System.Windows.Forms.ToolStripMenuItem tsmiList;
        private System.Windows.Forms.ToolStripMenuItem tsmiList1;
        private System.Windows.Forms.ToolStripComboBox tscboAddress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcessThread;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonitor;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrivilege1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewFile1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrivilege;
        private System.Windows.Forms.ToolStripComboBox tscboSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opcjeProgramuToolStripMenuItem;
        private System.Windows.Forms.Timer timerP;
        private System.Windows.Forms.ToolStripMenuItem newshortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}