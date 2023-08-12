namespace PracticeApp
{
    partial class ListBox
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
            this.LocationListBox = new System.Windows.Forms.ListBox();
            this.listBoxLbl = new System.Windows.Forms.Label();
            this.Locationtxt = new System.Windows.Forms.TextBox();
            this.SaveLocationBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.secondListBox = new System.Windows.Forms.ListBox();
            this.MoveItemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocationListBox
            // 
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.ItemHeight = 16;
            this.LocationListBox.Items.AddRange(new object[] {
            "Lahore",
            "Islamabad",
            "Karachi",
            "Peshawar"});
            this.LocationListBox.Location = new System.Drawing.Point(33, 50);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LocationListBox.Size = new System.Drawing.Size(117, 228);
            this.LocationListBox.TabIndex = 0;
            this.LocationListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.LocationListBox_DragEnter);
            this.LocationListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LocationListBox_MouseDown);
            // 
            // listBoxLbl
            // 
            this.listBoxLbl.AutoSize = true;
            this.listBoxLbl.Location = new System.Drawing.Point(191, 50);
            this.listBoxLbl.Name = "listBoxLbl";
            this.listBoxLbl.Size = new System.Drawing.Size(120, 16);
            this.listBoxLbl.TabIndex = 1;
            this.listBoxLbl.Text = "Add More Location";
            // 
            // Locationtxt
            // 
            this.Locationtxt.Location = new System.Drawing.Point(194, 79);
            this.Locationtxt.Name = "Locationtxt";
            this.Locationtxt.Size = new System.Drawing.Size(264, 22);
            this.Locationtxt.TabIndex = 2;
            this.Locationtxt.TextChanged += new System.EventHandler(this.Locationtxt_TextChanged);
            this.Locationtxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.Locationtxt_DragEnter);
            this.Locationtxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Locationtxt_MouseDown);
            // 
            // SaveLocationBtn
            // 
            this.SaveLocationBtn.Location = new System.Drawing.Point(194, 122);
            this.SaveLocationBtn.Name = "SaveLocationBtn";
            this.SaveLocationBtn.Size = new System.Drawing.Size(264, 23);
            this.SaveLocationBtn.TabIndex = 3;
            this.SaveLocationBtn.Text = "Add Location";
            this.SaveLocationBtn.UseVisualStyleBackColor = true;
            this.SaveLocationBtn.Click += new System.EventHandler(this.SaveLocationBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove Multi Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // secondListBox
            // 
            this.secondListBox.FormattingEnabled = true;
            this.secondListBox.ItemHeight = 16;
            this.secondListBox.Location = new System.Drawing.Point(33, 361);
            this.secondListBox.Name = "secondListBox";
            this.secondListBox.Size = new System.Drawing.Size(337, 116);
            this.secondListBox.TabIndex = 5;
            // 
            // MoveItemBtn
            // 
            this.MoveItemBtn.Location = new System.Drawing.Point(33, 305);
            this.MoveItemBtn.Name = "MoveItemBtn";
            this.MoveItemBtn.Size = new System.Drawing.Size(100, 23);
            this.MoveItemBtn.TabIndex = 6;
            this.MoveItemBtn.Text = "Move Item";
            this.MoveItemBtn.UseVisualStyleBackColor = true;
            this.MoveItemBtn.Click += new System.EventHandler(this.MoveItemBtn_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 479);
            this.Controls.Add(this.MoveItemBtn);
            this.Controls.Add(this.secondListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveLocationBtn);
            this.Controls.Add(this.Locationtxt);
            this.Controls.Add(this.listBoxLbl);
            this.Controls.Add(this.LocationListBox);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LocationListBox;
        private System.Windows.Forms.Label listBoxLbl;
        private System.Windows.Forms.TextBox Locationtxt;
        private System.Windows.Forms.Button SaveLocationBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox secondListBox;
        private System.Windows.Forms.Button MoveItemBtn;
    }
}