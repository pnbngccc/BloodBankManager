namespace BloodBankManagement.View
{
    partial class PatientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            panel3 = new Panel();
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            panel1 = new Panel();
            btn_print = new Guna.UI2.WinForms.Guna2Button();
            label9 = new Label();
            btndelete = new Guna.UI2.WinForms.Guna2Button();
            txtid = new TextBox();
            label2 = new Label();
            label10 = new Label();
            btnedit = new Guna.UI2.WinForms.Guna2Button();
            txtname = new TextBox();
            txthopital = new TextBox();
            label11 = new Label();
            btncreate = new Guna.UI2.WinForms.Guna2Button();
            txtage = new TextBox();
            txtgender = new ComboBox();
            label12 = new Label();
            txtgroup = new ComboBox();
            label13 = new Label();
            label15 = new Label();
            txtphone = new TextBox();
            txtaddress = new TextBox();
            label14 = new Label();
            splitContainer2 = new SplitContainer();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            txtsearch = new TextBox();
            btnback = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            MaBenhNhan = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            Tuoi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            NhomMau = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            BenhVien = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(867, 18);
            label3.Name = "label3";
            label3.Size = new Size(163, 39);
            label3.TabIndex = 12;
            label3.Text = "Bệnh Nhân";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1794, 70);
            panel3.TabIndex = 27;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 70);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint_4;
            splitContainer1.Size = new Size(1794, 706);
            splitContainer1.SplitterDistance = 619;
            splitContainer1.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(621, 706);
            panel4.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_print);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btndelete);
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnedit);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(txthopital);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btncreate);
            panel1.Controls.Add(txtage);
            panel1.Controls.Add(txtgender);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtgroup);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtphone);
            panel1.Controls.Add(txtaddress);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(0, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 447);
            panel1.TabIndex = 61;
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
            btn_print.Location = new Point(387, 370);
            btn_print.Name = "btn_print";
            btn_print.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_print.Size = new Size(110, 32);
            btn_print.TabIndex = 61;
            btn_print.Text = "In";
            btn_print.Click += btn_print_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(80, 57);
            label9.Name = "label9";
            label9.Size = new Size(135, 24);
            label9.TabIndex = 39;
            label9.Text = "Mã Bệnh Nhân";
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
            btndelete.Location = new Point(271, 370);
            btndelete.Name = "btndelete";
            btndelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btndelete.Size = new Size(110, 32);
            btndelete.TabIndex = 60;
            btndelete.Text = "Xóa";
            btndelete.Click += btndelete_Click;
            // 
            // txtid
            // 
            txtid.Font = new Font("Calibri", 12F);
            txtid.Location = new Point(222, 49);
            txtid.Multiline = true;
            txtid.Name = "txtid";
            txtid.Size = new Size(236, 32);
            txtid.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(80, 324);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 54;
            label2.Text = "Bệnh Viện";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(80, 95);
            label10.Name = "label10";
            label10.Size = new Size(92, 24);
            label10.TabIndex = 41;
            label10.Text = "Họ Và Tên";
            // 
            // btnedit
            // 
            btnedit.AutoRoundedCorners = true;
            btnedit.BackColor = Color.Transparent;
            btnedit.BorderColor = SystemColors.ButtonShadow;
            btnedit.BorderRadius = 15;
            btnedit.BorderThickness = 1;
            btnedit.CustomizableEdges = customizableEdges5;
            btnedit.DisabledState.BorderColor = Color.DarkGray;
            btnedit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnedit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnedit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnedit.FillColor = SystemColors.ButtonFace;
            btnedit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnedit.ForeColor = Color.Black;
            btnedit.Image = (Image)resources.GetObject("btnedit.Image");
            btnedit.Location = new Point(155, 370);
            btnedit.Name = "btnedit";
            btnedit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnedit.Size = new Size(110, 32);
            btnedit.TabIndex = 59;
            btnedit.Text = "Sửa";
            btnedit.Click += btnedit_Click;
            // 
            // txtname
            // 
            txtname.Font = new Font("Calibri", 12F);
            txtname.Location = new Point(222, 87);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(236, 32);
            txtname.TabIndex = 42;
            // 
            // txthopital
            // 
            txthopital.Font = new Font("Calibri", 12F);
            txthopital.Location = new Point(222, 316);
            txthopital.Multiline = true;
            txthopital.Name = "txthopital";
            txthopital.Size = new Size(236, 32);
            txthopital.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F);
            label11.Location = new Point(80, 133);
            label11.Name = "label11";
            label11.Size = new Size(46, 24);
            label11.TabIndex = 43;
            label11.Text = "Tuổi";
            // 
            // btncreate
            // 
            btncreate.AutoRoundedCorners = true;
            btncreate.BackColor = Color.Transparent;
            btncreate.BorderColor = SystemColors.ButtonShadow;
            btncreate.BorderRadius = 15;
            btncreate.BorderThickness = 1;
            btncreate.CustomizableEdges = customizableEdges7;
            btncreate.DisabledState.BorderColor = Color.DarkGray;
            btncreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btncreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btncreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btncreate.FillColor = SystemColors.ButtonFace;
            btncreate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btncreate.ForeColor = Color.Black;
            btncreate.Image = (Image)resources.GetObject("btncreate.Image");
            btncreate.Location = new Point(39, 370);
            btncreate.Name = "btncreate";
            btncreate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btncreate.Size = new Size(110, 32);
            btncreate.TabIndex = 58;
            btncreate.Text = "Thêm";
            btncreate.Click += btncreate_Click_1;
            // 
            // txtage
            // 
            txtage.Font = new Font("Calibri", 12F);
            txtage.Location = new Point(222, 125);
            txtage.Multiline = true;
            txtage.Name = "txtage";
            txtage.Size = new Size(236, 32);
            txtage.TabIndex = 44;
            // 
            // txtgender
            // 
            txtgender.Font = new Font("Calibri", 12F);
            txtgender.FormattingEnabled = true;
            txtgender.Items.AddRange(new object[] { "Nam", "Nữ" });
            txtgender.Location = new Point(222, 163);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(236, 32);
            txtgender.TabIndex = 52;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F);
            label12.Location = new Point(80, 171);
            label12.Name = "label12";
            label12.Size = new Size(87, 24);
            label12.TabIndex = 45;
            label12.Text = "Giới Tính";
            // 
            // txtgroup
            // 
            txtgroup.Font = new Font("Calibri", 12F);
            txtgroup.FormattingEnabled = true;
            txtgroup.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            txtgroup.Location = new Point(222, 239);
            txtgroup.Name = "txtgroup";
            txtgroup.Size = new Size(236, 32);
            txtgroup.TabIndex = 51;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F);
            label13.Location = new Point(80, 209);
            label13.Name = "label13";
            label13.Size = new Size(125, 24);
            label13.TabIndex = 46;
            label13.Text = "Số Điện Thoại";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 12F);
            label15.Location = new Point(80, 285);
            label15.Name = "label15";
            label15.Size = new Size(69, 24);
            label15.TabIndex = 50;
            label15.Text = "Địa Chỉ";
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Calibri", 12F);
            txtphone.Location = new Point(222, 201);
            txtphone.Multiline = true;
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(236, 32);
            txtphone.TabIndex = 47;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Calibri", 12F);
            txtaddress.Location = new Point(222, 277);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(236, 32);
            txtaddress.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 12F);
            label14.Location = new Point(80, 247);
            label14.Name = "label14";
            label14.Size = new Size(104, 24);
            label14.TabIndex = 48;
            label14.Text = "Nhóm Máu";
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(3, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(guna2Button4);
            splitContainer2.Panel1.Controls.Add(txtsearch);
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnback);
            splitContainer2.Panel2.Controls.Add(guna2DataGridView1);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint;
            splitContainer2.Size = new Size(1168, 703);
            splitContainer2.SplitterDistance = 142;
            splitContainer2.TabIndex = 58;
            splitContainer2.SplitterMoved += splitContainer2_SplitterMoved;
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Button4.AutoRoundedCorners = true;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderColor = SystemColors.ButtonShadow;
            guna2Button4.BorderRadius = 15;
            guna2Button4.BorderThickness = 1;
            guna2Button4.CustomizableEdges = customizableEdges9;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = SystemColors.ButtonFace;
            guna2Button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
            guna2Button4.Location = new Point(1044, 79);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button4.Size = new Size(96, 32);
            guna2Button4.TabIndex = 56;
            guna2Button4.Click += guna2Button4_Click_1;
            // 
            // txtsearch
            // 
            txtsearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtsearch.Font = new Font("Calibri", 12F);
            txtsearch.Location = new Point(701, 79);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(355, 32);
            txtsearch.TabIndex = 55;
            // 
            // btnback
            // 
            btnback.AutoRoundedCorners = true;
            btnback.BackColor = Color.Transparent;
            btnback.BorderColor = SystemColors.ButtonShadow;
            btnback.BorderRadius = 15;
            btnback.BorderThickness = 1;
            btnback.CustomizableEdges = customizableEdges11;
            btnback.DisabledState.BorderColor = Color.DarkGray;
            btnback.DisabledState.CustomBorderColor = Color.DarkGray;
            btnback.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnback.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnback.FillColor = SystemColors.ButtonFace;
            btnback.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnback.ForeColor = Color.Black;
            btnback.Image = (Image)resources.GetObject("btnback.Image");
            btnback.Location = new Point(1044, 488);
            btnback.Name = "btnback";
            btnback.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnback.Size = new Size(78, 32);
            btnback.TabIndex = 57;
            btnback.Click += btnback_Click_1;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaBenhNhan, HoVaTen, Tuoi, GioiTinh, SoDienThoai, NhomMau, DiaChi, BenhVien });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView1.Location = new Point(3, 3);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 58;
            guna2DataGridView1.Size = new Size(1162, 447);
            guna2DataGridView1.TabIndex = 12;
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
            // MaBenhNhan
            // 
            MaBenhNhan.DataPropertyName = "MaBenhNhan";
            MaBenhNhan.FillWeight = 115.508041F;
            MaBenhNhan.HeaderText = "Mã bệnh nhân";
            MaBenhNhan.MinimumWidth = 6;
            MaBenhNhan.Name = "MaBenhNhan";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 113.066109F;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // Tuoi
            // 
            Tuoi.DataPropertyName = "Tuoi";
            Tuoi.FillWeight = 65.76358F;
            Tuoi.HeaderText = "Tuổi";
            Tuoi.MinimumWidth = 6;
            Tuoi.Name = "Tuoi";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.FillWeight = 113.0006F;
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.FillWeight = 129.291229F;
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // NhomMau
            // 
            NhomMau.DataPropertyName = "NhomMau";
            NhomMau.FillWeight = 87.93656F;
            NhomMau.HeaderText = "Nhóm máu";
            NhomMau.MinimumWidth = 6;
            NhomMau.Name = "NhomMau";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 73.6714554F;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // BenhVien
            // 
            BenhVien.DataPropertyName = "BenhVien";
            BenhVien.FillWeight = 101.762459F;
            BenhVien.HeaderText = "Bệnh viện";
            BenhVien.MinimumWidth = 6;
            BenhVien.Name = "BenhVien";
            // 
            // PatientView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1794, 776);
            Controls.Add(splitContainer1);
            Controls.Add(panel3);
            Name = "PatientView";
            Text = "PatientView";
            Load += PatientView_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Panel panel3;
        private SplitContainer splitContainer1;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button btnback;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnedit;
        private TextBox txthopital;
        private Guna.UI2.WinForms.Guna2Button btncreate;
        private ComboBox txtgender;
        private ComboBox txtgroup;
        private Label label15;
        private TextBox txtaddress;
        private Label label14;
        private TextBox txtphone;
        private Label label13;
        private Label label12;
        private TextBox txtage;
        private Label label11;
        private TextBox txtname;
        private Label label10;
        private TextBox txtid;
        private Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn MaBenhNhan;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn NhomMau;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn BenhVien;
        private SplitContainer splitContainer2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_print;
    }
}