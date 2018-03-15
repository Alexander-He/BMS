namespace BMS
{
    partial class Main
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cobxBelong = new System.Windows.Forms.ComboBox();
            this.cobxIsRight = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cobxStruct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Struct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkChargre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProjectName,
            this.Struct,
            this.Place,
            this.Address,
            this.BuildUnit,
            this.WorkUnit,
            this.WorkChargre,
            this.Conact,
            this.DesUnit,
            this.WorkStartDate,
            this.BuildArea,
            this.ViewProc,
            this.IsRight,
            this.CheckDate,
            this.Remark});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMain.Location = new System.Drawing.Point(0, 61);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1016, 650);
            this.dgvMain.TabIndex = 5;
            this.dgvMain.DoubleClick += new System.EventHandler(this.dgvMain_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(912, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 21);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询(Enter)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(50, 5);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(101, 21);
            this.txtKey.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "关键字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "检查日期范围:";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "yyyy-MM-dd";
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(244, 5);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(109, 21);
            this.dtDateStart.TabIndex = 12;
            this.dtDateStart.ValueChanged += new System.EventHandler(this.dtDateStart_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "到:";
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.CustomFormat = "yyyy-MM-dd";
            this.dtDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateEnd.Location = new System.Drawing.Point(386, 5);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(113, 21);
            this.dtDateEnd.TabIndex = 14;
            this.dtDateEnd.ValueChanged += new System.EventHandler(this.dtDateEnd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "所属地：";
            // 
            // cobxBelong
            // 
            this.cobxBelong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxBelong.Location = new System.Drawing.Point(562, 5);
            this.cobxBelong.Name = "cobxBelong";
            this.cobxBelong.Size = new System.Drawing.Size(66, 20);
            this.cobxBelong.TabIndex = 16;
            // 
            // cobxIsRight
            // 
            this.cobxIsRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxIsRight.Items.AddRange(new object[] {
            "请选择",
            "已报建",
            "未报建"});
            this.cobxIsRight.Location = new System.Drawing.Point(703, 5);
            this.cobxIsRight.Name = "cobxIsRight";
            this.cobxIsRight.Size = new System.Drawing.Size(63, 20);
            this.cobxIsRight.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "是否违章：";
            // 
            // cobxStruct
            // 
            this.cobxStruct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxStruct.Items.AddRange(new object[] {
            "请选择",
            "搭建",
            "框架"});
            this.cobxStruct.Location = new System.Drawing.Point(841, 5);
            this.cobxStruct.Name = "cobxStruct";
            this.cobxStruct.Size = new System.Drawing.Size(66, 20);
            this.cobxStruct.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "建筑结构：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(162, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(81, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(324, 32);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 25;
            this.btnConfig.Text = "配置";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(941, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(244, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(405, 32);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            this.ID.Width = 54;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.Frozen = true;
            this.ProjectName.HeaderText = "工程名称";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 78;
            // 
            // Struct
            // 
            this.Struct.DataPropertyName = "Struct";
            this.Struct.HeaderText = "建筑结构";
            this.Struct.Name = "Struct";
            this.Struct.ReadOnly = true;
            this.Struct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Struct.Width = 78;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "所属地";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Place.Width = 66;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address.Width = 54;
            // 
            // BuildUnit
            // 
            this.BuildUnit.DataPropertyName = "BuildUnit";
            this.BuildUnit.HeaderText = "建筑单位";
            this.BuildUnit.Name = "BuildUnit";
            this.BuildUnit.ReadOnly = true;
            this.BuildUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BuildUnit.Width = 78;
            // 
            // WorkUnit
            // 
            this.WorkUnit.DataPropertyName = "WorkUnit";
            this.WorkUnit.HeaderText = "施工单位";
            this.WorkUnit.Name = "WorkUnit";
            this.WorkUnit.ReadOnly = true;
            this.WorkUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkUnit.Width = 78;
            // 
            // WorkChargre
            // 
            this.WorkChargre.DataPropertyName = "WorkChargre";
            this.WorkChargre.HeaderText = "施工负责人";
            this.WorkChargre.Name = "WorkChargre";
            this.WorkChargre.ReadOnly = true;
            this.WorkChargre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkChargre.Width = 90;
            // 
            // Conact
            // 
            this.Conact.DataPropertyName = "Conact";
            this.Conact.HeaderText = "联系电话";
            this.Conact.Name = "Conact";
            this.Conact.ReadOnly = true;
            this.Conact.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Conact.Width = 78;
            // 
            // DesUnit
            // 
            this.DesUnit.DataPropertyName = "DesUnit";
            this.DesUnit.HeaderText = "设计单位";
            this.DesUnit.Name = "DesUnit";
            this.DesUnit.ReadOnly = true;
            this.DesUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DesUnit.Width = 78;
            // 
            // WorkStartDate
            // 
            this.WorkStartDate.DataPropertyName = "WorkStartDate";
            this.WorkStartDate.HeaderText = "开工时间";
            this.WorkStartDate.Name = "WorkStartDate";
            this.WorkStartDate.ReadOnly = true;
            this.WorkStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkStartDate.Width = 78;
            // 
            // BuildArea
            // 
            this.BuildArea.DataPropertyName = "BuildArea";
            this.BuildArea.HeaderText = "建筑面积";
            this.BuildArea.Name = "BuildArea";
            this.BuildArea.ReadOnly = true;
            this.BuildArea.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BuildArea.Width = 78;
            // 
            // ViewProc
            // 
            this.ViewProc.DataPropertyName = "ViewProc";
            this.ViewProc.HeaderText = "形象进度";
            this.ViewProc.Name = "ViewProc";
            this.ViewProc.ReadOnly = true;
            this.ViewProc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewProc.Width = 78;
            // 
            // IsRight
            // 
            this.IsRight.DataPropertyName = "IsRights";
            this.IsRight.HeaderText = "是否违章";
            this.IsRight.Name = "IsRight";
            this.IsRight.ReadOnly = true;
            this.IsRight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsRight.Width = 78;
            // 
            // CheckDate
            // 
            this.CheckDate.DataPropertyName = "CheckDate";
            this.CheckDate.HeaderText = "检查日期";
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.ReadOnly = true;
            this.CheckDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckDate.Width = 78;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Remark.Width = 54;
            // 
            // Main
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 711);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.cobxStruct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cobxIsRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cobxBelong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnSearch);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMS";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDateEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobxBelong;
        private System.Windows.Forms.ComboBox cobxIsRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cobxStruct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Struct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkChargre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}

