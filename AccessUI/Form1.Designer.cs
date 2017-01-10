namespace AccessUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSql = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSqls = new System.Windows.Forms.TextBox();
            this.txtSqlYS = new System.Windows.Forms.TextBox();
            this.txtTubeType = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnUpdateBySqls = new System.Windows.Forms.Button();
            this.btnCreatSqls = new System.Windows.Forms.Button();
            this.btnShowAllTubeType = new System.Windows.Forms.Button();
            this.btnOpenDBFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagetool = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGXSJ = new System.Windows.Forms.Button();
            this.btnWellDepth = new System.Windows.Forms.Button();
            this.gpbBatchUpdate = new System.Windows.Forms.GroupBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnBatchUpdate = new System.Windows.Forms.Button();
            this.chkZX = new System.Windows.Forms.CheckBox();
            this.chkGXLX = new System.Windows.Forms.CheckBox();
            this.chkCLY = new System.Windows.Forms.CheckBox();
            this.chkRoad = new System.Windows.Forms.CheckBox();
            this.chkTCFS = new System.Windows.Forms.CheckBox();
            this.chkYSBM = new System.Windows.Forms.CheckBox();
            this.chkKCDW = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkQuanShu = new System.Windows.Forms.CheckBox();
            this.txtGroupNumber = new System.Windows.Forms.TextBox();
            this.btnAddGroupNumber = new System.Windows.Forms.Button();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFileName2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabpageSelect = new System.Windows.Forms.TabPage();
            this.btnUpdateSelect = new System.Windows.Forms.Button();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开SQL文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开Error文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空Error文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateGroupNumber = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageSql.SuspendLayout();
            this.tabPagetool.SuspendLayout();
            this.gpbBatchUpdate.SuspendLayout();
            this.tabpageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSql);
            this.tabControl1.Controls.Add(this.tabPagetool);
            this.tabControl1.Controls.Add(this.tabpageSelect);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSql
            // 
            this.tabPageSql.Controls.Add(this.btnSelect);
            this.tabPageSql.Controls.Add(this.txtSqls);
            this.tabPageSql.Controls.Add(this.txtSqlYS);
            this.tabPageSql.Controls.Add(this.txtTubeType);
            this.tabPageSql.Controls.Add(this.btnCopy);
            this.tabPageSql.Controls.Add(this.btnUpdateBySqls);
            this.tabPageSql.Controls.Add(this.btnCreatSqls);
            this.tabPageSql.Controls.Add(this.btnShowAllTubeType);
            this.tabPageSql.Controls.Add(this.btnOpenDBFile);
            this.tabPageSql.Controls.Add(this.lblFileName);
            this.tabPageSql.Controls.Add(this.label4);
            this.tabPageSql.Controls.Add(this.label3);
            this.tabPageSql.Controls.Add(this.label2);
            this.tabPageSql.Controls.Add(this.label1);
            this.tabPageSql.Location = new System.Drawing.Point(4, 22);
            this.tabPageSql.Name = "tabPageSql";
            this.tabPageSql.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSql.Size = new System.Drawing.Size(1174, 408);
            this.tabPageSql.TabIndex = 0;
            this.tabPageSql.Text = "Sql";
            this.tabPageSql.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelect.Location = new System.Drawing.Point(238, 377);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSqls
            // 
            this.txtSqls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqls.Location = new System.Drawing.Point(76, 105);
            this.txtSqls.Multiline = true;
            this.txtSqls.Name = "txtSqls";
            this.txtSqls.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSqls.Size = new System.Drawing.Size(1003, 253);
            this.txtSqls.TabIndex = 2;
            // 
            // txtSqlYS
            // 
            this.txtSqlYS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlYS.Location = new System.Drawing.Point(76, 75);
            this.txtSqlYS.Name = "txtSqlYS";
            this.txtSqlYS.Size = new System.Drawing.Size(1003, 21);
            this.txtSqlYS.TabIndex = 2;
            // 
            // txtTubeType
            // 
            this.txtTubeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTubeType.Location = new System.Drawing.Point(76, 45);
            this.txtTubeType.Name = "txtTubeType";
            this.txtTubeType.Size = new System.Drawing.Size(1003, 21);
            this.txtTubeType.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(1004, 377);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnUpdateBySqls
            // 
            this.btnUpdateBySqls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateBySqls.Location = new System.Drawing.Point(157, 377);
            this.btnUpdateBySqls.Name = "btnUpdateBySqls";
            this.btnUpdateBySqls.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBySqls.TabIndex = 1;
            this.btnUpdateBySqls.Text = "Update";
            this.btnUpdateBySqls.UseVisualStyleBackColor = true;
            this.btnUpdateBySqls.Click += new System.EventHandler(this.btnUpdateBySqls_Click);
            // 
            // btnCreatSqls
            // 
            this.btnCreatSqls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreatSqls.Location = new System.Drawing.Point(76, 377);
            this.btnCreatSqls.Name = "btnCreatSqls";
            this.btnCreatSqls.Size = new System.Drawing.Size(75, 23);
            this.btnCreatSqls.TabIndex = 1;
            this.btnCreatSqls.Text = "Creat";
            this.btnCreatSqls.UseVisualStyleBackColor = true;
            this.btnCreatSqls.Click += new System.EventHandler(this.btnCreatSqls_Click);
            // 
            // btnShowAllTubeType
            // 
            this.btnShowAllTubeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllTubeType.Location = new System.Drawing.Point(1091, 45);
            this.btnShowAllTubeType.Name = "btnShowAllTubeType";
            this.btnShowAllTubeType.Size = new System.Drawing.Size(75, 23);
            this.btnShowAllTubeType.TabIndex = 1;
            this.btnShowAllTubeType.Text = "全管类";
            this.btnShowAllTubeType.UseVisualStyleBackColor = true;
            this.btnShowAllTubeType.Click += new System.EventHandler(this.btnShowAllTubeType_Click);
            // 
            // btnOpenDBFile
            // 
            this.btnOpenDBFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDBFile.Location = new System.Drawing.Point(1091, 13);
            this.btnOpenDBFile.Name = "btnOpenDBFile";
            this.btnOpenDBFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDBFile.TabIndex = 1;
            this.btnOpenDBFile.Text = "打开";
            this.btnOpenDBFile.UseVisualStyleBackColor = true;
            this.btnOpenDBFile.Click += new System.EventHandler(this.btnOpenDBFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(74, 24);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(23, 12);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "C:\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sqls：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "sql(ys):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "管类：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件：";
            // 
            // tabPagetool
            // 
            this.tabPagetool.Controls.Add(this.btnUpdateGroupNumber);
            this.tabPagetool.Controls.Add(this.button1);
            this.tabPagetool.Controls.Add(this.btnGXSJ);
            this.tabPagetool.Controls.Add(this.btnWellDepth);
            this.tabPagetool.Controls.Add(this.gpbBatchUpdate);
            this.tabPagetool.Controls.Add(this.txtGroupNumber);
            this.tabPagetool.Controls.Add(this.btnAddGroupNumber);
            this.tabPagetool.Controls.Add(this.btnOpenFile2);
            this.tabPagetool.Controls.Add(this.label6);
            this.tabPagetool.Controls.Add(this.lblFileName2);
            this.tabPagetool.Controls.Add(this.label5);
            this.tabPagetool.Location = new System.Drawing.Point(4, 22);
            this.tabPagetool.Name = "tabPagetool";
            this.tabPagetool.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagetool.Size = new System.Drawing.Size(1174, 408);
            this.tabPagetool.TabIndex = 1;
            this.tabPagetool.Text = "工具";
            this.tabPagetool.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "筛选组号";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGXSJ
            // 
            this.btnGXSJ.Location = new System.Drawing.Point(192, 117);
            this.btnGXSJ.Name = "btnGXSJ";
            this.btnGXSJ.Size = new System.Drawing.Size(75, 23);
            this.btnGXSJ.TabIndex = 5;
            this.btnGXSJ.Text = "GXSJ";
            this.btnGXSJ.UseVisualStyleBackColor = true;
            this.btnGXSJ.Click += new System.EventHandler(this.btnGXSJ_Click);
            // 
            // btnWellDepth
            // 
            this.btnWellDepth.Location = new System.Drawing.Point(192, 83);
            this.btnWellDepth.Name = "btnWellDepth";
            this.btnWellDepth.Size = new System.Drawing.Size(75, 23);
            this.btnWellDepth.TabIndex = 4;
            this.btnWellDepth.Text = "井底深";
            this.btnWellDepth.UseVisualStyleBackColor = true;
            this.btnWellDepth.Click += new System.EventHandler(this.btnWellDepth_Click);
            // 
            // gpbBatchUpdate
            // 
            this.gpbBatchUpdate.Controls.Add(this.lbl10);
            this.gpbBatchUpdate.Controls.Add(this.lbl9);
            this.gpbBatchUpdate.Controls.Add(this.lbl8);
            this.gpbBatchUpdate.Controls.Add(this.lbl7);
            this.gpbBatchUpdate.Controls.Add(this.lbl6);
            this.gpbBatchUpdate.Controls.Add(this.lbl5);
            this.gpbBatchUpdate.Controls.Add(this.lbl4);
            this.gpbBatchUpdate.Controls.Add(this.lbl3);
            this.gpbBatchUpdate.Controls.Add(this.lbl2);
            this.gpbBatchUpdate.Controls.Add(this.lbl1);
            this.gpbBatchUpdate.Controls.Add(this.btnBatchUpdate);
            this.gpbBatchUpdate.Controls.Add(this.chkZX);
            this.gpbBatchUpdate.Controls.Add(this.chkGXLX);
            this.gpbBatchUpdate.Controls.Add(this.chkCLY);
            this.gpbBatchUpdate.Controls.Add(this.chkRoad);
            this.gpbBatchUpdate.Controls.Add(this.chkTCFS);
            this.gpbBatchUpdate.Controls.Add(this.chkYSBM);
            this.gpbBatchUpdate.Controls.Add(this.chkKCDW);
            this.gpbBatchUpdate.Controls.Add(this.chkDelete);
            this.gpbBatchUpdate.Controls.Add(this.chkDate);
            this.gpbBatchUpdate.Controls.Add(this.chkQuanShu);
            this.gpbBatchUpdate.Location = new System.Drawing.Point(29, 83);
            this.gpbBatchUpdate.Name = "gpbBatchUpdate";
            this.gpbBatchUpdate.Size = new System.Drawing.Size(148, 273);
            this.gpbBatchUpdate.TabIndex = 3;
            this.gpbBatchUpdate.TabStop = false;
            this.gpbBatchUpdate.Text = "批量更新";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(94, 221);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(11, 12);
            this.lbl10.TabIndex = 2;
            this.lbl10.Text = " ";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(94, 199);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(11, 12);
            this.lbl9.TabIndex = 2;
            this.lbl9.Text = " ";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(94, 177);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(11, 12);
            this.lbl8.TabIndex = 2;
            this.lbl8.Text = " ";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(94, 155);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(11, 12);
            this.lbl7.TabIndex = 2;
            this.lbl7.Text = " ";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(94, 133);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(11, 12);
            this.lbl6.TabIndex = 2;
            this.lbl6.Text = " ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(94, 111);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(11, 12);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = " ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(94, 89);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(11, 12);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = " ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(94, 67);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(11, 12);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = " ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(94, 45);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(11, 12);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = " ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(94, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(11, 12);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = " ";
            // 
            // btnBatchUpdate
            // 
            this.btnBatchUpdate.Location = new System.Drawing.Point(15, 240);
            this.btnBatchUpdate.Name = "btnBatchUpdate";
            this.btnBatchUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBatchUpdate.TabIndex = 1;
            this.btnBatchUpdate.Text = "更新";
            this.btnBatchUpdate.UseVisualStyleBackColor = true;
            this.btnBatchUpdate.Click += new System.EventHandler(this.btnBatchUpdate_Click);
            // 
            // chkZX
            // 
            this.chkZX.AutoSize = true;
            this.chkZX.Checked = true;
            this.chkZX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZX.Location = new System.Drawing.Point(15, 218);
            this.chkZX.Name = "chkZX";
            this.chkZX.Size = new System.Drawing.Size(54, 16);
            this.chkZX.TabIndex = 0;
            this.chkZX.Text = "杂项a";
            this.chkZX.UseVisualStyleBackColor = true;
            // 
            // chkGXLX
            // 
            this.chkGXLX.AutoSize = true;
            this.chkGXLX.Checked = true;
            this.chkGXLX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGXLX.Location = new System.Drawing.Point(15, 196);
            this.chkGXLX.Name = "chkGXLX";
            this.chkGXLX.Size = new System.Drawing.Size(72, 16);
            this.chkGXLX.TabIndex = 0;
            this.chkGXLX.Text = "管线类型";
            this.chkGXLX.UseVisualStyleBackColor = true;
            // 
            // chkCLY
            // 
            this.chkCLY.AutoSize = true;
            this.chkCLY.Checked = true;
            this.chkCLY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCLY.Location = new System.Drawing.Point(15, 174);
            this.chkCLY.Name = "chkCLY";
            this.chkCLY.Size = new System.Drawing.Size(60, 16);
            this.chkCLY.TabIndex = 0;
            this.chkCLY.Text = "测量员";
            this.chkCLY.UseVisualStyleBackColor = true;
            // 
            // chkRoad
            // 
            this.chkRoad.AutoSize = true;
            this.chkRoad.Checked = true;
            this.chkRoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoad.Location = new System.Drawing.Point(15, 152);
            this.chkRoad.Name = "chkRoad";
            this.chkRoad.Size = new System.Drawing.Size(72, 16);
            this.chkRoad.TabIndex = 0;
            this.chkRoad.Text = "道路一致";
            this.chkRoad.UseVisualStyleBackColor = true;
            // 
            // chkTCFS
            // 
            this.chkTCFS.AutoSize = true;
            this.chkTCFS.Checked = true;
            this.chkTCFS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTCFS.Location = new System.Drawing.Point(15, 130);
            this.chkTCFS.Name = "chkTCFS";
            this.chkTCFS.Size = new System.Drawing.Size(72, 16);
            this.chkTCFS.TabIndex = 0;
            this.chkTCFS.Text = "探测方式";
            this.chkTCFS.UseVisualStyleBackColor = true;
            // 
            // chkYSBM
            // 
            this.chkYSBM.AutoSize = true;
            this.chkYSBM.Location = new System.Drawing.Point(15, 108);
            this.chkYSBM.Name = "chkYSBM";
            this.chkYSBM.Size = new System.Drawing.Size(72, 16);
            this.chkYSBM.TabIndex = 0;
            this.chkYSBM.Text = "要素编码";
            this.chkYSBM.UseVisualStyleBackColor = true;
            // 
            // chkKCDW
            // 
            this.chkKCDW.AutoSize = true;
            this.chkKCDW.Checked = true;
            this.chkKCDW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKCDW.Location = new System.Drawing.Point(15, 86);
            this.chkKCDW.Name = "chkKCDW";
            this.chkKCDW.Size = new System.Drawing.Size(72, 16);
            this.chkKCDW.TabIndex = 0;
            this.chkKCDW.Text = "勘测单位";
            this.chkKCDW.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Checked = true;
            this.chkDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDelete.Location = new System.Drawing.Point(15, 64);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(48, 16);
            this.chkDelete.TabIndex = 0;
            this.chkDelete.Text = "删除";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(15, 42);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(48, 16);
            this.chkDate.TabIndex = 0;
            this.chkDate.Text = "日期";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chkQuanShu
            // 
            this.chkQuanShu.AutoSize = true;
            this.chkQuanShu.Checked = true;
            this.chkQuanShu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuanShu.Location = new System.Drawing.Point(15, 20);
            this.chkQuanShu.Name = "chkQuanShu";
            this.chkQuanShu.Size = new System.Drawing.Size(72, 16);
            this.chkQuanShu.TabIndex = 0;
            this.chkQuanShu.Text = "权属单位";
            this.chkQuanShu.UseVisualStyleBackColor = true;
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.Location = new System.Drawing.Point(77, 46);
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(100, 21);
            this.txtGroupNumber.TabIndex = 2;
            // 
            // btnAddGroupNumber
            // 
            this.btnAddGroupNumber.Location = new System.Drawing.Point(192, 46);
            this.btnAddGroupNumber.Name = "btnAddGroupNumber";
            this.btnAddGroupNumber.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroupNumber.TabIndex = 1;
            this.btnAddGroupNumber.Text = "Add";
            this.btnAddGroupNumber.UseVisualStyleBackColor = true;
            this.btnAddGroupNumber.Click += new System.EventHandler(this.btnAddGroupNumber_Click);
            // 
            // btnOpenFile2
            // 
            this.btnOpenFile2.Location = new System.Drawing.Point(767, 10);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile2.TabIndex = 1;
            this.btnOpenFile2.Text = "更改";
            this.btnOpenFile2.UseVisualStyleBackColor = true;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "组号：";
            // 
            // lblFileName2
            // 
            this.lblFileName2.AutoSize = true;
            this.lblFileName2.Location = new System.Drawing.Point(75, 21);
            this.lblFileName2.Name = "lblFileName2";
            this.lblFileName2.Size = new System.Drawing.Size(23, 12);
            this.lblFileName2.TabIndex = 0;
            this.lblFileName2.Text = "C:\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "文件：";
            // 
            // tabpageSelect
            // 
            this.tabpageSelect.Controls.Add(this.btnUpdateSelect);
            this.tabpageSelect.Controls.Add(this.dgvSelect);
            this.tabpageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabpageSelect.Name = "tabpageSelect";
            this.tabpageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageSelect.Size = new System.Drawing.Size(1174, 408);
            this.tabpageSelect.TabIndex = 2;
            this.tabpageSelect.Text = "Select";
            this.tabpageSelect.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSelect
            // 
            this.btnUpdateSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateSelect.Location = new System.Drawing.Point(18, 348);
            this.btnUpdateSelect.Name = "btnUpdateSelect";
            this.btnUpdateSelect.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSelect.TabIndex = 1;
            this.btnUpdateSelect.Text = "Update";
            this.btnUpdateSelect.UseVisualStyleBackColor = true;
            this.btnUpdateSelect.Click += new System.EventHandler(this.btnUpdateSelect_Click);
            // 
            // dgvSelect
            // 
            this.dgvSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Location = new System.Drawing.Point(0, 0);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowTemplate.Height = 23;
            this.dgvSelect.Size = new System.Drawing.Size(1174, 335);
            this.dgvSelect.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.打开SQL文件ToolStripMenuItem,
            this.打开Error文件ToolStripMenuItem,
            this.清空Error文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.打开ToolStripMenuItem.Text = "打开数据库";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 打开SQL文件ToolStripMenuItem
            // 
            this.打开SQL文件ToolStripMenuItem.Name = "打开SQL文件ToolStripMenuItem";
            this.打开SQL文件ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.打开SQL文件ToolStripMenuItem.Text = "打开SQL文件";
            this.打开SQL文件ToolStripMenuItem.Click += new System.EventHandler(this.打开SQL文件ToolStripMenuItem_Click);
            // 
            // 打开Error文件ToolStripMenuItem
            // 
            this.打开Error文件ToolStripMenuItem.Name = "打开Error文件ToolStripMenuItem";
            this.打开Error文件ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.打开Error文件ToolStripMenuItem.Text = "打开Error文件";
            this.打开Error文件ToolStripMenuItem.Click += new System.EventHandler(this.打开Error文件ToolStripMenuItem_Click);
            // 
            // 清空Error文件ToolStripMenuItem
            // 
            this.清空Error文件ToolStripMenuItem.Name = "清空Error文件ToolStripMenuItem";
            this.清空Error文件ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.清空Error文件ToolStripMenuItem.Text = "清空Error文件";
            this.清空Error文件ToolStripMenuItem.Click += new System.EventHandler(this.清空Error文件ToolStripMenuItem_Click);
            // 
            // btnUpdateGroupNumber
            // 
            this.btnUpdateGroupNumber.Location = new System.Drawing.Point(192, 183);
            this.btnUpdateGroupNumber.Name = "btnUpdateGroupNumber";
            this.btnUpdateGroupNumber.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGroupNumber.TabIndex = 7;
            this.btnUpdateGroupNumber.Text = "两位组号";
            this.btnUpdateGroupNumber.UseVisualStyleBackColor = true;
            this.btnUpdateGroupNumber.Click += new System.EventHandler(this.btnUpdateGroupNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 459);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access_田云";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSql.ResumeLayout(false);
            this.tabPageSql.PerformLayout();
            this.tabPagetool.ResumeLayout(false);
            this.tabPagetool.PerformLayout();
            this.gpbBatchUpdate.ResumeLayout(false);
            this.gpbBatchUpdate.PerformLayout();
            this.tabpageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSql;
        private System.Windows.Forms.TextBox txtSqls;
        private System.Windows.Forms.TextBox txtSqlYS;
        private System.Windows.Forms.TextBox txtTubeType;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnUpdateBySqls;
        private System.Windows.Forms.Button btnCreatSqls;
        private System.Windows.Forms.Button btnShowAllTubeType;
        private System.Windows.Forms.Button btnOpenDBFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPagetool;
        private System.Windows.Forms.GroupBox gpbBatchUpdate;
        private System.Windows.Forms.TextBox txtGroupNumber;
        private System.Windows.Forms.Button btnAddGroupNumber;
        private System.Windows.Forms.Button btnOpenFile2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFileName2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBatchUpdate;
        private System.Windows.Forms.CheckBox chkZX;
        private System.Windows.Forms.CheckBox chkGXLX;
        private System.Windows.Forms.CheckBox chkCLY;
        private System.Windows.Forms.CheckBox chkRoad;
        private System.Windows.Forms.CheckBox chkTCFS;
        private System.Windows.Forms.CheckBox chkYSBM;
        private System.Windows.Forms.CheckBox chkKCDW;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkQuanShu;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TabPage tabpageSelect;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.Button btnUpdateSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnWellDepth;
        private System.Windows.Forms.Button btnGXSJ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开SQL文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开Error文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空Error文件ToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateGroupNumber;
    }
}

