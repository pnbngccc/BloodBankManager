using BloodBankManagement.Controller;
using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BloodBankManagement.View
{
    public partial class EmployeeView : Form, IView
    {
        private EmployeeController controller;
        private EmployeeModel employee;
        private BindingList<EmployeeModel> employeeList;
        private PrintDocument printDocument;

        public EmployeeView()
        {
            InitializeComponent();
            controller = new EmployeeController();
            employee = new EmployeeModel();
            employeeList = new BindingList<EmployeeModel>(); // Khởi tạo BindingList
                                                             // Gán sự kiện Load
            this.Load += new EventHandler(Employee_Load);
            // Khởi tạo đối tượng PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

        }

        public void GetDataFromText()
        {
            employee.MaNhanVien = int.Parse(txtid.Text.Trim()); // Chuyển đổi từ string sang int

            employee.TenDangNhap = txtuser.Text.Trim();
            employee.MatKhau = txtpassword.Text.Trim();
            employee.Role = txtrole.Text.Trim();
        }

        public void SetDataToText()
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                // Tạo một đối tượng BranchModel từ dữ liệu của dòng đã chọn
                employee = new EmployeeModel
                {
                    MaNhanVien = Convert.ToInt32(selectedRow.Cells["MaNhanVien"].Value), // Chuyển đổi sang int
                    TenDangNhap = selectedRow.Cells["TenDangNhap"].Value.ToString(),
                    MatKhau = selectedRow.Cells["MatKhau"].Value.ToString(),
                    Role = selectedRow.Cells["Role"].Value.ToString()
                };

                // Cập nhật dữ liệu vào TextBox
                txtid.Text = employee.MaNhanVien.ToString();
                txtuser.Text = employee.TenDangNhap;
                txtpassword.Text = employee.MatKhau;
                txtrole.Text = employee.Role;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            ClearForm();
        }
        //Search theo ID
        public void SearchEmployeeById(string id)
        {

            if (controller.Load(id))
            {
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy người hiến với ID đã cho.");
            }
        }
        public void UpdateDataGridView()
        {
            employeeList.Clear(); // Xóa danh sách hiện tại trước khi thêm mới

            foreach (var employee in controller.Items.Cast<EmployeeModel>())
            {
                employeeList.Add(employee); // Thêm mỗi người hiến vào BindingList
            }

            guna2DataGridView1.DataSource = employeeList; // Gán BindingList làm nguồn dữ liệu
        }

        //lấy tất cả các chi nhánh từ cơ sở dữ liệu để hiển thị trong giao diện người dùng
        private void LoadEmployees()
        {
            try
            {
                if (controller.Load())
                {
                    var employeeData = controller.Items.Cast<EmployeeModel>().Select(employee => new
                    {
                        MaNhanVien = employee.MaNhanVien,
                        TenDangNhap = employee.TenDangNhap,
                        MatKhau = employee.MatKhau,
                        Role = employee.Role

                    }).ToList();

                    guna2DataGridView1.DataSource = employeeData; // Gán danh sách mới

                    // Đặt tên hiển thị cho các cột
                    guna2DataGridView1.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                    guna2DataGridView1.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
                    guna2DataGridView1.Columns["MatKhau"].HeaderText = "Mật khẩu";
                    guna2DataGridView1.Columns["Role"].HeaderText = "Vai trò";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải dữ liệu: {ex.Message}");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                string id = txtsearch.Text; // Giả sử bạn có một TextBox để nhập ID
                SearchEmployeeById(id);
            }
        }



        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText(); // Hiển thị dữ liệu row được chọn
            }
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                SetDataToText(); // Cập nhật dữ liệu trong TextBox khi chọn dòng mới
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (employee.IsValidate())
            {
                try
                {
                    if (controller.Update(employee))
                    {
                        MessageBox.Show("Nhân viên đã được cập nhật thành công!");
                        ClearForm();
                        LoadEmployees(); // Tải lại danh sách sau khi cập nhật
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật nhân viên.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
            ClearForm();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (employee.IsValidate()) // Ensure you have this validation method implemented in BranchModel
            {
                try
                {

                    // Gọi hàm Delete với đối tượng BranchModel
                    if (controller.Delete(employee))
                    {
                        MessageBox.Show("Nhân viên đã được xóa thành công!");
                        ClearForm();
                        LoadEmployees(); // Refresh the list of branches
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa nhân viên.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
            ClearForm();
        }

        private void btncreate_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (employee.IsValidate())
            {
                try
                {

                    if (controller.Create(employee))
                    {
                        MessageBox.Show("Nhân viên đã được thêm thành công!");
                        ClearForm();
                        LoadEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
            ClearForm();
        }
        public void ClearForm()
        {
            txtid.Text = string.Empty;
            txtuser.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtrole.SelectedIndex = -1; // set selected index to -1 to clear selection
            txtrole.Text = string.Empty;

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];


                string printContent = $"Mã Nhân Viên: {selectedRow.Cells["MaNhanVien"].Value}\n" +
                                      $"Tên Đăng Nhập: {selectedRow.Cells["TenDangNhap"].Value}\n" +
                                      $"Mật Khẩu: {selectedRow.Cells["MatKhau"].Value}\n" +
                                      $"Vai Trò: {selectedRow.Cells["Role"].Value}";

                // In nội dung lên trang
                e.Graphics.DrawString(printContent, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
            }
            else
            {
                e.Cancel = true; // Hủy in nếu không có dòng nào được chọn
            }
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có giao dịch nào được chọn để in không
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giao dịch để in.");
            }
        }
    }
}
