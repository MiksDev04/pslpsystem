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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddRecordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteRecordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateRecordBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(19, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1008, 495);
            this.dataGridView1.TabIndex = 4;
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
            this.SearchInput.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
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
            // DeleteRecordBtn
            // 
            this.DeleteRecordBtn.Animated = true;
            this.DeleteRecordBtn.AutoRoundedCorners = true;
            this.DeleteRecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteRecordBtn.BorderRadius = 17;
            this.DeleteRecordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteRecordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteRecordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteRecordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteRecordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.DeleteRecordBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRecordBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteRecordBtn.Location = new System.Drawing.Point(932, 62);
            this.DeleteRecordBtn.Name = "DeleteRecordBtn";
            this.DeleteRecordBtn.Size = new System.Drawing.Size(92, 36);
            this.DeleteRecordBtn.TabIndex = 74;
            this.DeleteRecordBtn.Text = "Delete";
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
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 633);
            this.Controls.Add(this.UpdateRecordBtn);
            this.Controls.Add(this.DeleteRecordBtn);
            this.Controls.Add(this.AddRecordBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox SearchInput;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddRecordBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteRecordBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateRecordBtn;
    }
}