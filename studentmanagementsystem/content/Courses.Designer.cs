namespace studentmanagementsystem.content
{
    partial class Courses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.TotalRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentYearLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentProgram = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LoadCoursesInformation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCoursesInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(61)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.DepartmentLbl);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 65);
            this.panel1.TabIndex = 10;
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.BackColor = System.Drawing.Color.Transparent;
            this.DepartmentLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DepartmentLbl.Location = new System.Drawing.Point(402, 9);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(281, 37);
            this.DepartmentLbl.TabIndex = 8;
            this.DepartmentLbl.Text = "Department Courses";
            // 
            // TotalRecords
            // 
            this.TotalRecords.AutoSize = true;
            this.TotalRecords.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRecords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalRecords.Location = new System.Drawing.Point(754, 590);
            this.TotalRecords.Name = "TotalRecords";
            this.TotalRecords.Size = new System.Drawing.Size(73, 30);
            this.TotalRecords.TabIndex = 178;
            this.TotalRecords.Text = "Total: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 180;
            this.label2.Text = "Year Level";
            // 
            // StudentYearLevel
            // 
            this.StudentYearLevel.BackColor = System.Drawing.Color.Transparent;
            this.StudentYearLevel.BorderRadius = 10;
            this.StudentYearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StudentYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentYearLevel.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentYearLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentYearLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentYearLevel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StudentYearLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentYearLevel.ItemHeight = 30;
            this.StudentYearLevel.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4"});
            this.StudentYearLevel.Location = new System.Drawing.Point(12, 95);
            this.StudentYearLevel.Name = "StudentYearLevel";
            this.StudentYearLevel.Size = new System.Drawing.Size(169, 36);
            this.StudentYearLevel.TabIndex = 179;
            this.StudentYearLevel.SelectionChangeCommitted += new System.EventHandler(this.StudentYearLevel_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(219, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 182;
            this.label1.Text = "Program";
            // 
            // StudentProgram
            // 
            this.StudentProgram.BackColor = System.Drawing.Color.Transparent;
            this.StudentProgram.BorderRadius = 10;
            this.StudentProgram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StudentProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentProgram.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentProgram.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentProgram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentProgram.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StudentProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentProgram.ItemHeight = 30;
            this.StudentProgram.Location = new System.Drawing.Point(221, 95);
            this.StudentProgram.Name = "StudentProgram";
            this.StudentProgram.Size = new System.Drawing.Size(169, 36);
            this.StudentProgram.TabIndex = 181;
            this.StudentProgram.SelectionChangeCommitted += new System.EventHandler(this.StudentProgram_SelectionChangeCommitted);
            // 
            // LoadCoursesInformation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.LoadCoursesInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LoadCoursesInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LoadCoursesInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LoadCoursesInformation.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LoadCoursesInformation.DefaultCellStyle = dataGridViewCellStyle3;
            this.LoadCoursesInformation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoadCoursesInformation.Location = new System.Drawing.Point(14, 147);
            this.LoadCoursesInformation.Name = "LoadCoursesInformation";
            this.LoadCoursesInformation.ReadOnly = true;
            this.LoadCoursesInformation.RowHeadersVisible = false;
            this.LoadCoursesInformation.Size = new System.Drawing.Size(1019, 440);
            this.LoadCoursesInformation.TabIndex = 184;
            this.LoadCoursesInformation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.LoadCoursesInformation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.LoadCoursesInformation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LoadCoursesInformation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LoadCoursesInformation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LoadCoursesInformation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LoadCoursesInformation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LoadCoursesInformation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoadCoursesInformation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.LoadCoursesInformation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LoadCoursesInformation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCoursesInformation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LoadCoursesInformation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LoadCoursesInformation.ThemeStyle.HeaderStyle.Height = 30;
            this.LoadCoursesInformation.ThemeStyle.ReadOnly = true;
            this.LoadCoursesInformation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.LoadCoursesInformation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LoadCoursesInformation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCoursesInformation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.LoadCoursesInformation.ThemeStyle.RowsStyle.Height = 22;
            this.LoadCoursesInformation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.LoadCoursesInformation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 633);
            this.Controls.Add(this.LoadCoursesInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentYearLevel);
            this.Controls.Add(this.TotalRecords);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Courses";
            this.Text = "YearLevel";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCoursesInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DepartmentLbl;
        private System.Windows.Forms.Label TotalRecords;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox StudentYearLevel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox StudentProgram;
        private Guna.UI2.WinForms.Guna2DataGridView LoadCoursesInformation;
    }
}