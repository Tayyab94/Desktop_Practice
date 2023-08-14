namespace PracticeApp
{
    partial class MainForm
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
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.subjectlbl = new System.Windows.Forms.Label();
            this.add_subjectLbl = new System.Windows.Forms.Label();
            this.addsubjecttxt = new System.Windows.Forms.TextBox();
            this.addSibjectBtn = new System.Windows.Forms.Button();
            this.removeSelectedItem = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Items.AddRange(new object[] {
            "Javascript",
            "Jquery",
            "Bootstaps",
            "AspNet Core",
            ".Net",
            "C#"});
            this.subjectComboBox.Location = new System.Drawing.Point(25, 141);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(493, 24);
            this.subjectComboBox.TabIndex = 0;
            // 
            // subjectlbl
            // 
            this.subjectlbl.AutoSize = true;
            this.subjectlbl.Location = new System.Drawing.Point(22, 113);
            this.subjectlbl.Name = "subjectlbl";
            this.subjectlbl.Size = new System.Drawing.Size(131, 16);
            this.subjectlbl.TabIndex = 1;
            this.subjectlbl.Text = "Select Your Subjects";
            // 
            // add_subjectLbl
            // 
            this.add_subjectLbl.AutoSize = true;
            this.add_subjectLbl.Location = new System.Drawing.Point(25, 31);
            this.add_subjectLbl.Name = "add_subjectLbl";
            this.add_subjectLbl.Size = new System.Drawing.Size(80, 16);
            this.add_subjectLbl.TabIndex = 2;
            this.add_subjectLbl.Text = "Add Subject";
            // 
            // addsubjecttxt
            // 
            this.addsubjecttxt.Location = new System.Drawing.Point(28, 51);
            this.addsubjecttxt.Name = "addsubjecttxt";
            this.addsubjecttxt.Size = new System.Drawing.Size(211, 22);
            this.addsubjecttxt.TabIndex = 3;
            // 
            // addSibjectBtn
            // 
            this.addSibjectBtn.Location = new System.Drawing.Point(335, 51);
            this.addSibjectBtn.Name = "addSibjectBtn";
            this.addSibjectBtn.Size = new System.Drawing.Size(155, 62);
            this.addSibjectBtn.TabIndex = 4;
            this.addSibjectBtn.Text = "Save Subject";
            this.addSibjectBtn.UseVisualStyleBackColor = true;
            this.addSibjectBtn.Click += new System.EventHandler(this.addSibjectBtn_Click);
            // 
            // removeSelectedItem
            // 
            this.removeSelectedItem.Location = new System.Drawing.Point(25, 219);
            this.removeSelectedItem.Name = "removeSelectedItem";
            this.removeSelectedItem.Size = new System.Drawing.Size(297, 45);
            this.removeSelectedItem.TabIndex = 5;
            this.removeSelectedItem.Text = "Remove Selected Item";
            this.removeSelectedItem.UseVisualStyleBackColor = true;
            this.removeSelectedItem.Click += new System.EventHandler(this.removeSelectedItem_Click);
            // 
            // UserName
            // 
            this.UserName.AcceptsTab = true;
            this.UserName.Location = new System.Drawing.Point(28, 291);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(421, 22);
            this.UserName.TabIndex = 6;
            this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 442);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.removeSelectedItem);
            this.Controls.Add(this.addSibjectBtn);
            this.Controls.Add(this.addsubjecttxt);
            this.Controls.Add(this.add_subjectLbl);
            this.Controls.Add(this.subjectlbl);
            this.Controls.Add(this.subjectComboBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label subjectlbl;
        private System.Windows.Forms.Label add_subjectLbl;
        private System.Windows.Forms.TextBox addsubjecttxt;
        private System.Windows.Forms.Button addSibjectBtn;
        private System.Windows.Forms.Button removeSelectedItem;
        private System.Windows.Forms.TextBox UserName;
    }
}