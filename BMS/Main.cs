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

        #region 变量
        public static readonly String connectionString = "";
        public OleDbConnection connection = new OleDbConnection(connectionString);
        #endregion

        #region 事件
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
        /// 查询
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
                if (cbxDA.Text == "正序")
                    list = list.OrderBy(x => x.PlaceName).ToList();
                else
                    list = list.OrderByDescending(x => x.PlaceName).ToList();
            }
            else if (rbtnReport.Checked)
            {
                if (cbxDA.Text == "正序")
                    list = list.OrderBy(x => x.ReportConditionName).ToList();
                else
                    list = list.OrderByDescending(x => x.ReportConditionName).ToList();
            }
            else if (rbtnCheckDate.Checked)
            {
                if (cbxDA.Text == "正序")
                    list = list.OrderBy(x => x.CheckDate).ToList();
                else
                    list = list.OrderByDescending(x => x.CheckDate).ToList();
            }
            dgvMain.DataSource = list;
        }
        /// <summary>
        /// 新增
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
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定删除所选中的项目吗？", "删除项目", MessageBoxButtons.OKCancel))
            {
                var Ids = new List<string>();
                for (int i = 0; i < dgvMain.SelectedRows.Count; i++)
                {
                    Ids.Add(dgvMain.SelectedRows[i].Cells[0].Value.ToString());
                }
                DataService.DelProject(Ids);
                btnSearch_Click(null, null);
            }
        }
        /// <summary>
        /// 选择开始时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtDateStart_ValueChanged(object sender, EventArgs e)
        {
            dtDateEnd.MinDate = dtDateStart.Value;
        }
        /// <summary>
        /// 选择结束时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtDateEnd_ValueChanged(object sender, EventArgs e)
        {
            dtDateStart.MaxDate = dtDateEnd.Value;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows != null && dgvMain.SelectedRows.Count > 0)
            {
                Add frm = new Add();
                frm.strID = dgvMain.SelectedRows[0].Cells[0].Value.ToString();
                frm.ModifyType = "update";
                frm.Show();
            }
            else
            {
                MessageBox.Show("请选择要修改的工程", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 双击修改发生时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows != null && dgvMain.SelectedRows.Count > 0)
            {
                Add frm = new Add();
                frm.strID = dgvMain.SelectedRows[0].Cells[0].Value.ToString();
                frm.ModifyType = "update";
                frm.Show();
            }
        }
        /// <summary>
        /// 配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfig_Click(object sender, EventArgs e)
        {
            Config frm = new Config();
            frm.Show();
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvMain.DataSource != null)
            {
                var data = (List<ProjectShow>)dgvMain.DataSource;
                if (data.Count > 0)
                {
                    ExportExcel(data);
                }
                else
                {
                    MessageBox.Show("没有可以导出的数据");
                }
            }
            else
            {
                MessageBox.Show("没有可以导出的数据");
            }
        }
        #endregion

        #region 方法
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化
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


            listPlace.Insert(0, new PropertyMetadata { Id = 0, Name = "请选择" });
            listBuildStruct.Insert(0, new PropertyMetadata { Id = 0, Name = "请选择" });
            listReportCondition.Insert(0, new PropertyMetadata { Id = 0, Name = "请选择" });

            cobxPlace.DataSource = listPlace;
            cobxBuildStruct.DataSource = listBuildStruct;
            cobxReportCondition.DataSource = listReportCondition;

            cobxPlace.SelectedIndex = 0;
            cobxBuildStruct.SelectedIndex = 0;
            cobxReportCondition.SelectedIndex = 0;
            cbxDA.SelectedIndex = 0;
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        public List<ProjectShow> SearchData(SearchCondition conditions)
        {
            return DataService.SearchProject(conditions);
        }
        /// <summary>
        /// 导出为excel
        /// </summary>
        public void ExportExcel(List<ProjectShow> projets)
        {
            try
            {
                string path = string.Empty;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                    string[] headerField = new string[] {
                    "序号", "编号", "工程名称", "工程地址", "建设单位", "施工单位", "设计单位", "监理单位", "负责人", "联系电话", "工程概况", "工程进度", "报建情况", "开工日期", "检查日期", "查处情况", "备注"
                    };
                    XSSFWorkbook workbook = new XSSFWorkbook();
                    XSSFSheet sheet = (XSSFSheet)workbook.CreateSheet("城市管理综合执法局凤岗分局在建工程调查表");
                    XSSFCellStyle cellStyle = workbook.CreateCellStyle() as XSSFCellStyle;
                    cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                    //set header
                    XSSFRow rowHeader = (XSSFRow)sheet.CreateRow(2);
                    for (int i = 0; i < headerField.Length; i++)
                    {
                        XSSFCell cell = rowHeader.CreateCell(i) as XSSFCell;
                        cell.CellStyle = cellStyle;
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
                    }


                    using (FileStream fs = new FileStream(path, FileMode.CreateNew))
                    {
                        workbook.Write(fs);
                    }
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