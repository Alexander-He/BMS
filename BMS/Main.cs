using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using BMS.AppData;
using System.Linq;
using BMS.Model;
using NPOI.XSSF.UserModel;

namespace BMS
{
    public partial class Main : Form
    {

        #region ����
        public static readonly String connectionString = "";
        public OleDbConnection connection = new OleDbConnection(connectionString);
        #endregion

        #region �¼�
        /// <summary>
        /// Form_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            PropertyMetadata item = new PropertyMetadata();
            item.Id = 10;
            item.Type = "asd";
            item.Name = "test1";
            item.Remark = "aa";
            DataService.AddMetadata(item);

            InitForm();
            btnSearch_Click(null, null);
        }
        /// <summary>
        /// ��ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCondition conditions = new SearchCondition()
            {
                CheckDateStart = dtDateStart.Value,
                CheckDateEnd = dtDateEnd.Value,
                Keyword = txtKey.Text.Trim(),
                ProjectName = txtProjectName.Text.Trim(),
                InvestigateCase = txtInvestigateCase.Text.Trim(),
                Remark = txtRemark.Text.Trim(),
                Place = cobxPlace.SelectedValue.ToInt(),
                BuildStruct = cobxBuildStruct.SelectedValue.ToInt(),
                ReportCondition = cobxReportCondition.SelectedValue.ToInt() 
            };
            dgvMain.DataSource = SearchData(conditions);
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add frm = new Add();
            frm.Show();
            if (frm.DialogResult == DialogResult.OK)
            {
                btnSearch_Click(null, null);
            }
        }
        /// <summary>
        /// ɾ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("ȷ��ɾ����ѡ�е���Ŀ��", "ɾ����Ŀ", MessageBoxButtons.OKCancel))
            {
                var Ids = new List<Guid>();
                for (int i = 0; i < dgvMain.SelectedRows.Count; i++)
                {
                    Ids.Add(dgvMain.SelectedRows[i].Cells[0].Value.ToGuid());
                }
                DataService.DelProject(Ids);
                btnSearch_Click(null, null);
            }
        }
        /// <summary>
        /// ѡ��ʼʱ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtDateStart_ValueChanged(object sender, EventArgs e)
        {
            dtDateEnd.MinDate = dtDateStart.Value;
        }
        /// <summary>
        /// ѡ�����ʱ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtDateEnd_ValueChanged(object sender, EventArgs e)
        {
            dtDateStart.MaxDate = dtDateEnd.Value;
        }

        /// <summary>
        /// �޸�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows != null)
            {
                Add frm = new Add();
                frm.strID = dgvMain.SelectedRows[0].Cells[0].Value.ToGuid();
                frm.ModifyType = "update";
                frm.Show();

            }
        }
        /// <summary>
        /// ˫���޸ķ���ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows != null)
            {
                Add frm = new Add();
                frm.strID = dgvMain.SelectedRows[0].Cells[0].Value.ToGuid();
                frm.ModifyType = "update";
                frm.Show();
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfig_Click(object sender, EventArgs e)
        {
            Config frm = new Config();
            frm.Show();
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvMain.DataSource != null)
            {
                var data = (List<Project>)dgvMain.DataSource;
                if (data.Count > 0)
                {
                    ExportExcel(data);
                }
                else
                {
                    MessageBox.Show("û�п��Ե���������");
                }
            }
            else
            {
                MessageBox.Show("û�п��Ե���������");
            }
        }
        #endregion

        #region ����
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ��ʼ��
        /// </summary>
        private void InitForm()
        {
            dtDateStart.Value = Convert.ToDateTime("2008-01-01");
            dtDateEnd.Value = DateTime.Now;

            dgvMain.AllowUserToOrderColumns = true;
            dgvMain.AllowUserToResizeColumns = true;
            dgvMain.AllowUserToResizeRows = true;

            var listPlace = DataService.GetAllMetadata(MetaDataType.Place);
            var listBuildStruct = DataService.GetAllMetadata(MetaDataType.BuildStruct);
            var listReportCondition = DataService.GetAllMetadata(MetaDataType.ReportCondition);


            listPlace.Insert(0, new PropertyMetadata { Id = 0, Name = "��ѡ��" });
            listBuildStruct.Insert(0, new PropertyMetadata { Id = 0, Name = "��ѡ��" });
            listReportCondition.Insert(0, new PropertyMetadata { Id = 0, Name = "��ѡ��" });

            cobxPlace.DataSource = listPlace;
            cobxBuildStruct.DataSource = listBuildStruct;
            cobxReportCondition.DataSource = listReportCondition;

            cobxPlace.SelectedIndex = 0;
            cobxBuildStruct.SelectedIndex = 0;
            cobxReportCondition.SelectedIndex = 0;
        }
        /// <summary>
        /// ��ѯ����
        /// </summary>
        public List<ProjectShow> SearchData(SearchCondition conditions)
        {
            return DataService.SearchProject(conditions);
        }
        /// <summary>
        /// ����Ϊexcel
        /// </summary>
        public void ExportExcel(List<Project> projets)
        {
            try
            { 
                string[] headerField = new string[] {
                    "���", "���", "��������", "���̵�ַ", "���赥λ", "ʩ����λ", "��Ƶ�λ", "����λ", "������", "��ϵ�绰", "���̸ſ�", "���̽���", "�������", "��������", "�������", "�鴦���", "��ע"
                    };

                string path = $"{System.Environment.CurrentDirectory}\\{ DateTime.Now.ToString("yyyyMMddhhmmssff")}-�����.xls";
                XSSFWorkbook workbook = new XSSFWorkbook();
                XSSFSheet sheet = (XSSFSheet)workbook.CreateSheet("���й����ۺ�ִ���ַ�ڷ־��ڽ����̵����");

                //set header
                XSSFRow rowHeader = (XSSFRow)sheet.CreateRow(2);
                for (int i = 0; i < headerField.Length; i++)
                {
                    rowHeader.Cells[i].SetCellValue(headerField[i]);
                }

                int index = 3;
                foreach (var project in projets)
                {
                    XSSFRow row = (XSSFRow)sheet.CreateRow(index);
                    row.Cells[0].SetCellValue(index - 2);
                    row.Cells[1].SetCellValue(project.Code);
                    row.Cells[2].SetCellValue(project.ProjectName);
                    row.Cells[3].SetCellValue(project.Address);
                    row.Cells[4].SetCellValue(project.BuildUnit);
                    row.Cells[5].SetCellValue(project.ConstructUnit);
                    row.Cells[6].SetCellValue(project.DesignUnit);
                    row.Cells[7].SetCellValue(project.SupervisorUnit);
                    row.Cells[8].SetCellValue(project.WorkChargre);
                    row.Cells[9].SetCellValue(project.Contact);
                    row.Cells[10].SetCellValue(project.ProjectDesc);
                    row.Cells[11].SetCellValue(project.ProjectProgress);
                    row.Cells[12].SetCellValue(project.ReportCondition);
                    row.Cells[13].SetCellValue(project.WorkStartDate.ToString("yyyy-MM-dd"));
                    row.Cells[14].SetCellValue(project.CheckDate.HasValue ? project.CheckDate.Value.ToString("yyyy-MM-dd") : string.Empty);
                    row.Cells[15].SetCellValue(project.InvestigateCase);
                    row.Cells[16].SetCellValue(project.Remark);
                }
                using (FileStream fs = new FileStream(path, FileMode.CreateNew))
                {
                    workbook.Write(fs);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
































        #endregion

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}