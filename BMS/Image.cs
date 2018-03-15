using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BMS
{
    public partial class Image : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;
        public Image()
        {
            InitializeComponent();
        }

        private void Image_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                foreach (string s in ofdImage.FileNames)
                {
                    imagelistSmall.Images.Add(i.ToString(), System.Drawing.Image.FromFile(s));
                    i++;
                }
            }
            
        }

        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            this.lvImage.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Size";
            this.lvImage.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Last accsessed";
            this.lvImage.Columns.Add(colHead);
        }

        private void PaintListView(string root)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            if (root.CompareTo("") == 0)
                return;
            DirectoryInfo dir = new DirectoryInfo(root);     
        }

    }
}