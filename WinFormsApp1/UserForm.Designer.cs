namespace WinFormsApp1
{
    partial class UserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            studentBindingSource = new BindingSource(components);
            panel1 = new Panel();
            StudentDGV = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewButtonColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            SaveBtn = new Button();
            StudentNameTxt = new TextBox();
            StudentNameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // panel1
            // 
            panel1.Controls.Add(StudentDGV);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 502);
            panel1.TabIndex = 1;
            // 
            // StudentDGV
            // 
            StudentDGV.AutoGenerateColumns = false;
            StudentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDGV.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            StudentDGV.DataSource = studentBindingSource;
            StudentDGV.Dock = DockStyle.Fill;
            StudentDGV.Location = new Point(0, 0);
            StudentDGV.Name = "StudentDGV";
            StudentDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.White;
            StudentDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            StudentDGV.RowTemplate.Height = 29;
            StudentDGV.Size = new Size(478, 502);
            StudentDGV.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(StudentNameTxt);
            panel2.Controls.Add(StudentNameLbl);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(478, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 502);
            panel2.TabIndex = 2;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.Location = new Point(73, 167);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(470, 42);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // StudentNameTxt
            // 
            StudentNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentNameTxt.Location = new Point(73, 105);
            StudentNameTxt.Name = "StudentNameTxt";
            StudentNameTxt.Size = new Size(470, 34);
            StudentNameTxt.TabIndex = 1;
            // 
            // StudentNameLbl
            // 
            StudentNameLbl.AutoSize = true;
            StudentNameLbl.Location = new Point(73, 70);
            StudentNameLbl.Name = "StudentNameLbl";
            StudentNameLbl.Size = new Size(104, 20);
            StudentNameLbl.TabIndex = 0;
            StudentNameLbl.Text = "Student Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 502);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource studentBindingSource;
        private Panel panel1;
        private DataGridView StudentDGV;
        private Panel panel2;
        private Button SaveBtn;
        private TextBox StudentNameTxt;
        private Label StudentNameLbl;
        private DataGridViewButtonColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
