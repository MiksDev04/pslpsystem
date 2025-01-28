namespace studentmanagementsystem.AddUpdateRecords
{
    partial class SkillsForm
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
            this.AddUpdateProgressBar = new System.Windows.Forms.ProgressBar();
            this.NextToSuccessBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SkillSets = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddUpdateProgressBar
            // 
            this.AddUpdateProgressBar.Location = new System.Drawing.Point(37, 457);
            this.AddUpdateProgressBar.Name = "AddUpdateProgressBar";
            this.AddUpdateProgressBar.Size = new System.Drawing.Size(598, 10);
            this.AddUpdateProgressBar.TabIndex = 196;
            // 
            // NextToSuccessBtn
            // 
            this.NextToSuccessBtn.Animated = true;
            this.NextToSuccessBtn.AutoRoundedCorners = true;
            this.NextToSuccessBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextToSuccessBtn.BorderColor = System.Drawing.SystemColors.Highlight;
            this.NextToSuccessBtn.BorderRadius = 17;
            this.NextToSuccessBtn.BorderThickness = 2;
            this.NextToSuccessBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextToSuccessBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextToSuccessBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextToSuccessBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextToSuccessBtn.FillColor = System.Drawing.SystemColors.Control;
            this.NextToSuccessBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.NextToSuccessBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NextToSuccessBtn.Location = new System.Drawing.Point(665, 444);
            this.NextToSuccessBtn.Name = "NextToSuccessBtn";
            this.NextToSuccessBtn.Size = new System.Drawing.Size(92, 36);
            this.NextToSuccessBtn.TabIndex = 172;
            this.NextToSuccessBtn.Text = "Submit";
            this.NextToSuccessBtn.Click += new System.EventHandler(this.NextToSuccessBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Animated = true;
            this.CancelBtn.AutoRoundedCorners = true;
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BorderRadius = 17;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(776, 444);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(92, 36);
            this.CancelBtn.TabIndex = 171;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-88, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 14);
            this.label2.TabIndex = 170;
            this.label2.Text = "ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(33, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 30);
            this.label12.TabIndex = 141;
            this.label12.Text = "Skills Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 50);
            this.panel1.TabIndex = 195;
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
            this.ExitBtn.Location = new System.Drawing.Point(864, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 25);
            this.ExitBtn.TabIndex = 169;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 198;
            this.label1.Text = "Skill Sets";
            // 
            // SkillSets
            // 
            this.SkillSets.BorderRadius = 20;
            this.SkillSets.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SkillSets.DefaultText = "";
            this.SkillSets.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SkillSets.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SkillSets.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SkillSets.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SkillSets.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SkillSets.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SkillSets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SkillSets.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SkillSets.Location = new System.Drawing.Point(58, 142);
            this.SkillSets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SkillSets.Name = "SkillSets";
            this.SkillSets.PasswordChar = '\0';
            this.SkillSets.PlaceholderText = "Ex. dancing";
            this.SkillSets.SelectedText = "";
            this.SkillSets.Size = new System.Drawing.Size(790, 260);
            this.SkillSets.TabIndex = 197;
            this.SkillSets.TextOffset = new System.Drawing.Point(10, -100);
            // 
            // SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SkillSets);
            this.Controls.Add(this.AddUpdateProgressBar);
            this.Controls.Add(this.NextToSuccessBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SkillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skills";
            this.Load += new System.EventHandler(this.Skills_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar AddUpdateProgressBar;
        private Guna.UI2.WinForms.Guna2Button NextToSuccessBtn;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox SkillSets;
    }
}