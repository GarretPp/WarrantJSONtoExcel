
namespace WarrantJSONtoExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.lblFileLocationVariable = new System.Windows.Forms.Label();
            this.dialogWarrantDataFile = new System.Windows.Forms.OpenFileDialog();
            this.lblExportFolderVariable = new System.Windows.Forms.Label();
            this.lblExportFolder = new System.Windows.Forms.Label();
            this.btnSelectExportFolder = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnProcessData = new System.Windows.Forms.Button();
            this.dialogSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbIsOpenFolderWhenDone = new System.Windows.Forms.CheckBox();
            this.cbIsOpenFileWhenDone = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.tabJSONData = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectJSONOutput = new System.Windows.Forms.Button();
            this.btnSaveJSONData = new System.Windows.Forms.Button();
            this.pBarJSONSave = new System.Windows.Forms.ProgressBar();
            this.cbIsCopyJSONtoFile = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbJSONData = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJSONDataTitle = new System.Windows.Forms.Label();
            this.lblJSONDataDesc = new System.Windows.Forms.Label();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCreatedByLnk = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbHelp = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerProcessData = new System.ComponentModel.BackgroundWorker();
            this.dialogSaveJSONFileOutput = new System.Windows.Forms.SaveFileDialog();
            this.backgroundSaveJSONData = new System.ComponentModel.BackgroundWorker();
            this.mainMenuStrip.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabJSONData.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.btnSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(3, 2);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(276, 55);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select Data";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFileLocation.AutoSize = true;
            this.lblFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLocation.Location = new System.Drawing.Point(63, 59);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(155, 20);
            this.lblFileLocation.TabIndex = 1;
            this.lblFileLocation.Text = "JSON File Location";
            // 
            // lblFileLocationVariable
            // 
            this.lblFileLocationVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFileLocationVariable.AutoEllipsis = true;
            this.lblFileLocationVariable.AutoSize = true;
            this.lblFileLocationVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLocationVariable.Location = new System.Drawing.Point(88, 79);
            this.lblFileLocationVariable.Name = "lblFileLocationVariable";
            this.lblFileLocationVariable.Size = new System.Drawing.Size(105, 67);
            this.lblFileLocationVariable.TabIndex = 2;
            this.lblFileLocationVariable.Text = "DRIVE LOCATION";
            // 
            // dialogWarrantDataFile
            // 
            this.dialogWarrantDataFile.FileName = "warrantDataFile";
            this.dialogWarrantDataFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dialogWarrantDataFile_FileOk);
            // 
            // lblExportFolderVariable
            // 
            this.lblExportFolderVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblExportFolderVariable.AutoEllipsis = true;
            this.lblExportFolderVariable.AutoSize = true;
            this.lblExportFolderVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportFolderVariable.Location = new System.Drawing.Point(364, 79);
            this.lblExportFolderVariable.Name = "lblExportFolderVariable";
            this.lblExportFolderVariable.Size = new System.Drawing.Size(118, 67);
            this.lblExportFolderVariable.TabIndex = 8;
            this.lblExportFolderVariable.Text = "EXPORT LOCATION";
            // 
            // lblExportFolder
            // 
            this.lblExportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblExportFolder.AutoSize = true;
            this.lblExportFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportFolder.Location = new System.Drawing.Point(350, 59);
            this.lblExportFolder.Name = "lblExportFolder";
            this.lblExportFolder.Size = new System.Drawing.Size(147, 20);
            this.lblExportFolder.TabIndex = 7;
            this.lblExportFolder.Text = "Save File Location";
            this.lblExportFolder.Click += new System.EventHandler(this.lblExportFolder_Click);
            // 
            // btnSelectExportFolder
            // 
            this.btnSelectExportFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.btnSelectExportFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectExportFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.btnSelectExportFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectExportFolder.Font = new System.Drawing.Font("Modern No. 20", 16.2F);
            this.btnSelectExportFolder.Location = new System.Drawing.Point(285, 2);
            this.btnSelectExportFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectExportFolder.Name = "btnSelectExportFolder";
            this.btnSelectExportFolder.Size = new System.Drawing.Size(277, 55);
            this.btnSelectExportFolder.TabIndex = 6;
            this.btnSelectExportFolder.Text = "Select Save";
            this.btnSelectExportFolder.UseVisualStyleBackColor = false;
            this.btnSelectExportFolder.Click += new System.EventHandler(this.btnSelectExportFolder_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(3, 2);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(409, 31);
            this.lblMainTitle.TabIndex = 9;
            this.lblMainTitle.Text = "Warrant JSON Data Converter";
            // 
            // btnProcessData
            // 
            this.btnProcessData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.btnProcessData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcessData.Enabled = false;
            this.btnProcessData.FlatAppearance.BorderSize = 0;
            this.btnProcessData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.btnProcessData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessData.Font = new System.Drawing.Font("Modern No. 20", 16.2F);
            this.btnProcessData.Location = new System.Drawing.Point(285, 2);
            this.btnProcessData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcessData.Name = "btnProcessData";
            this.tableLayoutPanel2.SetRowSpan(this.btnProcessData, 2);
            this.btnProcessData.Size = new System.Drawing.Size(277, 126);
            this.btnProcessData.TabIndex = 11;
            this.btnProcessData.Text = "PROCESS DATA";
            this.btnProcessData.UseVisualStyleBackColor = false;
            this.btnProcessData.Click += new System.EventHandler(this.btnProcessData_Click);
            // 
            // dialogSaveFile
            // 
            this.dialogSaveFile.DefaultExt = "xlsx";
            this.dialogSaveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dialogSaveFile_FileOk);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(579, 28);
            this.mainMenuStrip.TabIndex = 12;
            this.mainMenuStrip.Text = "menuStrip1";
            this.mainMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabProcess);
            this.tabController.Controls.Add(this.tabJSONData);
            this.tabController.Controls.Add(this.tabHelp);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.HotTrack = true;
            this.tabController.Location = new System.Drawing.Point(0, 28);
            this.tabController.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(579, 443);
            this.tabController.TabIndex = 13;
            // 
            // tabProcess
            // 
            this.tabProcess.Controls.Add(this.tableLayoutPanel2);
            this.tabProcess.Controls.Add(this.tableLayoutPanel1);
            this.tabProcess.Controls.Add(this.pBar);
            this.tabProcess.Controls.Add(this.lblMainTitle);
            this.tabProcess.Location = new System.Drawing.Point(4, 25);
            this.tabProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProcess.Size = new System.Drawing.Size(571, 414);
            this.tabProcess.TabIndex = 0;
            this.tabProcess.Text = "Process";
            this.tabProcess.UseVisualStyleBackColor = true;
            this.tabProcess.Click += new System.EventHandler(this.tabProcess_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbIsOpenFolderWhenDone, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbIsOpenFileWhenDone, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnProcessData, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 179);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(565, 130);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // cbIsOpenFolderWhenDone
            // 
            this.cbIsOpenFolderWhenDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbIsOpenFolderWhenDone.AutoSize = true;
            this.cbIsOpenFolderWhenDone.Location = new System.Drawing.Point(47, 2);
            this.cbIsOpenFolderWhenDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIsOpenFolderWhenDone.Name = "cbIsOpenFolderWhenDone";
            this.cbIsOpenFolderWhenDone.Size = new System.Drawing.Size(188, 61);
            this.cbIsOpenFolderWhenDone.TabIndex = 15;
            this.cbIsOpenFolderWhenDone.Text = "Open Folder When Done";
            this.cbIsOpenFolderWhenDone.UseVisualStyleBackColor = true;
            // 
            // cbIsOpenFileWhenDone
            // 
            this.cbIsOpenFileWhenDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbIsOpenFileWhenDone.AutoSize = true;
            this.cbIsOpenFileWhenDone.Location = new System.Drawing.Point(56, 67);
            this.cbIsOpenFileWhenDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIsOpenFileWhenDone.Name = "cbIsOpenFileWhenDone";
            this.cbIsOpenFileWhenDone.Size = new System.Drawing.Size(170, 61);
            this.cbIsOpenFileWhenDone.TabIndex = 14;
            this.cbIsOpenFileWhenDone.Text = "Open File When Done";
            this.cbIsOpenFileWhenDone.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSelectFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFileLocation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFileLocationVariable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectExportFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblExportFolder, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblExportFolderVariable, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 146);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // pBar
            // 
            this.pBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar.Location = new System.Drawing.Point(3, 369);
            this.pBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(565, 43);
            this.pBar.TabIndex = 12;
            // 
            // tabJSONData
            // 
            this.tabJSONData.Controls.Add(this.flowLayoutPanel1);
            this.tabJSONData.Controls.Add(this.panel2);
            this.tabJSONData.Controls.Add(this.panel1);
            this.tabJSONData.Location = new System.Drawing.Point(4, 25);
            this.tabJSONData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabJSONData.Name = "tabJSONData";
            this.tabJSONData.Size = new System.Drawing.Size(571, 413);
            this.tabJSONData.TabIndex = 2;
            this.tabJSONData.Text = "JSON Data";
            this.tabJSONData.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSelectJSONOutput);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveJSONData);
            this.flowLayoutPanel1.Controls.Add(this.pBarJSONSave);
            this.flowLayoutPanel1.Controls.Add(this.cbIsCopyJSONtoFile);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 367);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(571, 46);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnSelectJSONOutput
            // 
            this.btnSelectJSONOutput.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectJSONOutput.Location = new System.Drawing.Point(3, 2);
            this.btnSelectJSONOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectJSONOutput.Name = "btnSelectJSONOutput";
            this.btnSelectJSONOutput.Size = new System.Drawing.Size(75, 28);
            this.btnSelectJSONOutput.TabIndex = 4;
            this.btnSelectJSONOutput.Text = "Select";
            this.btnSelectJSONOutput.UseVisualStyleBackColor = true;
            this.btnSelectJSONOutput.Visible = false;
            this.btnSelectJSONOutput.Click += new System.EventHandler(this.btnSelectJSONOutput_Click);
            // 
            // btnSaveJSONData
            // 
            this.btnSaveJSONData.Enabled = false;
            this.btnSaveJSONData.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.btnSaveJSONData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveJSONData.Location = new System.Drawing.Point(84, 2);
            this.btnSaveJSONData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveJSONData.Name = "btnSaveJSONData";
            this.btnSaveJSONData.Size = new System.Drawing.Size(75, 28);
            this.btnSaveJSONData.TabIndex = 5;
            this.btnSaveJSONData.Text = "Save";
            this.btnSaveJSONData.UseVisualStyleBackColor = true;
            this.btnSaveJSONData.Visible = false;
            this.btnSaveJSONData.Click += new System.EventHandler(this.btnSaveJSONData_Click);
            // 
            // pBarJSONSave
            // 
            this.pBarJSONSave.Location = new System.Drawing.Point(165, 2);
            this.pBarJSONSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBarJSONSave.MarqueeAnimationSpeed = 30;
            this.pBarJSONSave.Name = "pBarJSONSave";
            this.pBarJSONSave.Size = new System.Drawing.Size(245, 28);
            this.pBarJSONSave.TabIndex = 6;
            this.pBarJSONSave.Visible = false;
            // 
            // cbIsCopyJSONtoFile
            // 
            this.cbIsCopyJSONtoFile.AutoSize = true;
            this.cbIsCopyJSONtoFile.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbIsCopyJSONtoFile.Location = new System.Drawing.Point(416, 2);
            this.cbIsCopyJSONtoFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIsCopyJSONtoFile.Name = "cbIsCopyJSONtoFile";
            this.cbIsCopyJSONtoFile.Size = new System.Drawing.Size(145, 21);
            this.cbIsCopyJSONtoFile.TabIndex = 3;
            this.cbIsCopyJSONtoFile.Text = "Copy JSON to File";
            this.cbIsCopyJSONtoFile.UseVisualStyleBackColor = true;
            this.cbIsCopyJSONtoFile.CheckedChanged += new System.EventHandler(this.cbIsCopyJSONtoFile_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbJSONData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 297);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbJSONData
            // 
            this.tbJSONData.AcceptsReturn = true;
            this.tbJSONData.AcceptsTab = true;
            this.tbJSONData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbJSONData.Location = new System.Drawing.Point(0, 0);
            this.tbJSONData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbJSONData.MaxLength = 100000000;
            this.tbJSONData.Multiline = true;
            this.tbJSONData.Name = "tbJSONData";
            this.tbJSONData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJSONData.Size = new System.Drawing.Size(571, 297);
            this.tbJSONData.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblJSONDataTitle);
            this.panel1.Controls.Add(this.lblJSONDataDesc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 60);
            this.panel1.TabIndex = 7;
            // 
            // lblJSONDataTitle
            // 
            this.lblJSONDataTitle.AutoSize = true;
            this.lblJSONDataTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJSONDataTitle.Location = new System.Drawing.Point(0, 0);
            this.lblJSONDataTitle.Name = "lblJSONDataTitle";
            this.lblJSONDataTitle.Size = new System.Drawing.Size(269, 25);
            this.lblJSONDataTitle.TabIndex = 1;
            this.lblJSONDataTitle.Text = "JSON Data (Paste/From File)";
            // 
            // lblJSONDataDesc
            // 
            this.lblJSONDataDesc.AutoSize = true;
            this.lblJSONDataDesc.Location = new System.Drawing.Point(3, 25);
            this.lblJSONDataDesc.Name = "lblJSONDataDesc";
            this.lblJSONDataDesc.Size = new System.Drawing.Size(343, 17);
            this.lblJSONDataDesc.TabIndex = 2;
            this.lblJSONDataDesc.Text = "Paste JSON data here directly or load it in from a file.";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.panel6);
            this.tabHelp.Controls.Add(this.panel5);
            this.tabHelp.Controls.Add(this.panel4);
            this.tabHelp.Controls.Add(this.panel3);
            this.tabHelp.Location = new System.Drawing.Point(4, 25);
            this.tabHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHelp.Size = new System.Drawing.Size(571, 413);
            this.tabHelp.TabIndex = 1;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.lblCreatedByLnk);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 394);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(565, 17);
            this.panel6.TabIndex = 6;
            // 
            // lblCreatedByLnk
            // 
            this.lblCreatedByLnk.AutoSize = true;
            this.lblCreatedByLnk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreatedByLnk.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblCreatedByLnk.Location = new System.Drawing.Point(0, 0);
            this.lblCreatedByLnk.Name = "lblCreatedByLnk";
            this.lblCreatedByLnk.Size = new System.Drawing.Size(195, 17);
            this.lblCreatedByLnk.TabIndex = 2;
            this.lblCreatedByLnk.TabStop = true;
            this.lblCreatedByLnk.Text = "Created by Garret Peirzchajlo";
            this.lblCreatedByLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreatedByLnk_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbHelp);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 27);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(565, 300);
            this.panel5.TabIndex = 5;
            // 
            // tbHelp
            // 
            this.tbHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHelp.Location = new System.Drawing.Point(0, 0);
            this.tbHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHelp.Multiline = true;
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.ReadOnly = true;
            this.tbHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHelp.Size = new System.Drawing.Size(565, 300);
            this.tbHelp.TabIndex = 0;
            this.tbHelp.Text = resources.GetString("tbHelp.Text");
            this.tbHelp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 27);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 0);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 25);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instructions";
            // 
            // backgroundWorkerProcessData
            // 
            this.backgroundWorkerProcessData.WorkerReportsProgress = true;
            this.backgroundWorkerProcessData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerProcessData_DoWork);
            this.backgroundWorkerProcessData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerProcessData_ProgressChanged);
            this.backgroundWorkerProcessData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerProcessData_RunWorkerCompleted);
            // 
            // dialogSaveJSONFileOutput
            // 
            this.dialogSaveJSONFileOutput.DefaultExt = "json";
            // 
            // backgroundSaveJSONData
            // 
            this.backgroundSaveJSONData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSaveJSONData_DoWork);
            this.backgroundSaveJSONData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSaveJSONData_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(579, 471);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Warrant JSON Processor";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.tabProcess.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabJSONData.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabHelp.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.Label lblFileLocationVariable;
        private System.Windows.Forms.OpenFileDialog dialogWarrantDataFile;
        private System.Windows.Forms.Label lblExportFolderVariable;
        private System.Windows.Forms.Label lblExportFolder;
        private System.Windows.Forms.Button btnSelectExportFolder;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnProcessData;
        private System.Windows.Forms.SaveFileDialog dialogSaveFile;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabProcess;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHelp;
        private System.Windows.Forms.ProgressBar pBar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProcessData;
        private System.Windows.Forms.TabPage tabJSONData;
        private System.Windows.Forms.Label lblJSONDataDesc;
        private System.Windows.Forms.Label lblJSONDataTitle;
        private System.Windows.Forms.TextBox tbJSONData;
        private System.Windows.Forms.Button btnSelectJSONOutput;
        private System.Windows.Forms.CheckBox cbIsCopyJSONtoFile;
        private System.Windows.Forms.SaveFileDialog dialogSaveJSONFileOutput;
        private System.ComponentModel.BackgroundWorker backgroundSaveJSONData;
        private System.Windows.Forms.Button btnSaveJSONData;
        private System.Windows.Forms.ProgressBar pBarJSONSave;
        private System.Windows.Forms.LinkLabel lblCreatedByLnk;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbIsOpenFolderWhenDone;
        private System.Windows.Forms.CheckBox cbIsOpenFileWhenDone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

