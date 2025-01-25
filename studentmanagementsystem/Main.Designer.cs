namespace studentmanagementsystem
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.NavigationPnl = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ActivePnl = new Guna.UI2.WinForms.Guna2Panel();
            this.LogoutBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.ManageBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.SkillsBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.DepartmentBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.RecordsBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.DashboardBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.ProfileBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MainPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NavigationPnl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.MainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information System";
            // 
            // NavigationPnl
            // 
            this.NavigationPnl.BackColor = System.Drawing.Color.Transparent;
            this.NavigationPnl.Controls.Add(this.ActivePnl);
            this.NavigationPnl.Controls.Add(this.LogoutBtn);
            this.NavigationPnl.Controls.Add(this.ManageBtn);
            this.NavigationPnl.Controls.Add(this.SkillsBtn);
            this.NavigationPnl.Controls.Add(this.DepartmentBtn);
            this.NavigationPnl.Controls.Add(this.RecordsBtn);
            this.NavigationPnl.Controls.Add(this.DashboardBtn);
            this.NavigationPnl.Controls.Add(this.ProfileBtn);
            this.NavigationPnl.FillColor = System.Drawing.Color.White;
            this.NavigationPnl.Location = new System.Drawing.Point(3, 71);
            this.NavigationPnl.Name = "NavigationPnl";
            this.NavigationPnl.Radius = 10;
            this.NavigationPnl.ShadowColor = System.Drawing.Color.Black;
            this.NavigationPnl.Size = new System.Drawing.Size(212, 644);
            this.NavigationPnl.TabIndex = 2;
            // 
            // ActivePnl
            // 
            this.ActivePnl.BackColor = System.Drawing.Color.DarkGreen;
            this.ActivePnl.Location = new System.Drawing.Point(5, 129);
            this.ActivePnl.Name = "ActivePnl";
            this.ActivePnl.Size = new System.Drawing.Size(10, 51);
            this.ActivePnl.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBtn.Animated = true;
            this.LogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutBtn.FillColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LogoutBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.LogoutBtn.Image = global::studentmanagementsystem.Properties.Resources.logout;
            this.LogoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutBtn.ImageOffset = new System.Drawing.Point(15, 20);
            this.LogoutBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.LogoutBtn.IndicateFocus = true;
            this.LogoutBtn.Location = new System.Drawing.Point(3, 592);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(206, 49);
            this.LogoutBtn.TabIndex = 9;
            this.LogoutBtn.Text = "        Logout";
            this.LogoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutBtn.TextOffset = new System.Drawing.Point(0, -18);
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ManageBtn
            // 
            this.ManageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageBtn.Animated = true;
            this.ManageBtn.BackColor = System.Drawing.Color.Transparent;
            this.ManageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageBtn.FillColor = System.Drawing.Color.Transparent;
            this.ManageBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.ManageBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.ManageBtn.Image = global::studentmanagementsystem.Properties.Resources.manage;
            this.ManageBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ManageBtn.ImageOffset = new System.Drawing.Point(13, 20);
            this.ManageBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.ManageBtn.IndicateFocus = true;
            this.ManageBtn.Location = new System.Drawing.Point(3, 323);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.Size = new System.Drawing.Size(206, 49);
            this.ManageBtn.TabIndex = 8;
            this.ManageBtn.Text = "        Manage";
            this.ManageBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ManageBtn.TextOffset = new System.Drawing.Point(0, -18);
            this.ManageBtn.Visible = false;
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // SkillsBtn
            // 
            this.SkillsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillsBtn.Animated = true;
            this.SkillsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SkillsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SkillsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SkillsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SkillsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SkillsBtn.FillColor = System.Drawing.Color.Transparent;
            this.SkillsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.SkillsBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.SkillsBtn.Image = global::studentmanagementsystem.Properties.Resources.skills;
            this.SkillsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SkillsBtn.ImageOffset = new System.Drawing.Point(14, 20);
            this.SkillsBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.SkillsBtn.IndicateFocus = true;
            this.SkillsBtn.Location = new System.Drawing.Point(3, 275);
            this.SkillsBtn.Name = "SkillsBtn";
            this.SkillsBtn.Size = new System.Drawing.Size(206, 49);
            this.SkillsBtn.TabIndex = 7;
            this.SkillsBtn.Text = "        Skills";
            this.SkillsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SkillsBtn.TextOffset = new System.Drawing.Point(0, -18);
            this.SkillsBtn.Click += new System.EventHandler(this.SkillsBtn_Click);
            // 
            // DepartmentBtn
            // 
            this.DepartmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentBtn.Animated = true;
            this.DepartmentBtn.BackColor = System.Drawing.Color.Transparent;
            this.DepartmentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepartmentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepartmentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DepartmentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepartmentBtn.FillColor = System.Drawing.Color.Transparent;
            this.DepartmentBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.DepartmentBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.DepartmentBtn.Image = global::studentmanagementsystem.Properties.Resources.course;
            this.DepartmentBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DepartmentBtn.ImageOffset = new System.Drawing.Point(15, 20);
            this.DepartmentBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.DepartmentBtn.IndicateFocus = true;
            this.DepartmentBtn.Location = new System.Drawing.Point(3, 227);
            this.DepartmentBtn.Name = "DepartmentBtn";
            this.DepartmentBtn.Size = new System.Drawing.Size(206, 49);
            this.DepartmentBtn.TabIndex = 6;
            this.DepartmentBtn.Text = "        Courses";
            this.DepartmentBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DepartmentBtn.TextOffset = new System.Drawing.Point(0, -18);
            this.DepartmentBtn.Click += new System.EventHandler(this.CourseBtn_Click);
            // 
            // RecordsBtn
            // 
            this.RecordsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordsBtn.Animated = true;
            this.RecordsBtn.BackColor = System.Drawing.Color.Transparent;
            this.RecordsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RecordsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RecordsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RecordsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RecordsBtn.FillColor = System.Drawing.Color.Transparent;
            this.RecordsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.RecordsBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.RecordsBtn.Image = global::studentmanagementsystem.Properties.Resources.people;
            this.RecordsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RecordsBtn.ImageOffset = new System.Drawing.Point(10, 20);
            this.RecordsBtn.ImageSize = new System.Drawing.Size(28, 28);
            this.RecordsBtn.IndicateFocus = true;
            this.RecordsBtn.Location = new System.Drawing.Point(3, 179);
            this.RecordsBtn.Name = "RecordsBtn";
            this.RecordsBtn.Size = new System.Drawing.Size(206, 49);
            this.RecordsBtn.TabIndex = 5;
            this.RecordsBtn.Text = "      Records";
            this.RecordsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RecordsBtn.TextOffset = new System.Drawing.Point(10, -18);
            this.RecordsBtn.Click += new System.EventHandler(this.RecordsBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardBtn.Animated = true;
            this.DashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardBtn.FillColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.DashboardBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.DashboardBtn.Image = global::studentmanagementsystem.Properties.Resources.dashboard;
            this.DashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardBtn.ImageOffset = new System.Drawing.Point(15, 20);
            this.DashboardBtn.ImageSize = new System.Drawing.Size(23, 23);
            this.DashboardBtn.IndicateFocus = true;
            this.DashboardBtn.Location = new System.Drawing.Point(3, 131);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(206, 49);
            this.DashboardBtn.TabIndex = 4;
            this.DashboardBtn.Text = "        Dashboard";
            this.DashboardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardBtn.TextOffset = new System.Drawing.Point(0, -15);
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileBtn.Animated = true;
            this.ProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProfileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProfileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProfileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProfileBtn.FillColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.ProfileBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.ProfileBtn.Image = global::studentmanagementsystem.Properties.Resources.profiel;
            this.ProfileBtn.ImageOffset = new System.Drawing.Point(0, 20);
            this.ProfileBtn.ImageSize = new System.Drawing.Size(80, 80);
            this.ProfileBtn.IndicateFocus = true;
            this.ProfileBtn.Location = new System.Drawing.Point(3, 17);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(206, 112);
            this.ProfileBtn.TabIndex = 3;
            this.ProfileBtn.Text = "User";
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2Panel1.Controls.Add(this.ExitBtn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1280, 65);
            this.guna2Panel1.TabIndex = 1;
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
            this.ExitBtn.Location = new System.Drawing.Point(1234, 21);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 25);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MainPnl
            // 
            this.MainPnl.Controls.Add(this.label2);
            this.MainPnl.Location = new System.Drawing.Point(221, 79);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(1047, 633);
            this.MainPnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Content Goes Here";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 725);
            this.Controls.Add(this.MainPnl);
            this.Controls.Add(this.NavigationPnl);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.NavigationPnl.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.MainPnl.ResumeLayout(false);
            this.MainPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel NavigationPnl;
        public Guna.UI2.WinForms.Guna2TileButton ProfileBtn;
        public Guna.UI2.WinForms.Guna2TileButton RecordsBtn;
        private Guna.UI2.WinForms.Guna2TileButton DashboardBtn;
        private Guna.UI2.WinForms.Guna2TileButton LogoutBtn;
        public Guna.UI2.WinForms.Guna2TileButton ManageBtn;
        public Guna.UI2.WinForms.Guna2TileButton SkillsBtn;
        public Guna.UI2.WinForms.Guna2TileButton DepartmentBtn;
        public Guna.UI2.WinForms.Guna2Panel ActivePnl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public System.Windows.Forms.Panel MainPnl;
        private System.Windows.Forms.Label label2;
    }
}