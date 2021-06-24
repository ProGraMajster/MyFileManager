namespace MyFileManager
{
    partial class ProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessForm));
            this.lvwProcess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsProcess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThread = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinish = new System.Windows.Forms.ToolStripMenuItem();
            this.ilstIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCurProcessNum = new System.Windows.Forms.Label();
            this.txtCurProcessNum = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmsProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwProcess
            // 
            this.lvwProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwProcess.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.lvwProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwProcess.ContextMenuStrip = this.cmsProcess;
            this.lvwProcess.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lvwProcess.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lvwProcess.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwProcess.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.lvwProcess.FullRowSelect = true;
            this.lvwProcess.HideSelection = false;
            this.lvwProcess.LargeImageList = this.ilstIcons;
            this.lvwProcess.Location = new System.Drawing.Point(3, 0);
            this.lvwProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvwProcess.Name = "lvwProcess";
            this.lvwProcess.Size = new System.Drawing.Size(924, 579);
            this.lvwProcess.SmallImageList = this.ilstIcons;
            this.lvwProcess.TabIndex = 0;
            this.lvwProcess.UseCompatibleStateImageBehavior = false;
            this.lvwProcess.View = System.Windows.Forms.View.Details;
            this.lvwProcess.SelectedIndexChanged += new System.EventHandler(this.lvwProcess_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa procesu";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Identyfikator procesu";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dedykowana wielkość pamięci";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rozmiar pamięci wirtualnej";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Czas rozpoczęcia";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Priorytet podstawowy";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ścieżka";
            this.columnHeader7.Width = 250;
            // 
            // cmsProcess
            // 
            this.cmsProcess.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.cmsProcess.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmsProcess.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmsProcess.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.cmsProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThread,
            this.tsmiFinish});
            this.cmsProcess.Name = "cmsProcess";
            this.cmsProcess.ShowImageMargin = false;
            this.cmsProcess.Size = new System.Drawing.Size(287, 48);
            // 
            // tsmiThread
            // 
            this.tsmiThread.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.tsmiThread.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.tsmiThread.Name = "tsmiThread";
            this.tsmiThread.Size = new System.Drawing.Size(286, 22);
            this.tsmiThread.Text = "Zarządzaj wątkami zawartymi w tym procesie";
            this.tsmiThread.Click += new System.EventHandler(this.tsmiThread_Click);
            // 
            // tsmiFinish
            // 
            this.tsmiFinish.Name = "tsmiFinish";
            this.tsmiFinish.Size = new System.Drawing.Size(286, 22);
            this.tsmiFinish.Text = "Zakończ ten proces";
            this.tsmiFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // ilstIcons
            // 
            this.ilstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstIcons.ImageStream")));
            this.ilstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstIcons.Images.SetKeyName(0, "process.png");
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.btnFinish.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnFinish.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnFinish.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFinish.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.btnFinish.Location = new System.Drawing.Point(800, 590);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(115, 33);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Zakończ proces";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.btnRefresh.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnRefresh.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.btnRefresh.Location = new System.Drawing.Point(700, 590);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 33);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCurProcessNum
            // 
            this.lblCurProcessNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurProcessNum.AutoSize = true;
            this.lblCurProcessNum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurProcessNum.Location = new System.Drawing.Point(15, 602);
            this.lblCurProcessNum.Name = "lblCurProcessNum";
            this.lblCurProcessNum.Size = new System.Drawing.Size(295, 17);
            this.lblCurProcessNum.TabIndex = 3;
            this.lblCurProcessNum.Text = "Aktualna liczba procesów (w tym procesy ukryte):";
            // 
            // txtCurProcessNum
            // 
            this.txtCurProcessNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCurProcessNum.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurProcessNum.Location = new System.Drawing.Point(320, 600);
            this.txtCurProcessNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurProcessNum.Name = "txtCurProcessNum";
            this.txtCurProcessNum.ReadOnly = true;
            this.txtCurProcessNum.Size = new System.Drawing.Size(53, 22);
            this.txtCurProcessNum.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 6000;
            this.timer.Tick += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::MyFileManager.Properties.Settings.Default.DefaultBackColor;
            this.ClientSize = new System.Drawing.Size(933, 637);
            this.Controls.Add(this.txtCurProcessNum);
            this.Controls.Add(this.lblCurProcessNum);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lvwProcess);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MyFileManager.Properties.Settings.Default, "DefaultBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MyFileManager.Properties.Settings.Default, "DefaultForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = global::MyFileManager.Properties.Settings.Default.DefaultForeColor;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie procesem";
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            this.cmsProcess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwProcess;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCurProcessNum;
        private System.Windows.Forms.TextBox txtCurProcessNum;
        private System.Windows.Forms.ImageList ilstIcons;
        private System.Windows.Forms.ContextMenuStrip cmsProcess;
        private System.Windows.Forms.ToolStripMenuItem tsmiThread;
        private System.Windows.Forms.ToolStripMenuItem tsmiFinish;
        private System.Windows.Forms.Timer timer;
    }
}