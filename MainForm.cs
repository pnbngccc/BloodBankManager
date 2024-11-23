using BloodBankManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement
{
    public partial class MainForm : Form
    {
        public bool isLoggedIn = false; // Biến theo dõi trạng thái đăng nhập
        public string role = "";
        public MainForm()
        {
            InitializeComponent();
            UpdateMenuItems(); // Cập nhật giao diện ngay khi khởi tạo
            SetMenuItemsEnabled(false); // Mặc định các menu mờ đi
            this.IsMdiContainer= true;
            

        }
       
      
        private void UpdateMenuItems()
        {
            // Hiển thị hoặc ẩn menu đăng nhập và đăng xuất dựa trên trạng thái đăng nhập
            menu_sys_login.Visible = !isLoggedIn;
            menu_sys_logout.Visible = isLoggedIn;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ShowMainForm()
        {
            this.Show();
        }
        private void SetMenuItemsEnabled(bool enabled)
        {
            menu_donor.Enabled = enabled; // Bật/tắt menu tài khoản
            menu_bloodstock.Enabled = enabled;
            menu_patient.Enabled = enabled;
            menu_employee.Enabled = enabled;
            menu_donate.Enabled = enabled;
            menu_bloodtransfer.Enabled = enabled;
            menu_dashboard.Enabled = enabled;



        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ngườiHiếnTặngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorView donor = new DonorView();
            donor.MdiParent = this;
            donor.Show();
            donor.ClearForm();
            donor.WindowState = FormWindowState.Maximized;
           



        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void hiếnTặngMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonateBloodView donateblood = new DonateBloodView();
            donateblood.MdiParent = this;
            donateblood.Show();
            donateblood.ClearForm();
            donateblood.WindowState = FormWindowState.Maximized;

        }

        private void menu_sys_login_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                LoginForm loginForm = new LoginForm(this);
                loginForm.ShowDialog();
                if (isLoggedIn)
                    menu_sys_login.Text = "Đăng xuất";
                SetMenuItemsEnabled(true); // Bật các mục menu

                menu_sys_login.Image = Properties.Resources.icons8_logout_35; 

                if (role == "Admin")
                {
                    menu_employee.Visible = true;
                    menu_donor.Visible = false;
                    menu_donate.Visible = false;
                    menu_patient.Visible = false;
                    menu_bloodstock.Visible = false;
                    menu_bloodtransfer.Visible = false;
                    menu_dashboard.Visible = false;
                }
                else //User
                {
                    menu_employee.Visible = false;
                    menu_donor.Visible = true;
                    menu_donate.Visible = true;
                    menu_patient.Visible = true;
                    menu_bloodstock.Visible = true;
                    menu_bloodtransfer.Visible = true;
                }
            }
            else
            {
                menu_sys_login.Text = "Đăng nhập";
                menu_sys_login.Image = Properties.Resources.icons8_login_35; 

                isLoggedIn = false;
                role = ""; // Đặt lại vai trò
                SetMenuItemsEnabled(false); // Tắt các mục menu
                UpdateMenuItems(); // Cập nhật giao diện
            }
        }

        private void menu_sys_logout_Click(object sender, EventArgs e)
        {
            isLoggedIn = false; // Đặt lại trạng thái đăng nhập
            role = ""; 
            SetMenuItemsEnabled(false); 
            UpdateMenuItems(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateMenuItems();
        }

        private void menu_patient_Click(object sender, EventArgs e)
        {
            PatientView patient = new PatientView();
            patient.MdiParent = this;
            patient.Show();
            patient.ClearForm();
            patient.WindowState = FormWindowState.Maximized;

        }

        private void menu_bloodstock_Click(object sender, EventArgs e)
        {
            BloodStockView bloodstock = new BloodStockView();
            bloodstock.MdiParent = this;
            bloodstock.Show();
            bloodstock.ClearForm();
            bloodstock.WindowState = FormWindowState.Maximized;


        }

        private void menu_bloodtransfer_Click(object sender, EventArgs e)
        {
            BloodTransferView bloodtransfer = new BloodTransferView();
            bloodtransfer.MdiParent = this;
            bloodtransfer.Show();
            bloodtransfer.WindowState = FormWindowState.Maximized;

        }

        private void menu_employee_Click(object sender, EventArgs e)
        {
            EmployeeView employee = new EmployeeView();
            employee.MdiParent = this;
            employee.Show();
            employee.ClearForm();
            employee.WindowState = FormWindowState.Maximized;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_dashboard_Click(object sender, EventArgs e)
        {
           DashboardView dashboard = new DashboardView();
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.WindowState = FormWindowState.Maximized;

        }
       
    }
}
