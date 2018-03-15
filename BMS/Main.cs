using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace BMS
{
    public partial class Main : Form
    {

        #region ����
        public static readonly String connectionString = ConfigurationManager.ConnectionStrings["BMSConnectionString"].ConnectionString;
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
            //InitForm();
            //btnSearch_Click(null, null);
        }
        /// <summary>
        /// ��ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = SearchData();
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
                connection = new OleDbConnection(connectionString);
                for (int i = 0; i < dgvMain.SelectedRows.Count; i++)
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand cmd = new OleDbCommand("Delete from Project where ID=" + dgvMain.SelectedRows[i].Cells[0].Value.ToString(), connection);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
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
        /// �˳�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                frm.strID = dgvMain.SelectedRows[0].Cells[0].Value.ToString();
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
                frm.strID = dgvMain.SelectedRows[0].Cells[0].Value.ToString();

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
        /// ��ӡ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            cutePrinter2 p = new cutePrinter2(dgvMain, "���й����ۺ�ִ���ַ�ڷ־��ڽ����̵����", "", "", "", "", "", false);
            p.Print();
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            System.Data.DataTable data = (System.Data.DataTable)dgvMain.DataSource;
            ExportExcel(data);
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
            //dtDateStart.Value = Convert.ToDateTime("2008-01-01");
            //dtDateEnd.Value = DateTime.Now;

            //dgvMain.AllowUserToOrderColumns = true;
            //dgvMain.AllowUserToResizeColumns = true;
            //dgvMain.AllowUserToResizeRows = true;

            //OleDbDataAdapter ada = new OleDbDataAdapter("select '0' as ID,'��ѡ��'as Place from place union Select ID,Place from Place", connection);
            //System.Data.DataTable dt = new System.Data.DataTable();
            //using (connection)
            //{
            //    ada.Fill(dt);
            //    cobxBelong.DataSource = dt;
            //    cobxBelong.ValueMember = "ID";
            //    cobxBelong.DisplayMember = "Place";
            //}
            //cobxIsRight.SelectedIndex = 0;
            //cobxStruct.SelectedIndex = 0;
        }
        /// <summary>
        /// ��ѯ����
        /// </summary>
        public System.Data.DataTable SearchData()
        {
            //��ѯ����
            string strWhere = " where 1=1";
            //�ؼ���
            string strKeys = "";
            if (!String.IsNullOrEmpty(txtKey.Text.Trim()))
            {
                strKeys += " and (";
                foreach (string str in txtKey.Text.Trim().Split(' '))
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        strKeys += " a.ProjectName like '%" + str + "%' or a.Remark like '%" + str + "%' or";
                    }
                }
                strKeys = strKeys.Trim('r');
                strKeys = strKeys.Trim('o');
                strKeys += ") ";

                strWhere += strKeys;
            }
            //���ʱ��            
            strWhere += " and a.CheckDate >=#" + dtDateStart.Value.ToString("yyyy-MM-dd") + "# and a.CheckDate<=#" + dtDateEnd.Value.AddDays(1).ToString("yyyy-MM-dd") + "#";
            //������
            if (cobxBelong.SelectedIndex > 0)
            {
                strWhere += " and a.Place=" + cobxBelong.SelectedValue.ToString();
            }
            //�Ƿ�Υ��
            if (cobxIsRight.SelectedIndex > 0)
            {
                if (cobxIsRight.SelectedIndex == 1)
                    strWhere += " and a.IsRight=false";
                else
                    strWhere += " and a.IsRight=true";
            }
            //�����ṹ
            if (cobxStruct.SelectedIndex != 0)
            {
                strWhere += " and a.Struct='" + cobxStruct.Text + "'";
            }

            connection = new OleDbConnection(connectionString);
            string strSql = "SELECT a.ID, a.ProjectName, a.Struct, b.Place, a.Address, a.BuildUnit, a.WorkUnit, a.WorkChargre, a.Conact, a.DesUnit, a.WorkStartDate, a.BuildArea,a.ViewProc, IIf([IsRight]=True,\"δ����\",\"�ѱ���\") AS IsRights, a.CheckDate, a.Remark FROM Project AS a LEFT JOIN Place AS b ON a.Place = b.ID";
            OleDbDataAdapter ada = new OleDbDataAdapter(strSql + strWhere, connection);
            System.Data.DataTable dt = new System.Data.DataTable();
            using (connection)
            {
                ada.Fill(dt);
                return dt;
            }
        }
        /// <summary>
        /// ����Ϊexcel
        /// </summary>
        public void ExportExcel(System.Data.DataTable dt)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = null;
            Worksheet worksheet = null;
            object missing = System.Reflection.Missing.Value;

            string path = "";
            path = System.Environment.CurrentDirectory;
            try
            {
                workbook = excel.Workbooks.Open(path + "\\" + "Demo.xls", missing,
                    missing, missing, missing, missing, missing,
                    missing, missing, missing, missing, missing,
                    missing, missing, missing);

                worksheet = (Worksheet)workbook.Sheets[1];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        worksheet.Cells[i + 4, "A"] = dt.Rows[i][0].ToString();
                        worksheet.Cells[i + 4, "B"] = dt.Rows[i][1].ToString();
                        worksheet.Cells[i + 4, "C"] = dt.Rows[i][4].ToString();
                        worksheet.Cells[i + 4, "D"] = dt.Rows[i][5].ToString();
                        worksheet.Cells[i + 4, "E"] = dt.Rows[i][6].ToString();
                        worksheet.Cells[i + 4, "F"] = dt.Rows[i][7].ToString();
                        worksheet.Cells[i + 4, "G"] = dt.Rows[i][9].ToString();
                        worksheet.Cells[i + 4, "H"] = dt.Rows[i][11].ToString();
                        worksheet.Cells[i + 4, "I"] = dt.Rows[i][12].ToString();
                        worksheet.Cells[i + 4, "J"] = dt.Rows[i][13].ToString();
                        worksheet.Cells[i + 4, "K"] = Convert.ToDateTime(dt.Rows[i][14]).ToString("yyyy-MM-dd");
                        worksheet.Cells[i + 4, "L"] = dt.Rows[i][15].ToString();
                    }
                }
                worksheet.get_Range("A5", "L" + dt.Rows.Count + 1).WrapText = true;
                worksheet.get_Range("A5", "L" + dt.Rows.Count + 1).EntireRow.AutoFit();

                workbook.SaveCopyAs(path + "\\" + DateTime.Now.ToString("yyyyMMddhhmmssff") + "-�����.xls");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (worksheet != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    worksheet = null;
                }

                if (workbook != null)
                {
                    workbook.Close(false, null, null);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    workbook = null;
                }

                if (excel != null)
                {
                    excel.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                    excel = null;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        #endregion

































    }
}