namespace BloodBankManagement.View
{
    partial class DonateBloodView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            txtgroup = new ComboBox();
            label14 = new Label();
            txtname = new TextBox();
            label10 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            NhomMau = new DataGridViewTextBoxColumn();
            SoLuongMau = new DataGridViewTextBoxColumn();
            guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            MaNguoiHien = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            Tuoi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1794, 80);
            panel3.TabIndex = 29;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(731, 18);
            label3.Name = "label3";
            label3.Size = new Size(340, 39);
            label3.TabIndex = 12;
            label3.Text = "Quá trình hiến tặng máu";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(guna2Button2);
            panel1.Controls.Add(txtgroup);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1794, 115);
            panel1.TabIndex = 37;
            panel1.Paint += panel1_Paint;
            // 
            // guna2Button2
            // 
            guna2Button2.AutoRoundedCorners = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = SystemColors.ButtonShadow;
            guna2Button2.BorderRadius = 15;
            guna2Button2.BorderThickness = 1;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = SystemColors.ButtonFace;
            guna2Button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(1261, 38);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(186, 32);
            guna2Button2.TabIndex = 27;
            guna2Button2.Text = "Đóng góp";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // txtgroup
            // 
            txtgroup.FlatStyle = FlatStyle.System;
            txtgroup.Font = new Font("Calibri", 12F);
            txtgroup.FormattingEnabled = true;
            txtgroup.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            txtgroup.Location = new Point(968, 38);
            txtgroup.Name = "txtgroup";
            txtgroup.Size = new Size(236, 32);
            txtgroup.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 12F);
            label14.Location = new Point(813, 46);
            label14.Name = "label14";
            label14.Size = new Size(104, 24);
            label14.TabIndex = 10;
            label14.Text = "Nhóm Máu";
            // 
            // txtname
            // 
            txtname.Font = new Font("Calibri", 12F);
            txtname.Location = new Point(527, 38);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(236, 32);
            txtname.TabIndex = 3;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(372, 46);
            label10.Name = "label10";
            label10.Size = new Size(92, 24);
            label10.TabIndex = 2;
            label10.Text = "Họ Và Tên";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.IndianRed;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { NhomMau, SoLuongMau });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView1.Location = new Point(151, 64);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 58;
            guna2DataGridView1.Size = new Size(357, 334);
            guna2DataGridView1.TabIndex = 45;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.IndianRed;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.Coral;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = SystemColors.ActiveCaption;
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            guna2DataGridView1.SelectionChanged += guna2DataGridView1_SelectionChanged;
            // 
            // NhomMau
            // 
            NhomMau.DataPropertyName = "NhomMau";
            NhomMau.FillWeight = 95.95111F;
            NhomMau.HeaderText = "Nhóm máu";
            NhomMau.MinimumWidth = 6;
            NhomMau.Name = "NhomMau";
            // 
            // SoLuongMau
            // 
            SoLuongMau.DataPropertyName = "SoLuongMau";
            SoLuongMau.FillWeight = 95.95111F;
            SoLuongMau.HeaderText = "Số Lượng Máu";
            SoLuongMau.MinimumWidth = 6;
            SoLuongMau.Name = "SoLuongMau";
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.IndianRed;
            dataGridViewCellStyle5.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView2.ColumnHeadersHeight = 30;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.Columns.AddRange(new DataGridViewColumn[] { MaNguoiHien, HoVaTen, Tuoi, GioiTinh, SoDienThoai, DiaChi, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView2.Dock = DockStyle.Fill;
            guna2DataGridView2.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView2.Location = new Point(0, 0);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.RowHeadersVisible = false;
            guna2DataGridView2.RowHeadersWidth = 51;
            guna2DataGridView2.Size = new Size(1060, 334);
            guna2DataGridView2.TabIndex = 46;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.IndianRed;
            guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView2.ThemeStyle.ReadOnly = false;
            guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView2.ThemeStyle.RowsStyle.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.Coral;
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = SystemColors.ActiveCaption;
            guna2DataGridView2.CellContentClick += guna2DataGridView2_CellContentClick;
            guna2DataGridView2.SelectionChanged += guna2DataGridView2_SelectionChanged;
            // 
            // MaNguoiHien
            // 
            MaNguoiHien.DataPropertyName = "MaNguoiHien";
            MaNguoiHien.HeaderText = "Mã người hiến";
            MaNguoiHien.MinimumWidth = 6;
            MaNguoiHien.Name = "MaNguoiHien";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // Tuoi
            // 
            Tuoi.DataPropertyName = "Tuoi";
            Tuoi.HeaderText = "Tuổi";
            Tuoi.MinimumWidth = 6;
            Tuoi.Name = "Tuoi";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "NhomMau";
            dataGridViewTextBoxColumn2.HeaderText = "Nhóm máu";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(439, 24);
            label1.Name = "label1";
            label1.Size = new Size(306, 39);
            label1.TabIndex = 47;
            label1.Text = "Danh sách người hiến";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(234, 22);
            label2.Name = "label2";
            label2.Size = new Size(174, 39);
            label2.TabIndex = 48;
            label2.Text = "Dự trữ máu";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2DataGridView1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 581);
            panel2.TabIndex = 49;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(541, 195);
            panel4.Name = "panel4";
            panel4.Size = new Size(1253, 581);
            panel4.TabIndex = 50;
            // 
            // panel6
            // 
            panel6.Controls.Add(guna2DataGridView2);
            panel6.Location = new Point(65, 64);
            panel6.Name = "panel6";
            panel6.Size = new Size(1060, 334);
            panel6.TabIndex = 48;
            // 
            // DonateBloodView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1794, 776);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "DonateBloodView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DonateBloodView";
            Load += DonateBloodView_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private ComboBox txtgroup;
        private Label label14;
        private TextBox txtname;
        private Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn NhomMau;
        private DataGridViewTextBoxColumn SoLuongMau;
        private DataGridViewTextBoxColumn MaNguoiHien;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
    }
}