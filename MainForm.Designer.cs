namespace BloodBankManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            menu_donor = new ToolStripMenuItem();
            menu_sys_logout = new ToolStripMenuItem();
            menu_employee = new ToolStripMenuItem();
            menu_donate = new ToolStripMenuItem();
            menu_patient = new ToolStripMenuItem();
            menu_bloodstock = new ToolStripMenuItem();
            menu_bloodtransfer = new ToolStripMenuItem();
            menu_dashboard = new ToolStripMenuItem();
            menu_sys_login = new ToolStripMenuItem();
            panel5 = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.IndianRed;
            menuStrip1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_donor, menu_employee, menu_donate, menu_patient, menu_bloodstock, menu_bloodtransfer, menu_dashboard, menu_sys_login });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1794, 60);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_donor
            // 
            menu_donor.DropDownItems.AddRange(new ToolStripItem[] { menu_sys_logout });
            menu_donor.ForeColor = Color.White;
            menu_donor.Image = (Image)resources.GetObject("menu_donor.Image");
            menu_donor.Name = "menu_donor";
            menu_donor.Size = new Size(184, 56);
            menu_donor.Text = "Người Hiến Tặng";
            menu_donor.Click += ngườiHiếnTặngToolStripMenuItem_Click;
            // 
            // menu_sys_logout
            // 
            menu_sys_logout.Name = "menu_sys_logout";
            menu_sys_logout.Size = new Size(179, 28);
            menu_sys_logout.Text = "Đăng xuất";
            menu_sys_logout.Click += menu_sys_logout_Click;
            // 
            // menu_employee
            // 
            menu_employee.ForeColor = Color.White;
            menu_employee.Image = (Image)resources.GetObject("menu_employee.Image");
            menu_employee.Name = "menu_employee";
            menu_employee.Size = new Size(129, 56);
            menu_employee.Text = "Nhân viên";
            menu_employee.Click += menu_employee_Click;
            // 
            // menu_donate
            // 
            menu_donate.ForeColor = Color.White;
            menu_donate.Image = (Image)resources.GetObject("menu_donate.Image");
            menu_donate.Name = "menu_donate";
            menu_donate.Size = new Size(167, 56);
            menu_donate.Text = "Hiến tặng máu";
            menu_donate.Click += hiếnTặngMáuToolStripMenuItem_Click;
            // 
            // menu_patient
            // 
            menu_patient.ForeColor = Color.White;
            menu_patient.Image = (Image)resources.GetObject("menu_patient.Image");
            menu_patient.Name = "menu_patient";
            menu_patient.Size = new Size(137, 56);
            menu_patient.Text = "Bệnh Nhân";
            menu_patient.Click += menu_patient_Click;
            // 
            // menu_bloodstock
            // 
            menu_bloodstock.ForeColor = Color.White;
            menu_bloodstock.Image = (Image)resources.GetObject("menu_bloodstock.Image");
            menu_bloodstock.Name = "menu_bloodstock";
            menu_bloodstock.Size = new Size(147, 56);
            menu_bloodstock.Text = "Dự Trữ Máu";
            menu_bloodstock.Click += menu_bloodstock_Click;
            // 
            // menu_bloodtransfer
            // 
            menu_bloodtransfer.ForeColor = Color.White;
            menu_bloodtransfer.Image = (Image)resources.GetObject("menu_bloodtransfer.Image");
            menu_bloodtransfer.Name = "menu_bloodtransfer";
            menu_bloodtransfer.Size = new Size(194, 56);
            menu_bloodtransfer.Text = "Chuyển Giao Máu";
            menu_bloodtransfer.Click += menu_bloodtransfer_Click;
            // 
            // menu_dashboard
            // 
            menu_dashboard.ForeColor = Color.White;
            menu_dashboard.Image = (Image)resources.GetObject("menu_dashboard.Image");
            menu_dashboard.Name = "menu_dashboard";
            menu_dashboard.Size = new Size(136, 56);
            menu_dashboard.Text = "DashBoard";
            menu_dashboard.Click += menu_dashboard_Click;
            // 
            // menu_sys_login
            // 
            menu_sys_login.ForeColor = Color.White;
            menu_sys_login.Image = Properties.Resources.icons8_login_35;
            menu_sys_login.Name = "menu_sys_login";
            menu_sys_login.Size = new Size(135, 56);
            menu_sys_login.Text = "Đăng nhập";
            menu_sys_login.Click += menu_sys_login_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 701);
            panel5.Name = "panel5";
            panel5.Size = new Size(1794, 75);
            panel5.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(821, 14);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 13;
            label1.Text = "© Bản quyền thuộc về nhóm 4";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1794, 776);
            Controls.Add(panel5);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_sys_login;
        private Panel panel5;
        private Label label1;
        private ToolStripMenuItem menu_employee;
        private ToolStripMenuItem menu_donor;
        private ToolStripMenuItem menu_sys_logout;
        private ToolStripMenuItem menu_donate;
        private ToolStripMenuItem menu_patient;
        private ToolStripMenuItem menu_bloodstock;
        private ToolStripMenuItem menu_bloodtransfer;
        private ToolStripMenuItem menu_dashboard;
    }
}