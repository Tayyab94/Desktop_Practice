namespace PracticeApp
{
    partial class ListView
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.UserlistView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(586, 23);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(184, 43);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add Button";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UserlistView
            // 
            this.UserlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.UserName,
            this.Email});
            this.UserlistView.FullRowSelect = true;
            this.UserlistView.HideSelection = false;
            this.UserlistView.Location = new System.Drawing.Point(22, 23);
            this.UserlistView.Name = "UserlistView";
            this.UserlistView.Size = new System.Drawing.Size(533, 415);
            this.UserlistView.TabIndex = 2;
            this.UserlistView.UseCompatibleStateImageBehavior = false;
            this.UserlistView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 40;
            // 
            // UserName
            // 
            this.UserName.Text = "User Name";
            this.UserName.Width = 150;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 200;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(586, 94);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(184, 42);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UserlistView);
            this.Controls.Add(this.AddBtn);
            this.Name = "ListView";
            this.Text = "ListView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListView UserlistView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button DeleteBtn;
    }
}