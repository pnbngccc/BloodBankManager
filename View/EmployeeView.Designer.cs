namespace BloodBankManagement.View
{
    partial class EmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            txtid = new TextBox();
            btn_print = new Guna.UI2.WinForms.Guna2Button();
            lblid = new Label();
            btndelete = new Guna.UI2.WinForms.Guna2Button();
            lbluser = new Label();
            txtrole = new Guna.UI2.WinForms.Guna2ComboBox();
            txtuser = new TextBox();
            btnedit = new Guna.UI2.WinForms.Guna2Button();
            lblpassword = new Label();
            lblrole = new Label();
            txtpassword = new TextBox();
            btncreate = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            txtsearch = new TextBox();
            btnback = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            panel3.TabIndex = 44;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(904, 22);
            label3.Name = "label3";
            label3.Size = new Size(151, 39);
            label3.TabIndex = 12;
            label3.Text = "Nhân viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 696);
            panel1.TabIndex = 45;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(txtid);
            panel5.Controls.Add(btn_print);
            panel5.Controls.Add(lblid);
            panel5.Controls.Add(btndelete);
            panel5.Controls.Add(lbluser);
            panel5.Controls.Add(txtrole);
            panel5.Controls.Add(txtuser);
            panel5.Controls.Add(btnedit);
            panel5.Controls.Add(lblpassword);
            panel5.Controls.Add(lblrole);
            panel5.Controls.Add(txtpassword);
            panel5.Controls.Add(btncreate);
            panel5.Location = new Point(72, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(682, 426);
            panel5.TabIndex = 67;
            // 
            // txtid
            // 
            txtid.Font = new Font("Calibri", 12F);
            txtid.Location = new Point(306, 104);
            txtid.Multiline = true;
            txtid.Name = "txtid";
            txtid.Size = new Size(236, 36);
            txtid.TabIndex = 3;
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.Transparent;
            btn_print.BorderColor = SystemColors.ButtonShadow;
            btn_print.BorderRadius = 15;
            btn_print.BorderThickness = 1;
            btn_print.CustomizableEdges = customizableEdges1;
            btn_print.DisabledState.BorderColor = Color.DarkGray;
            btn_print.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_print.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_print.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_print.FillColor = SystemColors.ButtonFace;
            btn_print.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_print.ForeColor = Color.Black;
            btn_print.Image = (Image)resources.GetObject("btn_print.Image");
            btn_print.Location = new Point(476, 295);
            btn_print.Name = "btn_print";
            btn_print.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_print.Size = new Size(110, 32);
            btn_print.TabIndex = 66;
            btn_print.Text = "In";
            btn_print.Click += btn_print_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Calibri", 12F);
            lblid.Location = new Point(164, 116);
            lblid.Name = "lblid";
            lblid.Size = new Size(125, 24);
            lblid.TabIndex = 2;
            lblid.Text = "Mã nhân viên";
            // 
            // btndelete
            // 
            btndelete.AutoRoundedCorners = true;
            btndelete.BackColor = Color.Transparent;
            btndelete.BorderColor = SystemColors.ButtonShadow;
            btndelete.BorderRadius = 15;
            btndelete.BorderThickness = 1;
            btndelete.CustomizableEdges = customizableEdges3;
            btndelete.DisabledState.BorderColor = Color.DarkGray;
            btndelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btndelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btndelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btndelete.FillColor = SystemColors.ButtonFace;
            btndelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndelete.ForeColor = Color.Black;
            btndelete.Image = (Image)resources.GetObject("btndelete.Image");
            btndelete.Location = new Point(360, 295);
            btndelete.Name = "btndelete";
            btndelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btndelete.Size = new Size(110, 32);
            btndelete.TabIndex = 52;
            btndelete.Text = "Xóa";
            btndelete.Click += btndelete_Click_1;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Calibri", 12F);
            lbluser.Location = new Point(164, 158);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(133, 24);
            lbluser.TabIndex = 4;
            lbluser.Text = "Tên đăng nhập";
            // 
            // txtrole
            // 
            txtrole.BackColor = Color.Transparent;
            txtrole.CustomizableEdges = customizableEdges5;
            txtrole.DrawMode = DrawMode.OwnerDrawFixed;
            txtrole.DropDownStyle = ComboBoxStyle.DropDownList;
            txtrole.FocusedColor = Color.FromArgb(94, 148, 255);
            txtrole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtrole.Font = new Font("Segoe UI", 10F);
            txtrole.ForeColor = Color.FromArgb(68, 88, 112);
            txtrole.ItemHeight = 30;
            txtrole.Items.AddRange(new object[] { "User", "Admin" });
            txtrole.Location = new Point(306, 230);
            txtrole.Name = "txtrole";
            txtrole.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtrole.Size = new Size(236, 36);
            txtrole.TabIndex = 53;
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Calibri", 12F);
            txtuser.Location = new Point(306, 146);
            txtuser.Multiline = true;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(236, 36);
            txtuser.TabIndex = 5;
            // 
            // btnedit
            // 
            btnedit.AutoRoundedCorners = true;
            btnedit.BackColor = Color.Transparent;
            btnedit.BorderColor = SystemColors.ButtonShadow;
            btnedit.BorderRadius = 15;
            btnedit.BorderThickness = 1;
            btnedit.CustomizableEdges = customizableEdges7;
            btnedit.DisabledState.BorderColor = Color.DarkGray;
            btnedit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnedit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnedit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnedit.FillColor = SystemColors.ButtonFace;
            btnedit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnedit.ForeColor = Color.Black;
            btnedit.Image = (Image)resources.GetObject("btnedit.Image");
            btnedit.Location = new Point(244, 295);
            btnedit.Name = "btnedit";
            btnedit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnedit.Size = new Size(110, 32);
            btnedit.TabIndex = 51;
            btnedit.Text = "Sửa";
            btnedit.Click += btnedit_Click_1;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Calibri", 12F);
            lblpassword.Location = new Point(164, 200);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(90, 24);
            lblpassword.TabIndex = 50;
            lblpassword.Text = "Mật khẩu";
            // 
            // lblrole
            // 
            lblrole.AutoSize = true;
            lblrole.Font = new Font("Calibri", 12F);
            lblrole.Location = new Point(164, 242);
            lblrole.Name = "lblrole";
            lblrole.Size = new Size(65, 24);
            lblrole.TabIndex = 52;
            lblrole.Text = "Vai trò";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Calibri", 12F);
            txtpassword.Location = new Point(306, 188);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(236, 36);
            txtpassword.TabIndex = 51;
            // 
            // btncreate
            // 
            btncreate.AutoRoundedCorners = true;
            btncreate.BackColor = Color.Transparent;
            btncreate.BorderColor = SystemColors.ButtonShadow;
            btncreate.BorderRadius = 15;
            btncreate.BorderThickness = 1;
            btncreate.CustomizableEdges = customizableEdges9;
            btncreate.DisabledState.BorderColor = Color.DarkGray;
            btncreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btncreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btncreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btncreate.FillColor = SystemColors.ButtonFace;
            btncreate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btncreate.ForeColor = Color.Black;
            btncreate.Image = (Image)resources.GetObject("btncreate.Image");
            btncreate.Location = new Point(128, 295);
            btncreate.Name = "btncreate";
            btncreate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btncreate.Size = new Size(110, 32);
            btncreate.TabIndex = 50;
            btncreate.Text = "Thêm";
            btncreate.Click += btncreate_Click_1;
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
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenDangNhap, MatKhau, Role });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView1.Location = new Point(6, 103);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(972, 426);
            guna2DataGridView1.TabIndex = 46;
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
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "Mật khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Vai Trò";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            // 
            // btnSearch
            // 
            btnSearch.AutoRoundedCorners = true;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BorderColor = SystemColors.ButtonShadow;
            btnSearch.BorderRadius = 15;
            btnSearch.BorderThickness = 1;
            btnSearch.CustomizableEdges = customizableEdges11;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = SystemColors.ButtonFace;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(900, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSearch.Size = new Size(78, 32);
            btnSearch.TabIndex = 48;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Calibri", 12F);
            txtsearch.Location = new Point(468, 38);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(426, 32);
            txtsearch.TabIndex = 47;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // btnback
            // 
            btnback.AutoRoundedCorners = true;
            btnback.BackColor = Color.Transparent;
            btnback.BorderColor = SystemColors.ButtonShadow;
            btnback.BorderRadius = 15;
            btnback.BorderThickness = 1;
            btnback.CustomizableEdges = customizableEdges13;
            btnback.DisabledState.BorderColor = Color.DarkGray;
            btnback.DisabledState.CustomBorderColor = Color.DarkGray;
            btnback.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnback.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnback.FillColor = SystemColors.ButtonFace;
            btnback.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnback.ForeColor = Color.Black;
            btnback.Image = (Image)resources.GetObject("btnback.Image");
            btnback.Location = new Point(900, 563);
            btnback.Name = "btnback";
            btnback.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnback.Size = new Size(78, 32);
            btnback.TabIndex = 49;
            btnback.Click += btnback_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnback);
            panel2.Controls.Add(guna2DataGridView1);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtsearch);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(758, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 696);
            panel2.TabIndex = 50;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(758, 696);
            panel4.TabIndex = 51;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1794, 776);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "EmployeeView";
            Text = "Employee";
            Load += Employee_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private TextBox txtuser;
        private Label lbluser;
        private TextBox txtid;
        private Label lblid;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button btnback;
        private Label lblrole;
        private TextBox txtpassword;
        private Label lblpassword;
        private Guna.UI2.WinForms.Guna2ComboBox txtrole;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnedit;
        private Guna.UI2.WinForms.Guna2Button btncreate;
        private Panel panel2;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btn_print;
        private Panel panel5;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn Role;
    }
}