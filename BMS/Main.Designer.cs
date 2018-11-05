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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cobxPlace = new System.Windows.Forms.ComboBox();
            this.cobxReportCondition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cobxBuildStruct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInvestigateCase = new System.Windows.Forms.TextBox();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupervisorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildStruct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkChargre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvestigateCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ProjectId,
            this.Code,
            this.ProjectName,
            this.Address,
            this.BuildUnit,
            this.ConstructUnit,
            this.DesignUnit,
            this.SupervisorUnit,
            this.BuildStruct,
            this.Place,
            this.WorkChargre,
            this.Conact,
            this.ProjectDesc,
            this.ProjectProgress,
            this.ReportCondition,
            this.WorkStartDate,
            this.CheckDate,
            this.InvestigateCase,
            this.BuildArea,
            this.Remark});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMain.Location = new System.Drawing.Point(0, 102);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1623, 670);
            this.dgvMain.TabIndex = 5;
            this.dgvMain.DoubleClick += new System.EventHandler(this.dgvMain_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(944, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 90);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询(Enter)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(837, 3);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(101, 20);
            this.txtKey.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "关键字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "检查日期时间段:";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "yyyy-MM-dd";
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(112, 5);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(109, 20);
            this.dtDateStart.TabIndex = 12;
            this.dtDateStart.ValueChanged += new System.EventHandler(this.dtDateStart_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "到:";
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.CustomFormat = "yyyy-MM-dd";
            this.dtDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateEnd.Location = new System.Drawing.Point(255, 4);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(113, 20);
            this.dtDateEnd.TabIndex = 14;
            this.dtDateEnd.ValueChanged += new System.EventHandler(this.dtDateEnd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "所属地：";
            // 
            // cobxPlace
            // 
            this.cobxPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxPlace.Location = new System.Drawing.Point(432, 3);
            this.cobxPlace.Name = "cobxPlace";
            this.cobxPlace.Size = new System.Drawing.Size(66, 21);
            this.cobxPlace.TabIndex = 16;
            // 
            // cobxReportCondition
            // 
            this.cobxReportCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxReportCondition.Items.AddRange(new object[] {
            "请选择",
            "未报建",
            "未按规划施工",
            "镇报建",
            "市报建",
            "已拆除",
            "已补办"});
            this.cobxReportCondition.Location = new System.Drawing.Point(716, 4);
            this.cobxReportCondition.Name = "cobxReportCondition";
            this.cobxReportCondition.Size = new System.Drawing.Size(63, 21);
            this.cobxReportCondition.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "报建情况：";
            // 
            // cobxBuildStruct
            // 
            this.cobxBuildStruct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxBuildStruct.Items.AddRange(new object[] {
            "请选择",
            "搭建",
            "框架",
            "其它"});
            this.cobxBuildStruct.Location = new System.Drawing.Point(574, 3);
            this.cobxBuildStruct.Name = "cobxBuildStruct";
            this.cobxBuildStruct.Size = new System.Drawing.Size(66, 21);
            this.cobxBuildStruct.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "建筑结构：";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(15, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 40);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(245, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(130, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 40);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfig.Location = new System.Drawing.Point(360, 54);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(109, 40);
            this.btnConfig.TabIndex = 25;
            this.btnConfig.Text = "配置";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(475, 54);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 40);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "工程名称:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(76, 28);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(173, 20);
            this.txtProjectName.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "备注:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(574, 28);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(364, 20);
            this.txtRemark.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "查处情况:";
            // 
            // txtInvestigateCase
            // 
            this.txtInvestigateCase.Location = new System.Drawing.Point(319, 28);
            this.txtInvestigateCase.Name = "txtInvestigateCase";
            this.txtInvestigateCase.Size = new System.Drawing.Size(205, 20);
            this.txtInvestigateCase.TabIndex = 33;
            // 
            // ProjectId
            // 
            this.ProjectId.DataPropertyName = "Id";
            this.ProjectId.Frozen = true;
            this.ProjectId.HeaderText = "主键";
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.Visible = false;
            this.ProjectId.Width = 56;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Code.DataPropertyName = "Code";
            this.Code.Frozen = true;
            this.Code.HeaderText = "编号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Code.Width = 56;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.Frozen = true;
            this.ProjectName.HeaderText = "工程名称";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 80;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "工程地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address.Width = 80;
            // 
            // BuildUnit
            // 
            this.BuildUnit.DataPropertyName = "BuildUnit";
            this.BuildUnit.HeaderText = "建设单位";
            this.BuildUnit.Name = "BuildUnit";
            this.BuildUnit.ReadOnly = true;
            this.BuildUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BuildUnit.Width = 80;
            // 
            // ConstructUnit
            // 
            this.ConstructUnit.DataPropertyName = "ConstructUnitName";
            this.ConstructUnit.HeaderText = "施工单位";
            this.ConstructUnit.Name = "ConstructUnit";
            this.ConstructUnit.ReadOnly = true;
            this.ConstructUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConstructUnit.Width = 80;
            // 
            // DesignUnit
            // 
            this.DesignUnit.DataPropertyName = "DesignUnitName";
            this.DesignUnit.HeaderText = "设计单位";
            this.DesignUnit.Name = "DesignUnit";
            this.DesignUnit.ReadOnly = true;
            this.DesignUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DesignUnit.Width = 80;
            // 
            // SupervisorUnit
            // 
            this.SupervisorUnit.DataPropertyName = "SupervisorUnit";
            this.SupervisorUnit.HeaderText = "监理单位";
            this.SupervisorUnit.Name = "SupervisorUnit";
            this.SupervisorUnit.Width = 80;
            // 
            // BuildStruct
            // 
            this.BuildStruct.DataPropertyName = "BuildStructName";
            this.BuildStruct.HeaderText = "建筑结构";
            this.BuildStruct.Name = "BuildStruct";
            this.BuildStruct.ReadOnly = true;
            this.BuildStruct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BuildStruct.Width = 80;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "PlaceName";
            this.Place.HeaderText = "所属地";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Place.Width = 68;
            // 
            // WorkChargre
            // 
            this.WorkChargre.DataPropertyName = "WorkChargre";
            this.WorkChargre.HeaderText = "负责人";
            this.WorkChargre.Name = "WorkChargre";
            this.WorkChargre.ReadOnly = true;
            this.WorkChargre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkChargre.Width = 68;
            // 
            // Conact
            // 
            this.Conact.DataPropertyName = "Conact";
            this.Conact.HeaderText = "联系电话";
            this.Conact.Name = "Conact";
            this.Conact.ReadOnly = true;
            this.Conact.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Conact.Width = 80;
            // 
            // ProjectDesc
            // 
            this.ProjectDesc.DataPropertyName = "ProjectDesc";
            this.ProjectDesc.HeaderText = "工程概况";
            this.ProjectDesc.Name = "ProjectDesc";
            this.ProjectDesc.Width = 80;
            // 
            // ProjectProgress
            // 
            this.ProjectProgress.DataPropertyName = "ProjectProgress";
            this.ProjectProgress.HeaderText = "工程进度";
            this.ProjectProgress.Name = "ProjectProgress";
            this.ProjectProgress.ReadOnly = true;
            this.ProjectProgress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectProgress.Width = 80;
            // 
            // ReportCondition
            // 
            this.ReportCondition.DataPropertyName = "ReportConditionName";
            this.ReportCondition.HeaderText = "报建情况";
            this.ReportCondition.Name = "ReportCondition";
            this.ReportCondition.ReadOnly = true;
            this.ReportCondition.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportCondition.Width = 80;
            // 
            // WorkStartDate
            // 
            this.WorkStartDate.DataPropertyName = "WorkStartDate";
            this.WorkStartDate.HeaderText = "开工时间";
            this.WorkStartDate.Name = "WorkStartDate";
            this.WorkStartDate.ReadOnly = true;
            this.WorkStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkStartDate.Width = 80;
            // 
            // CheckDate
            // 
            this.CheckDate.DataPropertyName = "CheckDate";
            this.CheckDate.HeaderText = "检查日期";
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.ReadOnly = true;
            this.CheckDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckDate.Width = 80;
            // 
            // InvestigateCase
            // 
            this.InvestigateCase.DataPropertyName = "InvestigateCase";
            this.InvestigateCase.HeaderText = "查处情况";
            this.InvestigateCase.Name = "InvestigateCase";
            this.InvestigateCase.Width = 80;
            // 
            // BuildArea
            // 
            this.BuildArea.DataPropertyName = "BuildArea";
            this.BuildArea.HeaderText = "建筑面积";
            this.BuildArea.Name = "BuildArea";
            this.BuildArea.ReadOnly = true;
            this.BuildArea.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BuildArea.Width = 80;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Remark.Width = 56;
            // 
            // Main
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 772);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtInvestigateCase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.cobxBuildStruct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cobxReportCondition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cobxPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMS";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDateEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobxPlace;
        private System.Windows.Forms.ComboBox cobxReportCondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cobxBuildStruct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnExport; 
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInvestigateCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupervisorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildStruct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkChargre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvestigateCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridView dgvMain;
    }
}

