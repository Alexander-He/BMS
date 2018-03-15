namespace BMS
{
    partial class Image
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Image));
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imagelistSmall = new System.Windows.Forms.ImageList(this.components);
            this.lvImage = new System.Windows.Forms.ListView();
            this.imagelistLarge = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "图片文件|*.jpg|所有文件|*.*";
            this.ofdImage.Multiselect = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "增加照片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // imagelistSmall
            // 
            this.imagelistSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistSmall.ImageStream")));
            this.imagelistSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistSmall.Images.SetKeyName(0, "(e)SP_A0383---.jpg");
            // 
            // lvImage
            // 
            this.lvImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvImage.LargeImageList = this.imagelistLarge;
            this.lvImage.Location = new System.Drawing.Point(0, 37);
            this.lvImage.Name = "lvImage";
            this.lvImage.Size = new System.Drawing.Size(927, 401);
            this.lvImage.SmallImageList = this.imagelistSmall;
            this.lvImage.TabIndex = 4;
            this.lvImage.UseCompatibleStateImageBehavior = false;
            this.lvImage.View = System.Windows.Forms.View.Details;
            // 
            // imagelistLarge
            // 
            this.imagelistLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistLarge.ImageStream")));
            this.imagelistLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistLarge.Images.SetKeyName(0, "(e)SP_A0383---.jpg");
            // 
            // Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 438);
            this.Controls.Add(this.lvImage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Image";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.Image_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imagelistSmall;
        private System.Windows.Forms.ListView lvImage;
        private System.Windows.Forms.ImageList imagelistLarge;
    }
}