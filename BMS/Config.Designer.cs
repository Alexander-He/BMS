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
            this.lbxPlace = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxPlaceBelong.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPlaceBelong
            // 
            this.gbxPlaceBelong.Controls.Add(this.btnClose);
            this.gbxPlaceBelong.Controls.Add(this.btnSave);
            this.gbxPlaceBelong.Controls.Add(this.lblTip);
            this.gbxPlaceBelong.Controls.Add(this.txtPlace);
            this.gbxPlaceBelong.Controls.Add(this.btnDel);
            this.gbxPlaceBelong.Controls.Add(this.btnUpdate);
            this.gbxPlaceBelong.Controls.Add(this.btnAdd);
            this.gbxPlaceBelong.Controls.Add(this.lbxPlace);
            this.gbxPlaceBelong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPlaceBelong.Location = new System.Drawing.Point(0, 0);
            this.gbxPlaceBelong.Name = "gbxPlaceBelong";
            this.gbxPlaceBelong.Size = new System.Drawing.Size(290, 377);
            this.gbxPlaceBelong.TabIndex = 0;
            this.gbxPlaceBelong.TabStop = false;
            this.gbxPlaceBelong.Text = "所属地";
            // 
            // lbxPlace
            // 
            this.lbxPlace.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbxPlace.FormattingEnabled = true;
            this.lbxPlace.ItemHeight = 12;
            this.lbxPlace.Location = new System.Drawing.Point(135, 17);
            this.lbxPlace.Name = "lbxPlace";
            this.lbxPlace.Size = new System.Drawing.Size(152, 352);
            this.lbxPlace.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(6, 319);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(6, 55);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(123, 21);
            this.txtPlace.TabIndex = 4;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(6, 40);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(41, 12);
            this.lblTip.TabIndex = 5;
            this.lblTip.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 377);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxPlace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Button btnClose;
    }
}