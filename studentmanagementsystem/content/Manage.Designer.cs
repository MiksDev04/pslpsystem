namespace studentmanagementsystem.content
{
    partial class Manage
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
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddRecordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ArchiveRecordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateRecordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DataManagement_GridView = new System.Windows.Forms.DataGridView();
            this.TotalRecords = new System.Windows.Forms.Label();
            this.ViewStudentState = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RestoreStudentBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataManagement_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Animated = true;
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchBtn.BackgroundImage = global::studentmanagementsystem.Properties.Resources.search;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.BorderColor = System.Drawing.Color.Transparent;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.Transparent;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(253, 69);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(24, 24);
            this.SearchBtn.TabIndex = 70;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchInput.Animated = true;
            this.SearchInput.BackColor = System.Drawing.Color.Transparent;
            this.SearchInput.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchInput.BorderRadius = 15;
            this.SearchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchInput.DefaultText = "";
            this.SearchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchInput.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SearchInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SearchInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchInput.Location = new System.Drawing.Point(22, 65);
            this.SearchInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.PasswordChar = '\0';
            this.SearchInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.SearchInput.PlaceholderText = "Search here...";
            this.SearchInput.SelectedText = "";
            this.SearchInput.Size = new System.Drawing.Size(265, 33);
            this.SearchInput.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 72;
            this.label1.Text = "DATA MANAGEMENT";
            // 
            // AddRecordBtn
            // 
            this.AddRecordBtn.Animated = true;
            this.AddRecordBtn.AutoRoundedCorners = true;
            this.AddRecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddRecordBtn.BorderRadius = 17;
            this.AddRecordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddRecordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddRecordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddRecordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddRecordBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecordBtn.ForeColor = System.Drawing.Color.White;
            this.AddRecordBtn.Location = new System.Drawing.Point(736, 62);
            this.AddRecordBtn.Name = "AddRecordBtn";
            this.AddRecordBtn.Size = new System.Drawing.Size(92, 36);
            this.AddRecordBtn.TabIndex = 73;
            this.AddRecordBtn.Text = "Add";
            this.AddRecordBtn.Click += new System.EventHandler(this.AddRecordBtn_Click);
            // 
            // ArchiveRecordBtn
            // 
            this.ArchiveRecordBtn.Animated = true;
            this.ArchiveRecordBtn.AutoRoundedCorners = true;
            this.ArchiveRecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.ArchiveRecordBtn.BorderRadius = 17;
            this.ArchiveRecordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ArchiveRecordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ArchiveRecordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ArchiveRecordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ArchiveRecordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.ArchiveRecordBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveRecordBtn.ForeColor = System.Drawing.Color.White;
            this.ArchiveRecordBtn.Location = new System.Drawing.Point(932, 62);
            this.ArchiveRecordBtn.Name = "ArchiveRecordBtn";
            this.ArchiveRecordBtn.Size = new System.Drawing.Size(92, 36);
            this.ArchiveRecordBtn.TabIndex = 74;
            this.ArchiveRecordBtn.Text = "Archive";
            this.ArchiveRecordBtn.Click += new System.EventHandler(this.ArchiveRecordBtn_Click);
            // 
            // UpdateRecordBtn
            // 
            this.UpdateRecordBtn.Animated = true;
            this.UpdateRecordBtn.AutoRoundedCorners = true;
            this.UpdateRecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateRecordBtn.BorderRadius = 17;
            this.UpdateRecordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateRecordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateRecordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateRecordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateRecordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(196)))), ((int)(((byte)(26)))));
            this.UpdateRecordBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRecordBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateRecordBtn.Location = new System.Drawing.Point(834, 62);
            this.UpdateRecordBtn.Name = "UpdateRecordBtn";
            this.UpdateRecordBtn.Size = new System.Drawing.Size(92, 36);
            this.UpdateRecordBtn.TabIndex = 75;
            this.UpdateRecordBtn.Text = "Update";
            this.UpdateRecordBtn.Click += new System.EventHandler(this.UpdateRecordBtn_Click);
            // 
            // DataManagement_GridView
            // 
            this.DataManagement_GridView.AllowUserToOrderColumns = true;
            this.DataManagement_GridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataManagement_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataManagement_GridView.Location = new System.Drawing.Point(12, 116);
            this.DataManagement_GridView.Name = "DataManagement_GridView";
            this.DataManagement_GridView.Size = new System.Drawing.Size(1023, 461);
            this.DataManagement_GridView.TabIndex = 77;
            // 
            // TotalRecords
            // 
            this.TotalRecords.AutoSize = true;
            this.TotalRecords.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRecords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalRecords.Location = new System.Drawing.Point(755, 588);
            this.TotalRecords.Name = "TotalRecords";
            this.TotalRecords.Size = new System.Drawing.Size(73, 30);
            this.TotalRecords.TabIndex = 78;
            this.TotalRecords.Text = "Total: ";
            // 
            // ViewStudentState
            // 
            this.ViewStudentState.BackColor = System.Drawing.Color.Transparent;
            this.ViewStudentState.BorderRadius = 7;
            this.ViewStudentState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ViewStudentState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewStudentState.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewStudentState.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewStudentState.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewStudentState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ViewStudentState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewStudentState.ItemHeight = 30;
            this.ViewStudentState.Items.AddRange(new object[] {
            "Active",
            "Archived"});
            this.ViewStudentState.Location = new System.Drawing.Point(12, 588);
            this.ViewStudentState.Name = "ViewStudentState";
            this.ViewStudentState.Size = new System.Drawing.Size(229, 36);
            this.ViewStudentState.TabIndex = 175;
            this.ViewStudentState.SelectedValueChanged += new System.EventHandler(this.ViewStudentState_SelectedValueChanged);
            // 
            // RestoreStudentBtn
            // 
            this.RestoreStudentBtn.Animated = true;
            this.RestoreStudentBtn.AutoRoundedCorners = true;
            this.RestoreStudentBtn.BackColor = System.Drawing.Color.Transparent;
            this.RestoreStudentBtn.BorderRadius = 17;
            this.RestoreStudentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RestoreStudentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RestoreStudentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RestoreStudentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RestoreStudentBtn.FillColor = System.Drawing.Color.Gray;
            this.RestoreStudentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreStudentBtn.ForeColor = System.Drawing.Color.White;
            this.RestoreStudentBtn.Location = new System.Drawing.Point(260, 588);
            this.RestoreStudentBtn.Name = "RestoreStudentBtn";
            this.RestoreStudentBtn.Size = new System.Drawing.Size(127, 36);
            this.RestoreStudentBtn.TabIndex = 176;
            this.RestoreStudentBtn.Text = "Restore";
            this.RestoreStudentBtn.Visible = false;
            this.RestoreStudentBtn.Click += new System.EventHandler(this.RestoreStudentBtn_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 633);
            this.Controls.Add(this.RestoreStudentBtn);
            this.Controls.Add(this.ViewStudentState);
            this.Controls.Add(this.TotalRecords);
            this.Controls.Add(this.DataManagement_GridView);
            this.Controls.Add(this.UpdateRecordBtn);
            this.Controls.Add(this.ArchiveRecordBtn);
            this.Controls.Add(this.AddRecordBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataManagement_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox SearchInput;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddRecordBtn;
        private Guna.UI2.WinForms.Guna2Button ArchiveRecordBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateRecordBtn;
        public System.Windows.Forms.DataGridView DataManagement_GridView;
        private System.Windows.Forms.Label TotalRecords;
        private Guna.UI2.WinForms.Guna2ComboBox ViewStudentState;
        private Guna.UI2.WinForms.Guna2Button RestoreStudentBtn;
    }
}