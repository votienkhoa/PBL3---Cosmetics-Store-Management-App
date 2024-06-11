namespace PBL3___Cosmetics_Store_Management_App.View
{
    partial class frmStaffView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Searchtxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dtgv_staff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_detail_button = new System.Windows.Forms.DataGridViewImageColumn();
            this.Staff_edit_button = new System.Windows.Forms.DataGridViewImageColumn();
            this.Staff_dele_button = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Staff List";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(52, 143);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(988, 27);
            this.guna2Separator1.TabIndex = 6;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.detail;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 198;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.edit;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 197;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.FillWeight = 50F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.delete;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 198;
            // 
            // Searchtxtbox
            // 
            this.Searchtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchtxtbox.AutoRoundedCorners = true;
            this.Searchtxtbox.BorderRadius = 22;
            this.Searchtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxtbox.DefaultText = "";
            this.Searchtxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchtxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchtxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxtbox.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxtbox.IconLeft = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.search_green;
            this.Searchtxtbox.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.Searchtxtbox.Location = new System.Drawing.Point(677, 96);
            this.Searchtxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Searchtxtbox.Name = "Searchtxtbox";
            this.Searchtxtbox.PasswordChar = '\0';
            this.Searchtxtbox.PlaceholderText = "Search Here";
            this.Searchtxtbox.SelectedText = "";
            this.Searchtxtbox.Size = new System.Drawing.Size(320, 46);
            this.Searchtxtbox.TabIndex = 9;
            this.Searchtxtbox.TextOffset = new System.Drawing.Point(10, 0);
            this.Searchtxtbox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.plus_green;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(68, 72);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(72, 70);
            this.guna2ImageButton1.TabIndex = 5;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // dtgv_staff
            // 
            this.dtgv_staff.AllowUserToAddRows = false;
            this.dtgv_staff.AllowUserToDeleteRows = false;
            this.dtgv_staff.AllowUserToResizeColumns = false;
            this.dtgv_staff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_staff.ColumnHeadersHeight = 40;
            this.dtgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Staff,
            this.Staff_Name,
            this.Staff_role,
            this.Staff_detail_button,
            this.Staff_edit_button,
            this.Staff_dele_button});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_staff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgv_staff.Location = new System.Drawing.Point(52, 176);
            this.dtgv_staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_staff.Name = "dtgv_staff";
            this.dtgv_staff.ReadOnly = true;
            this.dtgv_staff.RowHeadersVisible = false;
            this.dtgv_staff.RowHeadersWidth = 62;
            this.dtgv_staff.RowTemplate.Height = 30;
            this.dtgv_staff.Size = new System.Drawing.Size(988, 469);
            this.dtgv_staff.TabIndex = 10;
            this.dtgv_staff.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dtgv_staff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_staff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_staff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_staff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_staff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_staff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_staff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgv_staff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dtgv_staff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_staff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_staff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_staff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_staff.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgv_staff.ThemeStyle.ReadOnly = true;
            this.dtgv_staff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_staff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_staff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_staff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_staff.ThemeStyle.RowsStyle.Height = 30;
            this.dtgv_staff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgv_staff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_staff_CellContentClick);
            this.dtgv_staff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_staff_CellFormatting);
            // 
            // ID_Staff
            // 
            this.ID_Staff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Staff.DataPropertyName = "staff_id";
            this.ID_Staff.Frozen = true;
            this.ID_Staff.HeaderText = "ID";
            this.ID_Staff.MinimumWidth = 8;
            this.ID_Staff.Name = "ID_Staff";
            this.ID_Staff.ReadOnly = true;
            this.ID_Staff.Width = 200;
            // 
            // Staff_Name
            // 
            this.Staff_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Staff_Name.DataPropertyName = "staff_name";
            this.Staff_Name.HeaderText = "Name";
            this.Staff_Name.MinimumWidth = 8;
            this.Staff_Name.Name = "Staff_Name";
            this.Staff_Name.ReadOnly = true;
            // 
            // Staff_role
            // 
            this.Staff_role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Staff_role.DataPropertyName = "staff_role";
            this.Staff_role.HeaderText = "Role";
            this.Staff_role.MinimumWidth = 8;
            this.Staff_role.Name = "Staff_role";
            this.Staff_role.ReadOnly = true;
            this.Staff_role.Width = 200;
            // 
            // Staff_detail_button
            // 
            this.Staff_detail_button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Staff_detail_button.FillWeight = 50F;
            this.Staff_detail_button.HeaderText = "";
            this.Staff_detail_button.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.detail;
            this.Staff_detail_button.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Staff_detail_button.MinimumWidth = 8;
            this.Staff_detail_button.Name = "Staff_detail_button";
            this.Staff_detail_button.ReadOnly = true;
            this.Staff_detail_button.Width = 40;
            // 
            // Staff_edit_button
            // 
            this.Staff_edit_button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Staff_edit_button.FillWeight = 50F;
            this.Staff_edit_button.HeaderText = "";
            this.Staff_edit_button.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.edit;
            this.Staff_edit_button.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Staff_edit_button.MinimumWidth = 8;
            this.Staff_edit_button.Name = "Staff_edit_button";
            this.Staff_edit_button.ReadOnly = true;
            this.Staff_edit_button.Width = 40;
            // 
            // Staff_dele_button
            // 
            this.Staff_dele_button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Staff_dele_button.FillWeight = 50F;
            this.Staff_dele_button.HeaderText = "";
            this.Staff_dele_button.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.delete;
            this.Staff_dele_button.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Staff_dele_button.MinimumWidth = 8;
            this.Staff_dele_button.Name = "Staff_dele_button";
            this.Staff_dele_button.ReadOnly = true;
            this.Staff_dele_button.Width = 40;
            // 
            // frmStaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1091, 682);
            this.Controls.Add(this.dtgv_staff);
            this.Controls.Add(this.Searchtxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaffView";
            this.Text = "frmStaffView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox Searchtxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_role;
        private System.Windows.Forms.DataGridViewImageColumn Staff_detail_button;
        private System.Windows.Forms.DataGridViewImageColumn Staff_edit_button;
        private System.Windows.Forms.DataGridViewImageColumn Staff_dele_button;
    }
}