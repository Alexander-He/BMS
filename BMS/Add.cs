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
using System.Linq;

namespace BMS
{
    public partial class Add : Form
    {

        #region ���� 
        public string ModifyType = "new";
        public string strID = Guid.NewGuid().ToString();
        #endregion

        #region �¼�
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
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CanSave())
            {
                Project project = new Project
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
                    SupervisorUnit = cobxSupervisorUnit.SelectedValue.ToInt(),
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
                if (SaveProject(project))
                {
                    MessageBox.Show("����ɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region ����
        public Add()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ��ʼ��
        /// </summary>
        private void InitForm()
        {
            var listPlace = DataService.GetAllMetadata(MetaDataType.Place);
            var listReportCondition = DataService.GetAllMetadata(MetaDataType.ReportCondition);
            var listBuildStruct = DataService.GetAllMetadata(MetaDataType.BuildStruct);

            var listDesignUnit = DataService.GetAllMetadata(MetaDataType.DesignUnit);
            var listConstructUnit = DataService.GetAllMetadata(MetaDataType.ConstructUnit);
            var listSupervisorUnit = DataService.GetAllMetadata(MetaDataType.SupervisorUnit);

            cobxPlace.DataSource = listPlace;
            cobxReportCondition.DataSource = listReportCondition;
            cobxBuildStruct.DataSource = listBuildStruct;
            cobxConstructUnit.DataSource = listConstructUnit;
            cobxDesignUnit.DataSource = listDesignUnit;
            cobxSupervisorUnit.DataSource = listSupervisorUnit;

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
                    cobxSupervisorUnit.SelectedValue = project.SupervisorUnit;
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
                MessageBox.Show("�����빤������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                MessageBox.Show("���������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(cobxPlace.Text.Trim()))
            {
                MessageBox.Show("��ѡ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(cobxReportCondition.Text.Trim()))
            {
                MessageBox.Show("��ѡ�񱨽����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(cobxBuildStruct.Text.Trim()))
            {
                MessageBox.Show("��ѡ�����ṹ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(cobxDesignUnit.Text.Trim()))
            {
                MessageBox.Show("��ѡ������/ѡ����Ƶ�λ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(cobxConstructUnit.Text.Trim()))
            {
                MessageBox.Show("��ѡ������/ѡ��ʩ����λ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(cobxSupervisorUnit.Text.Trim()))
            {
                MessageBox.Show("��ѡ������/ѡ�����λ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!string.IsNullOrEmpty(txtProjectName.Text.Trim()))
            {
                var project = DataService.GetProjectByName(txtProjectName.Text.Trim());
                if (ModifyType == "new")
                {
                    if (project != null)
                    {
                        MessageBox.Show("���������Ѿ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    if (project != null && project.Id != strID)
                    {
                        MessageBox.Show("���������Ѿ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            if (!string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                var project = DataService.GetProjectByCode(txtCode.Text.Trim());
                if (ModifyType == "new")
                {
                    if (project != null)
                    {
                        MessageBox.Show("�����Ѿ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    if (project != null && project.Id != strID)
                    {
                        MessageBox.Show("�����Ѿ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            if (cobxDesignUnit.SelectedValue == null && !string.IsNullOrEmpty(cobxDesignUnit.Text.Trim()))
            {
                var list = new PropertyMetadata[cobxDesignUnit.Items.Count];
                cobxDesignUnit.Items.CopyTo(list, 0);

                if (list.Any(x=>x.Name == cobxDesignUnit.Text.Trim()))
                {
                    cobxDesignUnit.SelectedValue = list.FirstOrDefault(x => x.Name == cobxDesignUnit.Text.Trim()).Id;
                    return true;
                }

                if (MessageBox.Show($"��Ƶ�λ��{cobxDesignUnit.Text.Trim()}�������ڣ��Ƿ��Զ��������������棿", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    long temp = DataService.AddMetadata(cobxDesignUnit.Text.Trim(), MetaDataType.DesignUnit, "�Զ�����");

                    var listDesignUnit = DataService.GetAllMetadata(MetaDataType.DesignUnit);
                    cobxDesignUnit.DataSource = listDesignUnit;
                    cobxDesignUnit.SelectedValue = temp;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (cobxConstructUnit.SelectedValue == null && !string.IsNullOrEmpty(cobxConstructUnit.Text.Trim()))
            {
                var list = new PropertyMetadata[cobxConstructUnit.Items.Count];
                cobxConstructUnit.Items.CopyTo(list, 0);

                if (list.Any(x => x.Name == cobxConstructUnit.Text.Trim()))
                {
                    cobxConstructUnit.SelectedValue = list.FirstOrDefault(x => x.Name == cobxConstructUnit.Text.Trim()).Id;
                    return true;
                }

                if (MessageBox.Show($"ʩ����λ��{cobxConstructUnit.Text.Trim()}�������ڣ��Ƿ��Զ��������������棿", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    long temp = DataService.AddMetadata(cobxConstructUnit.Text.Trim(), MetaDataType.ConstructUnit, "�Զ�����");

                    var listConstructUnit = DataService.GetAllMetadata(MetaDataType.ConstructUnit);
                    cobxConstructUnit.DataSource = listConstructUnit;
                    cobxConstructUnit.SelectedValue = temp;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (cobxSupervisorUnit.SelectedValue == null && !string.IsNullOrEmpty(cobxSupervisorUnit.Text.Trim()))
            {
                var list = new PropertyMetadata[cobxSupervisorUnit.Items.Count];
                cobxSupervisorUnit.Items.CopyTo(list, 0);

                if (list.Any(x => x.Name == cobxSupervisorUnit.Text.Trim()))
                {
                    cobxSupervisorUnit.SelectedValue = list.FirstOrDefault(x => x.Name == cobxSupervisorUnit.Text.Trim()).Id;
                    return true;
                }

                if (MessageBox.Show($"����λ��{cobxSupervisorUnit.Text.Trim()}�������ڣ��Ƿ��Զ��������������棿", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    long temp = DataService.AddMetadata(cobxSupervisorUnit.Text.Trim(), MetaDataType.SupervisorUnit, "�Զ�����");

                    var listSupervisorUnit = DataService.GetAllMetadata(MetaDataType.SupervisorUnit);
                    cobxSupervisorUnit.DataSource = listSupervisorUnit;
                    cobxSupervisorUnit.SelectedValue = temp;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }

        private bool SaveProject(Project entity)
        {
            if (ModifyType == "new")
            {
                return DataService.AddProject(entity) > 0;
            }
            else
            {
                return DataService.UpdateProject(entity) > 0;
            }
        }

        #endregion 
    }
}