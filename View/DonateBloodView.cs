using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BloodBankManagement.Controller;
using BloodBankManagement.Model;
using System.Xml.Linq;
using Guna.UI2.AnimatorNS;

namespace BloodBankManagement.View
{
    public partial class DonateBloodView : Form, IView
    {
        private BloodController bloodController;
        private DonorController donorController; // Tạo controller cho người hiến
        private BloodModel blood;
        private BindingList<BloodModel> bloodList;
        private BindingList<DonorModel> donorList; // BindingList cho người hiến

        string searchBlood;
        public DonateBloodView()
        {
            InitializeComponent();
            bloodController = new BloodController();
            donorController = new DonorController(); // Khởi tạo controller cho người hiến
            blood = new BloodModel();
            bloodList = new BindingList<BloodModel>();
            LoadBloods();
            donorList = new BindingList<DonorModel>(); // Khởi tạo BindingList cho người hiến
            LoadDonors();
            UpdateDataGridView();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //update
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            searchBlood = GetBlood();
            foreach (BloodModel model in bloodList)
            {
                if (model.NhomMau == searchBlood)
                {
                    model.SoLuongMau++;
                    bloodController.Update(model);

                }
            }
            UpdateDataGridView();
        }
        public string GetBlood()
        {
            try
            {
                string a = txtgroup.Text.Trim();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ở đây không có lỗi: {ex.Message}");
            }
            return "";
        }
        public void GetDataFromText()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // hiển thị bảng 
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                SetDataToText();
                UpdateDataGridView();
            }
        }
        // hiển thị bảng donor
        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText(); // Hiển thị dữ liệu row được chọn
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void SetDataToText()
        {


        }
        public void SetDonor()
        {
            if (guna2DataGridView2.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn trong guna2DataGridView2
                DataGridViewRow selectedRow2 = guna2DataGridView2.SelectedRows[0];

                // Tạo một đối tượng DonorModel từ dữ liệu của dòng đã chọn
                var donor = new DonorModel
                {
                    MaNguoiHien = Convert.ToInt32(selectedRow2.Cells["MaNguoiHien"].Value), // Chuyển đổi sang int
                    HoVaTen = selectedRow2.Cells["HoVaTen"].Value.ToString(),
                    Tuoi = Convert.ToInt32(selectedRow2.Cells["Tuoi"].Value),
                    GioiTinh = selectedRow2.Cells["GioiTinh"].Value.ToString(),
                    SoDienThoai = selectedRow2.Cells["SoDienThoai"].Value.ToString(),
                    DiaChi = selectedRow2.Cells["DiaChi"].Value.ToString(),
                    NhomMau = selectedRow2.Cells["dataGridViewTextBoxColumn2"].Value.ToString()
                };

                // Cập nhật dữ liệu vào TextBox

                txtname.Text = donor.HoVaTen;
                txtgroup.SelectedItem = donor.NhomMau;
            }
        }




        private void LoadDonors()
        {
            try
            {
                if (donorController.Load())
                {
                    var DonorData = donorController.Items.Cast<DonorModel>().Select(donor => new
                    {
                        MaNguoiHien = donor.MaNguoiHien,
                        HoVaTen = donor.HoVaTen,
                        Tuoi = donor.Tuoi,
                        GioiTinh = donor.GioiTinh,
                        SoDienThoai = donor.SoDienThoai,
                        DiaChi = donor.DiaChi,
                        NhomMau = donor.NhomMau
                    }).ToList();

                    guna2DataGridView2.DataSource = DonorData;

                    guna2DataGridView2.Columns["MaNguoiHien"].HeaderText = "Mã người hiến";
                    guna2DataGridView2.Columns["HoVaTen"].HeaderText = "Họ và tên";
                    guna2DataGridView2.Columns["Tuoi"].HeaderText = "Tuổi";
                    guna2DataGridView2.Columns["GioiTinh"].HeaderText = "Giới tính";
                    guna2DataGridView2.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                    guna2DataGridView2.Columns["DiaChi"].HeaderText = "Địa chỉ";
                    guna2DataGridView2.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Nhóm máu";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu về người hiến để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải dữ liệu về người hiến: {ex.Message}");
            }
        }

        private void LoadBloods()
        {
            try
            {
                if (bloodController.Load())
                {
                    var BloodData = bloodController.Items.Cast<BloodModel>().Select(blood => new
                    {
                        NhomMau = blood.NhomMau,
                        SoLuongMau = blood.SoLuongMau
                    }).ToList();

                    guna2DataGridView1.DataSource = BloodData;

                    // Đặt tên hiển thị cho các cột
                    guna2DataGridView1.Columns["NhomMau"].HeaderText = "Nhóm Máu";
                    guna2DataGridView1.Columns["SoLuongMau"].HeaderText = "Số Lượng Máu";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu về máu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải dữ liệu về máu: {ex.Message}");
            }
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
        public void UpdateDataGridView()
        {
            bloodList.Clear(); // Xóa danh sách hiện tại trước khi thêm mới

            foreach (var blood in bloodController.Items.Cast<BloodModel>())
            {
                bloodList.Add(blood); // Thêm mỗi người hiến vào BindingList
            }

            guna2DataGridView1.DataSource = bloodList; // Gán BindingList làm nguồn dữ liệu
        }
        //donor
        private void guna2DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView2.SelectedRows.Count > 0)
            {
                SetDonor();
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void DonateBloodView_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        public void ClearForm()
        {


            txtgroup.SelectedIndex = -1;
            txtgroup.Text = string.Empty; // clear text
            txtname.Text = string.Empty;
        }
    }
}