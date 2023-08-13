namespace PracticeApp
{
    partial class UpDownListItem
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
            this.locationList = new System.Windows.Forms.ListBox();
            this.UpBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.usreImg = new System.Windows.Forms.PictureBox();
            this.uploadImgBtn = new System.Windows.Forms.Button();
            this.RemoveImageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usreImg)).BeginInit();
            this.SuspendLayout();
            // 
            // locationList
            // 
            this.locationList.FormattingEnabled = true;
            this.locationList.ItemHeight = 16;
            this.locationList.Items.AddRange(new object[] {
            "Lahore",
            "Peshawar",
            "Gujranwal"});
            this.locationList.Location = new System.Drawing.Point(52, 53);
            this.locationList.Name = "locationList";
            this.locationList.Size = new System.Drawing.Size(90, 100);
            this.locationList.TabIndex = 0;
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(171, 53);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 23);
            this.UpBtn.TabIndex = 1;
            this.UpBtn.Text = "Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DownBtn.Location = new System.Drawing.Point(171, 91);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 23);
            this.DownBtn.TabIndex = 2;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // DOB
            // 
            this.DOB.CustomFormat = "yyyy-MMM-dd m:ss";
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOB.Location = new System.Drawing.Point(52, 174);
            this.DOB.MaxDate = new System.DateTime(2023, 8, 12, 18, 13, 47, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(254, 22);
            this.DOB.TabIndex = 3;
            this.DOB.Value = new System.DateTime(2023, 8, 12, 0, 0, 0, 0);
            this.DOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            this.DOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // usreImg
            // 
            this.usreImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usreImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usreImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usreImg.Location = new System.Drawing.Point(348, 41);
            this.usreImg.Name = "usreImg";
            this.usreImg.Size = new System.Drawing.Size(302, 193);
            this.usreImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usreImg.TabIndex = 4;
            this.usreImg.TabStop = false;
            this.usreImg.Click += new System.EventHandler(this.usreImg_Click);
            // 
            // uploadImgBtn
            // 
            this.uploadImgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadImgBtn.Location = new System.Drawing.Point(348, 268);
            this.uploadImgBtn.Name = "uploadImgBtn";
            this.uploadImgBtn.Size = new System.Drawing.Size(145, 31);
            this.uploadImgBtn.TabIndex = 5;
            this.uploadImgBtn.Text = "Upload Image";
            this.uploadImgBtn.UseVisualStyleBackColor = true;
            this.uploadImgBtn.Click += new System.EventHandler(this.uploadImgBtn_Click);
            // 
            // RemoveImageBtn
            // 
            this.RemoveImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveImageBtn.AutoSize = true;
            this.RemoveImageBtn.BackColor = System.Drawing.Color.HotPink;
            this.RemoveImageBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveImageBtn.Location = new System.Drawing.Point(499, 268);
            this.RemoveImageBtn.Name = "RemoveImageBtn";
            this.RemoveImageBtn.Size = new System.Drawing.Size(151, 31);
            this.RemoveImageBtn.TabIndex = 6;
            this.RemoveImageBtn.Text = "Remove Image";
            this.RemoveImageBtn.UseCompatibleTextRendering = true;
            this.RemoveImageBtn.UseVisualStyleBackColor = false;
            this.RemoveImageBtn.Click += new System.EventHandler(this.RemoveImageBtn_Click);
            // 
            // UpDownListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 403);
            this.Controls.Add(this.RemoveImageBtn);
            this.Controls.Add(this.uploadImgBtn);
            this.Controls.Add(this.usreImg);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.locationList);
            this.Name = "UpDownListItem";
            this.Text = "UpDownListItem";
            ((System.ComponentModel.ISupportInitialize)(this.usreImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox locationList;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.PictureBox usreImg;
        private System.Windows.Forms.Button uploadImgBtn;
        private System.Windows.Forms.Button RemoveImageBtn;
    }
}