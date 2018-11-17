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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.gbxPlaceBelong = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cobxMetedataType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxMetadata = new System.Windows.Forms.ListBox();
            this.txtMetadataRemark = new System.Windows.Forms.TextBox();
            this.gbxPlaceBelong.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPlaceBelong
            // 
            this.gbxPlaceBelong.Controls.Add(this.lblId);
            this.gbxPlaceBelong.Controls.Add(this.cobxMetedataType);
            this.gbxPlaceBelong.Controls.Add(this.label1);
            this.gbxPlaceBelong.Controls.Add(this.txtRemark);
            this.gbxPlaceBelong.Controls.Add(this.btnSave);
            this.gbxPlaceBelong.Controls.Add(this.lblTip);
            this.gbxPlaceBelong.Controls.Add(this.txtName);
            this.gbxPlaceBelong.Controls.Add(this.btnDel);
            this.gbxPlaceBelong.Controls.Add(this.btnAdd);
            this.gbxPlaceBelong.Controls.Add(this.lbxMetadata);
            this.gbxPlaceBelong.Controls.Add(this.txtMetadataRemark);
            this.gbxPlaceBelong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPlaceBelong.Location = new System.Drawing.Point(0, 0);
            this.gbxPlaceBelong.Name = "gbxPlaceBelong";
            this.gbxPlaceBelong.Size = new System.Drawing.Size(1072, 540);
            this.gbxPlaceBelong.TabIndex = 0;
            this.gbxPlaceBelong.TabStop = false;
            this.gbxPlaceBelong.Text = " Ù–‘≈‰÷√";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblId.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblId.Location = new System.Drawing.Point(314, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 24);
            this.lblId.TabIndex = 11;
            // 
            // cobxMetedataType
            // 
            this.cobxMetedataType.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cobxMetedataType.DisplayMember = "Value";
            this.cobxMetedataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxMetedataType.Font = new System.Drawing.Font("Œ¢»Ì—≈∫⁄", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cobxMetedataType.ForeColor = System.Drawing.Color.Yellow;
            this.cobxMetedataType.FormattingEnabled = true;
            this.cobxMetedataType.ItemHeight = 27;
            this.cobxMetedataType.Location = new System.Drawing.Point(6, 19);
            this.cobxMetedataType.Name = "cobxMetedataType";
            this.cobxMetedataType.Size = new System.Drawing.Size(292, 35);
            this.cobxMetedataType.TabIndex = 10;
            this.cobxMetedataType.ValueMember = "Key";
            this.cobxMetedataType.SelectedIndexChanged += new System.EventHandler(this.cobxMetedataType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "±∏◊¢";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(6, 117);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(292, 417);
            this.txtRemark.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Œ¢»Ì—≈∫⁄", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(304, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 56);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "±£¥Ê(Enter)";
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
            this.lblTip.Text = "√˚≥∆";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Œ¢»Ì—≈∫⁄", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.ForeColor = System.Drawing.Color.Blue;
            this.btnDel.Location = new System.Drawing.Point(304, 308);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 56);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "…æ≥˝(F3)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Œ¢»Ì—≈∫⁄", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(304, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "–¬‘ˆ(F1)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxMetadata
            // 
            this.lbxMetadata.DisplayMember = "Name";
            this.lbxMetadata.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbxMetadata.FormattingEnabled = true;
            this.lbxMetadata.Location = new System.Drawing.Point(392, 16);
            this.lbxMetadata.Name = "lbxMetadata";
            this.lbxMetadata.Size = new System.Drawing.Size(313, 521);
            this.lbxMetadata.TabIndex = 0;
            this.lbxMetadata.ValueMember = "Id";
            this.lbxMetadata.SelectedIndexChanged += new System.EventHandler(this.lbxMetadata_SelectedIndexChanged);
            // 
            // txtMetadataRemark
            // 
            this.txtMetadataRemark.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtMetadataRemark.Location = new System.Drawing.Point(705, 16);
            this.txtMetadataRemark.Multiline = true;
            this.txtMetadataRemark.Name = "txtMetadataRemark";
            this.txtMetadataRemark.ReadOnly = true;
            this.txtMetadataRemark.Size = new System.Drawing.Size(364, 521);
            this.txtMetadataRemark.TabIndex = 9;
            // 
            // Config
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 540);
            this.Controls.Add(this.gbxPlaceBelong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Config";
            this.Text = "≈‰÷√";
            this.Load += new System.EventHandler(this.Config_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Config_KeyDown);
            this.gbxPlaceBelong.ResumeLayout(false);
            this.gbxPlaceBelong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlaceBelong;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxMetadata;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtMetadataRemark;
        private System.Windows.Forms.ComboBox cobxMetedataType;
        private System.Windows.Forms.Label lblId;
    }
}