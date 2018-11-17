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
using NPOI.SS.UserModel;
using System.Threading.Tasks;
using System.Threading;

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
            var list = SearchData(conditions);
            if (rbtnPlace.Checked)
            {
                if (cbxDA.Text == "����")
                    list = list.OrderBy(x => x.PlaceName).ToList();
                else
                    list = list.OrderByDescending(x => x.PlaceName).ToList();
            }
            else if (rbtnReport.Checked)
            {
                if (cbxDA.Text == "����")
                    list = list.OrderBy(x => x.ReportConditionName).ToList();
                else
                    list = list.OrderByDescending(x => x.ReportConditionName).ToList();
            }
            else if (rbtnCheckDate.Checked)
            {
                if (cbxDA.Text == "����")
                    list = list.OrderBy(x => x.CheckDate).ToList();
                else
                    list = list.OrderByDescending(x => x.CheckDate).ToList();
            }
            ofd.DataSource = list;
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add frm = new Add();
            if (frm.ShowDialog() == DialogResult.OK)
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
            if (ofd.SelectedRows != null && ofd.SelectedRows.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("ȷ��ɾ����ѡ�е���Ŀ��", "ɾ����Ŀ", MessageBoxButtons.OKCancel))
                {
                    var Ids = new List<string>();
                    for (int i = 0; i < ofd.SelectedRows.Count; i++)
                    {
                        Ids.Add(ofd.SelectedRows[i].Cells[0].Value.ToString());
                    }
                    DataService.DelProject(Ids);
                    btnSearch_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("��ѡ��Ҫɾ���Ĺ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (ofd.SelectedRows != null && ofd.SelectedRows.Count > 0)
            {
                Add frm = new Add();
                frm.strID = ofd.SelectedRows[0].Cells[0].Value.ToString();
                frm.ModifyType = "update";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnSearch_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵĹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// ˫���޸ķ���ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            if (ofd.SelectedRows != null && ofd.SelectedRows.Count > 0)
            {
                Add frm = new Add();
                frm.strID = ofd.SelectedRows[0].Cells[0].Value.ToString();
                frm.ModifyType = "update";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnSearch_Click(null, null);
                }
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
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Main_Load(null, null);
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ofd.DataSource != null)
            {
                var data = (List<ProjectShow>)ofd.DataSource;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = string.Empty;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                File.Copy(@"doc\����ģ��.xlsx", path, true);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportProject();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
            else if (e.KeyCode == Keys.F1)
            {
                btnAdd_Click(null, null);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnUpdate_Click(null, null);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnDelete_Click(null, null);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnConfig_Click(null, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnExport_Click(null, null);
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnImport_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("ȷ��Ҫ�˳���", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtMsg.Text = SolveMsg;
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

            ofd.AllowUserToOrderColumns = true;
            ofd.AllowUserToResizeColumns = true;
            ofd.AllowUserToResizeRows = true;

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
            cbxDA.SelectedIndex = 0;
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
        public void ExportExcel(List<ProjectShow> projets)
        {
            string path = string.Empty;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                txtMsg.Text = "";
                txtMsg.Visible = true;
                timer1.Enabled = true;
                SolveIndex = 0;
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        string[] headerField = new string[] {
                    "���", "���", "��������", "���̵�ַ", "���赥λ", "ʩ����λ", "��Ƶ�λ", "����λ", "������", "��ϵ�绰", "���̸ſ�", "���̽���", "�������", "��������", "�������", "�鴦���", "��ע"
                        };
                        XSSFWorkbook workbook = new XSSFWorkbook();
                        XSSFSheet sheet = (XSSFSheet)workbook.CreateSheet("���й����ۺ�ִ���ַ�ڷ־��ڽ����̵����");
                        XSSFCellStyle cellStyle = workbook.CreateCellStyle() as XSSFCellStyle;
                        cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                        cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                        cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                        cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                        //set header
                        XSSFRow rowHeader = (XSSFRow)sheet.CreateRow(2);

                        ICellStyle style1 = workbook.CreateCellStyle();
                        style1.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.LightBlue.Index;
                        style1.FillPattern = FillPattern.SolidForeground;
                        style1.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                        style1.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                        style1.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                        style1.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;

                        IFont font1 = workbook.CreateFont();
                        font1.Color = NPOI.HSSF.Util.HSSFColor.White.Index;
                        font1.IsBold = true;

                        style1.SetFont(font1);

                        for (int i = 0; i < headerField.Length; i++)
                        {
                            XSSFCell cell = rowHeader.CreateCell(i) as XSSFCell;
                            cell.CellStyle = style1;
                            rowHeader.Cells[i].SetCellValue(headerField[i]);
                        }

                        int index = 3;
                        foreach (var project in projets)
                        {
                            XSSFRow row = (XSSFRow)sheet.CreateRow(index);

                            for (int i = 0; i < 17; i++)
                            {
                                XSSFCell cell = row.CreateCell(i) as XSSFCell;
                                cell.CellStyle = cellStyle;
                            }

                            row.Cells[0].SetCellValue(index - 2);
                            row.Cells[1].SetCellValue(project.Code);
                            row.Cells[2].SetCellValue(project.ProjectName);
                            row.Cells[3].SetCellValue(project.Address);
                            row.Cells[4].SetCellValue(project.BuildUnit);
                            row.Cells[5].SetCellValue(project.ConstructUnitName);
                            row.Cells[6].SetCellValue(project.DesignUnitName);
                            row.Cells[7].SetCellValue(project.SupervisorUnitName);
                            row.Cells[8].SetCellValue(project.WorkChargre);
                            row.Cells[9].SetCellValue(project.Contact);
                            row.Cells[10].SetCellValue(project.ProjectDesc);
                            row.Cells[11].SetCellValue(project.ProjectProgress);
                            row.Cells[12].SetCellValue(project.ReportConditionName);
                            row.Cells[13].SetCellValue(project.WorkStartDateName);
                            row.Cells[14].SetCellValue(project.CheckDateName);
                            row.Cells[15].SetCellValue(project.InvestigateCase);
                            row.Cells[16].SetCellValue(project.Remark);
                            index++;

                            SolveIndex++;
                            SolveMsg = $"�ѵ�����{SolveIndex}��Ŀ��{project.ProjectName}��/�ܹ�{projets.Count}����Ŀ";
                        }
                        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                        {
                            workbook.Write(fs);
                        }
                        SolveMsg += $"\r\n�����ļ��ѱ��浽Ŀ¼��{path}��";
                        Thread.Sleep(200);
                    }
                    catch (Exception ex)
                    {
                        timer1.Enabled = false;
                        SolveMsg = "�ļ���������������ϸԭ��" + ex.ToString();
                    }
                    finally
                    {
                        timer1.Enabled = false;
                    }
                });
            }
        }

        int SolveIndex = 0;
        string SolveMsg = string.Empty;

        private void ImportProject()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtMsg.Text = "";
                txtMsg.Visible = true;
                timer1.Enabled = true;
                SolveIndex = 0;
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        XSSFWorkbook workbook = new XSSFWorkbook(openFileDialog.FileName);
                        XSSFSheet sheet = (XSSFSheet)workbook.GetSheetAt(0);
                        int line = 3, col = 1;
                        List<Project> list = new List<Project>();
                        XSSFRow row = sheet.GetRow(line) as XSSFRow;
                        while (!string.IsNullOrWhiteSpace(row.Cells[col + 1].StringCellValue))
                        {
                            Project project = new Project();

                            project.Id = Guid.NewGuid().ToString();
                            project.Code = row.Cells[col].StringCellValue.Trim();
                            project.ProjectName = row.Cells[col + 1].StringCellValue.Trim();
                            project.Address = row.Cells[col + 2].StringCellValue.Trim();
                            project.BuildUnit = row.Cells[col + 3].StringCellValue.Trim();
                            project.WorkChargre = row.Cells[col + 7].StringCellValue.Trim();
                            project.Contact = row.Cells[col + 8].StringCellValue.Trim();
                            project.ProjectDesc = row.Cells[col + 9].StringCellValue.Trim();
                            project.ProjectProgress = row.Cells[col + 10].StringCellValue.Trim();
                            project.WorkStartDate = row.Cells[col + 12].DateCellValue;
                            project.CheckDate = row.Cells[col + 13].DateCellValue;
                            project.InvestigateCase = row.Cells[col + 14].StringCellValue.Trim();
                            project.Remark = row.Cells[col + 15].StringCellValue.Trim();
                            if (row.Cells[col + 18].CellType == CellType.Numeric)
                                project.BuildArea = row.Cells[col + 18].NumericCellValue.ToString();
                            else
                                project.BuildArea = row.Cells[col + 18].StringCellValue.Trim();


                            var strConstructUnit = row.Cells[col + 4].StringCellValue.Trim();
                            var strDesignUnit = row.Cells[col + 5].StringCellValue.Trim();
                            var strSupervisorUnit = row.Cells[col + 6].StringCellValue.Trim();
                            var strReportCondition = row.Cells[col + 11].StringCellValue.Trim();
                            var strPlace = row.Cells[col + 16].StringCellValue.Trim();
                            var strBuildStruct = row.Cells[col + 17].StringCellValue.Trim();

                            var ConstructUnit = DataService.GetMetadata(strConstructUnit, MetaDataType.ConstructUnit);
                            if (ConstructUnit == null)
                            {
                                ConstructUnit = new PropertyMetadata();
                                ConstructUnit.Id = DataService.AddMetadata(strConstructUnit, MetaDataType.ConstructUnit, "���������Զ�����");
                            }
                            project.ConstructUnit = ConstructUnit.Id;


                            var DesignUnit = DataService.GetMetadata(strDesignUnit, MetaDataType.DesignUnit);
                            if (DesignUnit == null)
                            {
                                DesignUnit = new PropertyMetadata();
                                DesignUnit.Id = DataService.AddMetadata(strDesignUnit, MetaDataType.DesignUnit, "���������Զ�����");
                            }
                            project.DesignUnit = DesignUnit.Id;


                            var SupervisorUnit = DataService.GetMetadata(strSupervisorUnit, MetaDataType.SupervisorUnit);
                            if (SupervisorUnit == null)
                            {
                                SupervisorUnit = new PropertyMetadata();
                                SupervisorUnit.Id = DataService.AddMetadata(strSupervisorUnit, MetaDataType.SupervisorUnit, "���������Զ�����");
                            }
                            project.SupervisorUnit = SupervisorUnit.Id;


                            var ReportCondition = DataService.GetMetadata(strReportCondition, MetaDataType.ReportCondition);
                            if (ReportCondition == null)
                            {
                                ReportCondition = new PropertyMetadata();
                                ReportCondition.Id = DataService.AddMetadata(strReportCondition, MetaDataType.ReportCondition, "���������Զ�����");
                            }
                            project.ReportCondition = ReportCondition.Id;


                            var Place = DataService.GetMetadata(strPlace, MetaDataType.Place);
                            if (Place == null)
                            {
                                Place = new PropertyMetadata();
                                Place.Id = DataService.AddMetadata(strPlace, MetaDataType.Place, "���������Զ�����");
                            }
                            project.Place = Place.Id;


                            var BuildStruct = DataService.GetMetadata(strBuildStruct, MetaDataType.BuildStruct);
                            if (BuildStruct == null)
                            {
                                BuildStruct = new PropertyMetadata();
                                BuildStruct.Id = DataService.AddMetadata(strBuildStruct, MetaDataType.BuildStruct, "���������Զ�����");
                            }
                            project.BuildStruct = BuildStruct.Id;

                            DataService.AddProject(project);
                            SolveIndex++;
                            SolveMsg = $"�����ѵ����{SolveIndex}��Ŀ��{project.ProjectName}��";
                            line++;
                            row = sheet.GetRow(line) as XSSFRow;
                        }

                        SolveMsg += $"\r\n�ļ���{openFileDialog.FileName}���������";
                        Thread.Sleep(200);
                    }
                    catch (Exception ex)
                    {
                        timer1.Enabled = false;
                        SolveMsg = "�ļ����뷢���������鵼���ļ��Ƿ���ϵ���ģ�壬��ϸԭ��" + ex.ToString();
                    }
                    finally
                    {
                        timer1.Enabled = false;
                    }
                });
            }
        }



        #endregion


    }
}