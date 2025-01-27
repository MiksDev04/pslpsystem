namespace studentmanagementsystem.content
{
    partial class ViewRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StudentID = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Birthdate = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.YearLevel = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Section = new System.Windows.Forms.Label();
            this.Program = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ViewCourseInformation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SkillSets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCourseInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Record";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Animated = true;
            this.ExitBtn.BackgroundImage = global::studentmanagementsystem.Properties.Resources.reject;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.BorderColor = System.Drawing.Color.Transparent;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(863, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 25);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(22, 105);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(75, 17);
            this.StudentID.TabIndex = 0;
            this.StudentID.Text = "Student ID: ";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(22, 133);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(73, 17);
            this.FullName.TabIndex = 1;
            this.FullName.Text = "Full Name: ";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(139, 166);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(38, 17);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age: ";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(24, 165);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(35, 17);
            this.Sex.TabIndex = 3;
            this.Sex.Text = "Sex: ";
            // 
            // Birthdate
            // 
            this.Birthdate.AutoSize = true;
            this.Birthdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdate.Location = new System.Drawing.Point(25, 192);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(67, 17);
            this.Birthdate.TabIndex = 4;
            this.Birthdate.Text = "Birthdate: ";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(24, 222);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(63, 17);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address: ";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(25, 250);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 17);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email: ";
            // 
            // YearLevel
            // 
            this.YearLevel.AutoSize = true;
            this.YearLevel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLevel.Location = new System.Drawing.Point(25, 313);
            this.YearLevel.Name = "YearLevel";
            this.YearLevel.Size = new System.Drawing.Size(73, 17);
            this.YearLevel.TabIndex = 7;
            this.YearLevel.Text = "Year Level: ";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(25, 282);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.Text = "Phone Number: ";
            // 
            // Section
            // 
            this.Section.AutoSize = true;
            this.Section.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.Location = new System.Drawing.Point(162, 311);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(57, 17);
            this.Section.TabIndex = 9;
            this.Section.Text = "Section: ";
            // 
            // Program
            // 
            this.Program.AutoSize = true;
            this.Program.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program.Location = new System.Drawing.Point(27, 399);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(66, 17);
            this.Program.TabIndex = 10;
            this.Program.Text = "Program: ";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(26, 346);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(84, 17);
            this.Department.TabIndex = 11;
            this.Department.Text = "Department: ";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(27, 374);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(50, 17);
            this.Status.TabIndex = 12;
            this.Status.Text = "Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personal Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Course Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Skills Information";
            // 
            // ViewCourseInformation
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.ViewCourseInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ViewCourseInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewCourseInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ViewCourseInformation.ColumnHeadersHeight = 30;
            this.ViewCourseInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewCourseInformation.DefaultCellStyle = dataGridViewCellStyle15;
            this.ViewCourseInformation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.ViewCourseInformation.Location = new System.Drawing.Point(383, 105);
            this.ViewCourseInformation.Name = "ViewCourseInformation";
            this.ViewCourseInformation.ReadOnly = true;
            this.ViewCourseInformation.RowHeadersVisible = false;
            this.ViewCourseInformation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewCourseInformation.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.ViewCourseInformation.RowTemplate.Height = 25;
            this.ViewCourseInformation.Size = new System.Drawing.Size(494, 291);
            this.ViewCourseInformation.TabIndex = 16;
            this.ViewCourseInformation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.ViewCourseInformation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.ViewCourseInformation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ViewCourseInformation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ViewCourseInformation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ViewCourseInformation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ViewCourseInformation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ViewCourseInformation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.ViewCourseInformation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.ViewCourseInformation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ViewCourseInformation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCourseInformation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ViewCourseInformation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ViewCourseInformation.ThemeStyle.HeaderStyle.Height = 30;
            this.ViewCourseInformation.ThemeStyle.ReadOnly = true;
            this.ViewCourseInformation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.ViewCourseInformation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ViewCourseInformation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCourseInformation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ViewCourseInformation.ThemeStyle.RowsStyle.Height = 25;
            this.ViewCourseInformation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.ViewCourseInformation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // SkillSets
            // 
            this.SkillSets.AutoSize = true;
            this.SkillSets.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillSets.Location = new System.Drawing.Point(183, 445);
            this.SkillSets.Name = "SkillSets";
            this.SkillSets.Size = new System.Drawing.Size(50, 17);
            this.SkillSets.TabIndex = 17;
            this.SkillSets.Text = "Status: ";
            // 
            // ViewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.SkillSets);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ViewCourseInformation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.YearLevel);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRecord";
            this.Load += new System.EventHandler(this.ViewRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCourseInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private System.Windows.Forms.Label SkillSets;
        private Guna.UI2.WinForms.Guna2DataGridView ViewCourseInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Program;
        private System.Windows.Forms.Label Section;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label YearLevel;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Birthdate;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label StudentID;
    }
}