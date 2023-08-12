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
            this.DownBtn.Location = new System.Drawing.Point(171, 91);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 23);
            this.DownBtn.TabIndex = 2;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // UpDownListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.locationList);
            this.Name = "UpDownListItem";
            this.Text = "UpDownListItem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox locationList;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button DownBtn;
    }
}