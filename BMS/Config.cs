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
using System.Reflection;

namespace BMS
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }



        #region 事件
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblId.Text = "新增";
            txtName.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtName.Focus();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            MetaDataType metaDataType = MetaDataType.Place;
            string name = metaDataType.GetType().GetMember(metaDataType.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>()?.Description;
            Enum.TryParse<MetaDataType>(cobxMetedataType.SelectedValue.ToString(), out metaDataType);
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {

                MessageBox.Show($"{name}的名称不可以为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                var sameNameItem = DataService.GetMetadata(txtName.Text.Trim(), metaDataType);
                int Id = lbxMetadata.SelectedValue.ToInt();
                if ((lblId.Text == "新增" && sameNameItem != null) || (lblId.Text != "新增" && sameNameItem != null && lblId.Text.ToInt() != sameNameItem.Id))
                {
                    MessageBox.Show($"{txtName.Text.Trim()}已经存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MetaDataType temp = MetaDataType.Place;
            Enum.TryParse<MetaDataType>(cobxMetedataType.SelectedValue.ToString(), out temp);
            Int64 newId = 0;
            if (lblId.Text == "新增")
            {
                newId = DataService.AddMetadata(txtName.Text.Trim(), temp, txtRemark.Text.Trim());
                lblId.Text = "";
            }
            else if (lblId.Text != "")
            {
                PropertyMetadata item = new PropertyMetadata();

                newId = item.Id = lblId.Text.Trim().ToInt();
                item.Name = txtName.Text.Trim();
                item.Remark = txtRemark.Text.Trim();
                item.Type = temp.ToString();

                DataService.UpdateMetadata(item);
            }

            LoadMetaDataItems();

            lbxMetadata.SelectedValue = newId;
        }
        /// <summary>
        /// 删除所属地
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbxMetadata.SelectedItem != null)
            {
                MetaDataType metaDataType = MetaDataType.Place;
                Enum.TryParse<MetaDataType>(cobxMetedataType.SelectedValue.ToString(), out metaDataType);
                int Id = lbxMetadata.SelectedValue.ToInt();
                string name = metaDataType.GetType().GetMember(metaDataType.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>()?.Description;


                if (DataService.IsMetadataInUse(Id, metaDataType))
                {
                    MessageBox.Show($"所选中的{name}仍然有工程项目在使用，不能删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show($"确认要删除选中的{name}吗？", $"删除{name}", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataService.DelMetadata(Id);
                }

                LoadMetaDataItems();
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Config_Load(object sender, EventArgs e)
        {
            List<Tuple<string, string>> dataSource = new List<Tuple<string, string>>();
            var list = Enum.GetValues(typeof(MetaDataType));
            foreach (var item in list)
            {
                MetaDataType temp = MetaDataType.Place;
                Enum.TryParse<MetaDataType>(item.ToString(), out temp);
                string name = temp.GetType().GetMember(temp.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>()?.Description;

                dataSource.Add(new Tuple<string, string>(item.ToString(), name));
            }

            cobxMetedataType.DataSource = dataSource;
            cobxMetedataType.DisplayMember = "item2";
            cobxMetedataType.ValueMember = "item1";
            cobxMetedataType.SelectedIndex = 0;
            LoadMetaDataItems();
        }

        private void cobxMetedataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtRemark.Text = string.Empty;
            LoadMetaDataItems();
            txtName.Focus();
        }

        #endregion

        #region 方法
        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadMetaDataItems()
        {
            MetaDataType temp = MetaDataType.Place;
            Enum.TryParse<MetaDataType>(cobxMetedataType.SelectedValue.ToString(), out temp);
            var list = DataService.GetAllMetadata(temp);

            lbxMetadata.DataSource = list;
            if (list == null || list.Count == 0)
            {
                lblId.Text = "新增";
            }
        }

        #endregion

        private void lbxMetadata_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = lbxMetadata.SelectedValue.ToInt();
            var item = DataService.GetMetadata(Id);
            if (item != null)
            {
                txtMetadataRemark.Text = item.Remark;

                if (lblId.Text != "新增")
                {
                    lblId.Text = item.Id.ToString();
                    txtName.Text = item.Name;
                    txtRemark.Text = item.Remark;
                }
            }
        }

        private void Config_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnAdd_Click(null,null);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            } 
            else if (e.KeyCode == Keys.F3)
            {
                btnDel_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}