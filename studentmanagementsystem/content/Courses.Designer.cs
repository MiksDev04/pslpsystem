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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.LoadCoursesPnl = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TotalRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentYearLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentProgram = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCoursesPnl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
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
            // LoadCoursesPnl
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.LoadCoursesPnl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LoadCoursesPnl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LoadCoursesPnl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LoadCoursesPnl.ColumnHeadersHeight = 30;
            this.LoadCoursesPnl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LoadCoursesPnl.DefaultCellStyle = dataGridViewCellStyle3;
            this.LoadCoursesPnl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoadCoursesPnl.Location = new System.Drawing.Point(12, 140);
            this.LoadCoursesPnl.Name = "LoadCoursesPnl";
            this.LoadCoursesPnl.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LoadCoursesPnl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LoadCoursesPnl.RowHeadersVisible = false;
            this.LoadCoursesPnl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(148)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LoadCoursesPnl.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LoadCoursesPnl.RowTemplate.Height = 25;
            this.LoadCoursesPnl.Size = new System.Drawing.Size(1023, 439);
            this.LoadCoursesPnl.TabIndex = 13;
            this.LoadCoursesPnl.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.LoadCoursesPnl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoadCoursesPnl.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LoadCoursesPnl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LoadCoursesPnl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.LoadCoursesPnl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LoadCoursesPnl.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LoadCoursesPnl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoadCoursesPnl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.LoadCoursesPnl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LoadCoursesPnl.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCoursesPnl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LoadCoursesPnl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LoadCoursesPnl.ThemeStyle.HeaderStyle.Height = 30;
            this.LoadCoursesPnl.ThemeStyle.ReadOnly = true;
            this.LoadCoursesPnl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.LoadCoursesPnl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LoadCoursesPnl.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCoursesPnl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.LoadCoursesPnl.ThemeStyle.RowsStyle.Height = 25;
            this.LoadCoursesPnl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.LoadCoursesPnl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentYearLevel);
            this.Controls.Add(this.TotalRecords);
            this.Controls.Add(this.LoadCoursesPnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Courses";
            this.Text = "YearLevel";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCoursesPnl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DepartmentLbl;
        private Guna.UI2.WinForms.Guna2DataGridView LoadCoursesPnl;
        private System.Windows.Forms.Label TotalRecords;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox StudentYearLevel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox StudentProgram;
    }
}