namespace BMS
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxPlaceBelong = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxPlace = new System.Windows.Forms.ListBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.gbxPlaceBelong.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPlaceBelong
            // 
            this.gbxPlaceBelong.Controls.Add(this.domainUpDown1);
            this.gbxPlaceBelong.Controls.Add(this.label1);
            this.gbxPlaceBelong.Controls.Add(this.txtRemark);
            this.gbxPlaceBelong.Controls.Add(this.btnSave);
            this.gbxPlaceBelong.Controls.Add(this.lblTip);
            this.gbxPlaceBelong.Controls.Add(this.txtPlace);
            this.gbxPlaceBelong.Controls.Add(this.btnDel);
            this.gbxPlaceBelong.Controls.Add(this.btnAdd);
            this.gbxPlaceBelong.Controls.Add(this.lbxPlace);
            this.gbxPlaceBelong.Controls.Add(this.textBox2);
            this.gbxPlaceBelong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPlaceBelong.Location = new System.Drawing.Point(0, 0);
            this.gbxPlaceBelong.Name = "gbxPlaceBelong";
            this.gbxPlaceBelong.Size = new System.Drawing.Size(1072, 540);
            this.gbxPlaceBelong.TabIndex = 0;
            this.gbxPlaceBelong.TabStop = false;
            this.gbxPlaceBelong.Text = "所属地";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 56);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(6, 59);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(31, 13);
            this.lblTip.TabIndex = 5;
            this.lblTip.Text = "名称";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(6, 78);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(292, 20);
            this.txtPlace.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(304, 308);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 56);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(304, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxPlace
            // 
            this.lbxPlace.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbxPlace.FormattingEnabled = true;
            this.lbxPlace.Location = new System.Drawing.Point(392, 16);
            this.lbxPlace.Name = "lbxPlace";
            this.lbxPlace.Size = new System.Drawing.Size(313, 521);
            this.lbxPlace.TabIndex = 0;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(6, 117);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(292, 417);
            this.txtRemark.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "备注";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox2.Location = new System.Drawing.Point(705, 16);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 521);
            this.textBox2.TabIndex = 9;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("所属地");
            this.domainUpDown1.Items.Add("设计单位");
            this.domainUpDown1.Items.Add("施工单位");
            this.domainUpDown1.Items.Add("监理单位");
            this.domainUpDown1.Location = new System.Drawing.Point(6, 19);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 10;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 540);
            this.Controls.Add(this.gbxPlaceBelong);
            this.Name = "Config";
            this.Text = "配置";
            this.Load += new System.EventHandler(this.Config_Load);
            this.gbxPlaceBelong.ResumeLayout(false);
            this.gbxPlaceBelong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlaceBelong;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxPlace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}