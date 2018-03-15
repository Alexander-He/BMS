using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace BMS
{
    public partial class Add : Form
    {

        #region 变量
        public static readonly String connectionString = ConfigurationManager.ConnectionStrings["BMSConnectionString"].ConnectionString;
        public OleDbConnection connection = new OleDbConnection(connectionString);
        public string strID = string.Empty;
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
                try
                {
                    connection = new OleDbConnection(connectionString);
                    connection.Open();

                    string strSql = string.Empty;
                    if (string.IsNullOrEmpty(strID))
                    {
                        OleDbDataAdapter ada = new OleDbDataAdapter("Select Max(ID) from Project ", connection);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        if (dt.Rows[0][0] != DBNull.Value)
                        {
                            strID = Convert.ToString(Convert.ToInt32(dt.Rows[0][0]) + 1);
                        }
                        else
                        {
                            strID = "1";
                        }
                        strSql = "insert into Project"
                                      + " values('"
                                      + strID + "'"
                                      + ",'" + txtProjectName.Text.Trim() + "'"
                                      + ",'" + cobxStruct.Text + "'"
                                      + "," + cobxArea.SelectedValue.ToString()
                                      + ",'" + txtAddress.Text.Trim() + "'"
                                      + ",'" + txtBuildUnit.Text.Trim() + "'"
                                      + ",'" + txtWorkUnit.Text.Trim() + "'"
                                      + ",'" + txtInCharge.Text.Trim() + "'"
                                      + ",'" + txtConact.Text.Trim() + "'"
                                      + ",'" + txtDesUnit.Text.Trim() + "'"
                                      + ",#" + dtStartWork.Value.ToString("yyyy-MM-dd") + "#"
                                      + ",'" + txtArea.Text.Trim() + "'"
                                      + ",'" + txtViewProc.Text.Trim() + "'"
                                      + "," + (rbtnTrue.Checked ? "True" : "False")
                                      + ",#" + dtCheckDate.Value.ToString("yyyy-MM-dd") + "#"
                                      + ",'" + txtRemark.Text.Trim() + "'"
                                      + ",#" + DateTime.Now.ToString("yyyy-MM-dd") + "#"
                                      + ")";
                    }
                    else
                    {
                        strSql = "Update Project Set"
                                + " ProjectName='" + txtProjectName.Text.Trim() + "',"
                                + " Struct='" + cobxStruct.Text + "',"
                                + " Place=" + cobxArea.SelectedValue.ToString() + ","
                                + " Address='" + txtAddress.Text.Trim() + "',"
                                + " BuildUnit='" + txtBuildUnit.Text.Trim() + "',"
                                + " WorkUnit='" + txtWorkUnit.Text.Trim() + "',"
                                + " WorkChargre='" + txtInCharge.Text.Trim() + "',"
                                + " Conact='" + txtConact.Text.Trim() + "',"
                                + " DesUnit='" + txtDesUnit.Text.Trim() + "',"
                                + " WorkStartDate=#" + dtStartWork.Value.ToString("yyyy-MM-dd") + "#,"
                                + " BuildArea='" + txtArea.Text.Trim() + "',"
                                + " ViewProc='" + txtViewProc.Text.Trim() + "',"
                                + " IsRight=" + (rbtnTrue.Checked ? "True" : "False") + ","
                                + " CheckDate=#" + dtCheckDate.Value.ToString("yyyy-MM-dd") + "#,"
                                + " Remark='" + txtRemark.Text.Trim() + "'"
                                + " where ID=" + strID + "";

                    }
                    OleDbCommand cmd = new OleDbCommand(strSql, connection);
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

                this.Close();
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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
            cobxStruct.SelectedIndex = 0;
            OleDbDataAdapter ada = new OleDbDataAdapter("Select * from Place", connection);
            DataTable dt = new DataTable();
            using (connection)
            {
                ada.Fill(dt);
                cobxArea.DataSource = dt;
                cobxArea.ValueMember = "ID";
                cobxArea.DisplayMember = "Place";
            }

            if (!string.IsNullOrEmpty(strID))
            {
                connection = new OleDbConnection(connectionString);
                ada = new OleDbDataAdapter("Select * from Project where ID=" + strID + "", connection);
                using (connection)
                {
                    DataTable dt2 = new DataTable();
                    ada.Fill(dt2);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        txtProjectName.Text = dt2.Rows[0]["ProjectName"].ToString();
                        cobxStruct.SelectedIndex = (dt2.Rows[0]["Struct"].ToString() == "搭建" ? 0 : 1);
                        cobxArea.SelectedValue = Convert.ToInt32(dt2.Rows[0]["Place"]);
                        txtAddress.Text = dt2.Rows[0]["Address"].ToString();
                        txtBuildUnit.Text = dt2.Rows[0]["BuildUnit"].ToString();
                        txtWorkUnit.Text = dt2.Rows[0]["WorkUnit"].ToString();
                        txtInCharge.Text = dt2.Rows[0]["WorkChargre"].ToString();
                        txtConact.Text = dt2.Rows[0]["Conact"].ToString();
                        txtDesUnit.Text = dt2.Rows[0]["DesUnit"].ToString();
                        dtStartWork.Value = Convert.ToDateTime(dt2.Rows[0]["WorkStartDate"]);
                        txtArea.Text = dt2.Rows[0]["BuildArea"].ToString();
                        txtViewProc.Text = dt2.Rows[0]["ViewProc"].ToString();
                        rbtnTrue.Checked = Convert.ToBoolean(dt2.Rows[0]["IsRight"]);
                        dtCheckDate.Value = Convert.ToDateTime(dt2.Rows[0]["CheckDate"]);
                        txtRemark.Text = dt2.Rows[0]["Remark"].ToString();
                    }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Image img = new Image();
            img.Show();
        }
    }
}