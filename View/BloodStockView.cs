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
    public partial class BloodStockView : Form, IView
    {
        private BloodStockController controller;
        private BloodModel bloodstock;
        private BindingList<BloodModel> bloodstockList; // Thêm BindingList
        private PrintDocument printDocument;

        public BloodStockView()
        {

            InitializeComponent();
            controller = new BloodStockController();
            bloodstock = new BloodModel();
            bloodstockList = new BindingList<BloodModel>(); // Khởi tạo BindingList

            this.Load += new EventHandler(BloodStockView_Load);
            // Khởi tạo đối tượng PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public void GetDataFromText()
        {

            bloodstock.NhomMau = txtgroup.Text.Trim();
            bloodstock.SoLuongMau = int.Parse(txtstock.Text.Trim()); // Chuyển đổi từ string sang int

        }

        public void SetDataToText()
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                // Tạo một đối tượng BranchModel từ dữ liệu của dòng đã chọn
                bloodstock = new BloodModel
                {
                    NhomMau = selectedRow.Cells["NhomMau"].Value.ToString(),
                    SoLuongMau = Convert.ToInt32(selectedRow.Cells["SoLuongMau"].Value) // Chuyển đổi sang int
                };

                // Cập nhật dữ liệu vào TextBox
                txtgroup.SelectedItem = bloodstock.NhomMau;
                txtstock.Text = bloodstock.SoLuongMau.ToString(); // Chuyển đổi int sang string

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText(); // Hiển thị dữ liệu row được chọn
            }
        }

        private void BloodStockView_Load(object sender, EventArgs e)
        {
            LoadBloodStocks();
            ClearForm();
        }
        private void LoadBloodStocks()
        {
            try
            {
                if (controller.Load())
                {
                    var BloodStockData = controller.Items.Cast<BloodModel>().Select(bloodstock => new
                    {


                        NhomMau = bloodstock.NhomMau,
                        SoLuongMau = bloodstock.SoLuongMau
                    }).ToList();

                    guna2DataGridView1.DataSource = BloodStockData; // Gán danh sách mới

                    // Đặt tên hiển thị cho các cột

                    guna2DataGridView1.Columns["NhomMau"].HeaderText = "Nhóm Máu";
                    guna2DataGridView1.Columns["SoLuongMau"].HeaderText = "Số Lượng Máu";
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

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                SetDataToText(); // Cập nhật dữ liệu trong TextBox khi chọn dòng mới
            }
        }
        //Search theo ID
        public void SearchBloodStockById(string id)
        {

            if (controller.Load(id))
            {
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhóm máu với ID đã cho.");
            }
        }

        public void UpdateDataGridView()
        {
            bloodstockList.Clear(); // Xóa danh sách hiện tại trước khi thêm mới

            foreach (var bloodstock in controller.Items.Cast<BloodModel>())
            {
                bloodstockList.Add(bloodstock); // Thêm mỗi người hiến vào BindingList
            }

            guna2DataGridView1.DataSource = bloodstockList; // Gán BindingList làm nguồn dữ liệu
        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoadBloodStocks();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
        public void ClearForm()
        {


            txtgroup.SelectedIndex = -1;
            txtgroup.Text = string.Empty; // clear text
            txtstock.Text = string.Empty;
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                string id = txtsearch.Text; // Giả sử bạn có một TextBox để nhập ID
                SearchBloodStockById(id);
            }
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];


                string printContent = $"Nhóm Máu: {selectedRow.Cells["NhomMau"].Value}\n" +
                                      $"Số Lượng Máu: {selectedRow.Cells["SoLuongMau"].Value}";

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

        private void txtstock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            LoadBloodStocks();
        }
    }
}
