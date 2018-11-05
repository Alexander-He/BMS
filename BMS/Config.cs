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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

      

        #region �¼�
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblTip.Visible = true;
            lblTip.Text = "���������ƣ�";
            txtPlace.Visible = true;
            txtPlace.Text = string.Empty;
            btnSave.Visible = true;
            txtPlace.Focus();
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
           
                PropertyMetadata item = new PropertyMetadata();

                DataService.AddMetadata(item);
             

                lblTip.Visible = false;
                txtPlace.Visible = false;
                btnSave.Visible = false;
                txtPlace.Tag = null;

         
            LoadData();
        }
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbxPlace.SelectedItem != null)
            {
                lblTip.Visible = true;
                lblTip.Text = "���������ƣ�";
                txtPlace.Visible = true;
                txtPlace.Text = lbxPlace.Text;
                txtPlace.Tag = lbxPlace.SelectedValue;
                btnSave.Visible = true;
                txtPlace.Focus();
            }
        }
        /// <summary>
        /// ɾ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            //if (lbxPlace.SelectedItem != null)
            //{
            //    connection = new OleDbConnection(connectionString);
            //    try
            //    {
            //        connection.Open();
            //        OleDbCommand cmd = new OleDbCommand("select Count(ID) from Project where Place=" + lbxPlace.SelectedValue + "", connection);
            //        DataTable dt = new DataTable();
            //        OleDbDataAdapter ada = new OleDbDataAdapter(cmd);
            //        ada.Fill(dt);
            //        if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            //        {
            //            MessageBox.Show("��ѡ�е���������Ȼ�й�����Ŀ��ʹ�ã�����ɾ����");
            //            return;
            //        }
            //        if (MessageBox.Show("ɾ��������", "ȷ��Ҫɾ��ѡ�е���������", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //        {
            //            cmd = new OleDbCommand("Delete from Place where ID=" + lbxPlace.SelectedValue, connection);
            //            cmd.ExecuteNonQuery();

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
            //    LoadData();
            //}
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Config_Load(object sender, EventArgs e)
        {
            lblTip.Visible = false;
            txtPlace.Visible = false;
            btnSave.Visible = false;
            LoadData();
        }
        /// <summary>
        /// �ر�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ����
        /// <summary>
        /// ��������
        /// </summary>
        private void LoadData()
        {
            var list = DataService.GetAllMetadata();

            lbxPlace.DataSource = list;
            lbxPlace.ValueMember = "Id";
            lbxPlace.DisplayMember = "Name";
        }
        #endregion
    }
}