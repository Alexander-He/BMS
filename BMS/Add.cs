using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using BMS.Model;

namespace BMS
{
    public partial class Add : Form
    {

        #region 变量 
        public string ModifyType = "new";
        public Guid strID = Guid.NewGuid();
        #endregion

        #region 事件
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitForm();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (CanSave())
            {
                string strSql = string.Empty;
                if (ModifyType == "new")
                {
                    var entity = new Project
                    {
                        Id = Guid.NewGuid(),
                        Code = txtCode.Text.Trim(),
                        ProjectName = txtProjectName.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        Place = cobxPlace.SelectedValue.ToInt(),
                        BuildUnit = txtBuildUnit.Text.Trim(),
                        ConstructUnit = cobxConstructUnit.SelectedValue.ToInt(),
                        DesignUnit = cobxDesignUnit.SelectedValue.ToInt(),
                        BuildStruct = cobxBuildStruct.SelectedValue.ToInt(),
                        ReportCondition = cobxReportCondition.SelectedValue.ToInt(),
                        SupervisorUnit = comboSupervisorUnit.SelectedValue.ToInt(),
                        WorkChargre = txtWorkChargre.Text.Trim(),
                        Contact = txtContact.Text.Trim(),
                        ProjectDesc = txtProjectDesc.Text.Trim(),
                        ProjectProgress = txtProjectProgress.Text.Trim(),
                        WorkStartDate = dtWorkStartDate.Value,
                        CheckDate = dtCheckDate.Value,
                        BuildArea = txtBuildArea.Text.Trim(),
                        InvestigateCase = txtInvestigateCase.Text.Trim(),
                        Remark = txtRemark.Text.Trim(),
                        CreateDate = DateTime.Now
                    };

                    DataService.AddProject(entity);
                }
                else
                {
                    var entity = new Project
                    {
                        Id = strID,
                        Code = txtCode.Text.Trim(),
                        ProjectName = txtProjectName.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        Place = cobxPlace.SelectedValue.ToInt(),
                        BuildUnit = txtBuildUnit.Text.Trim(),
                        ConstructUnit = cobxConstructUnit.SelectedValue.ToInt(),
                        DesignUnit = cobxDesignUnit.SelectedValue.ToInt(),
                        BuildStruct = cobxBuildStruct.SelectedValue.ToInt(),
                        ReportCondition = cobxReportCondition.SelectedValue.ToInt(),
                        SupervisorUnit = comboSupervisorUnit.SelectedValue.ToInt(),
                        WorkChargre = txtWorkChargre.Text.Trim(),
                        Contact = txtContact.Text.Trim(),
                        ProjectDesc = txtProjectDesc.Text.Trim(),
                        ProjectProgress = txtProjectProgress.Text.Trim(),
                        WorkStartDate = dtWorkStartDate.Value,
                        CheckDate = dtCheckDate.Value,
                        BuildArea = txtBuildArea.Text.Trim(),
                        InvestigateCase = txtInvestigateCase.Text.Trim(),
                        Remark = txtRemark.Text.Trim()
                    };

                    DataService.UpdateProject(entity);
                }
                this.Close();
            }
        }
        #endregion

        #region 方法
        public Add()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        private void InitForm()
        {
            var listPlace = DataService.GetAllMetadata(MetaDataType.Place);
            var listBuildStruct = DataService.GetAllMetadata(MetaDataType.BuildStruct);
            var listReportCondition = DataService.GetAllMetadata(MetaDataType.ReportCondition);
            var listDesignUnit = DataService.GetAllMetadata(MetaDataType.DesignUnit);
            var listConstructUnit = DataService.GetAllMetadata(MetaDataType.ConstructUnit);
            var listSupervisorUnit = DataService.GetAllMetadata(MetaDataType.SupervisorUnit); 

            cobxPlace.DataSource = listPlace;
            cobxBuildStruct.DataSource = listBuildStruct;
            cobxReportCondition.DataSource = listReportCondition;
            cobxConstructUnit.DataSource = listConstructUnit;
            cobxDesignUnit.DataSource = listDesignUnit;
            comboSupervisorUnit.DataSource = listSupervisorUnit;

            if (ModifyType != "new")
            {
                var project = DataService.GetProject(strID);
                if (project != null)
                {
                    txtCode.Text = project.Code;
                    txtProjectName.Text = project.ProjectName;
                    txtAddress.Text = project.Address;
                    cobxPlace.SelectedValue = project.Place;
                    txtBuildUnit.Text = project.BuildUnit;
                    cobxConstructUnit.SelectedValue = project.ConstructUnit;
                    cobxDesignUnit.SelectedValue = project.DesignUnit;
                    cobxBuildStruct.SelectedValue = project.BuildStruct;
                    cobxReportCondition.SelectedValue = project.ReportCondition;
                    comboSupervisorUnit.SelectedValue = project.SupervisorUnit;
                    txtWorkChargre.Text = project.WorkChargre;
                    txtContact.Text = project.Contact;
                    txtProjectDesc.Text = project.ProjectDesc;
                    txtProjectProgress.Text = project.ProjectProgress;
                    dtWorkStartDate.Value = project.WorkStartDate;
                    dtCheckDate.Value = project.CheckDate.HasValue ? project.CheckDate.Value : DateTime.Now;
                    txtBuildArea.Text = project.BuildArea;
                    txtInvestigateCase.Text = project.InvestigateCase;
                    txtRemark.Text = project.Remark;
                }
            }

            txtProjectName.Focus();
        }
        private bool CanSave()
        {
            if (string.IsNullOrEmpty(txtProjectName.Text.Trim()))
            {
                MessageBox.Show("请输入工程名称");
                return false;
            }
            return true;

        }
        #endregion


    }
}