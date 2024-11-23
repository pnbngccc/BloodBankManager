using BloodBankManagement.Controller;
using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement.View
{
    public partial class DashboardView : Form, IView
    {
        private DonorController donorController;
        private EmployeeController employeeController;
        private BloodTransferController bloodTransferController;
        private BloodController bloodController;
        private BindingList<DonorModel> donorList;
        private BindingList<BloodTransferModel> bloodTransferList;
        private BindingList<EmployeeModel> employeeList;
        private BindingList<BloodModel> bloodList;
        private PrintDocument printDocument;

        public DashboardView()
        {
            InitializeComponent();
            donorController = new DonorController();
            bloodTransferController = new BloodTransferController();
            employeeController = new EmployeeController();
            bloodController = new BloodController();
            donorList = new BindingList<DonorModel>();
            bloodTransferList = new BindingList<BloodTransferModel>();
            employeeList = new BindingList<EmployeeModel>();
            bloodList = new BindingList<BloodModel>();
            LoadDatas();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public void GetDataFromText()
        {
            throw new NotImplementedException();
        }

        public void SetDataToText()
        {
            throw new NotImplementedException();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            UpdateCounts(); 
        }

        private void LoadDatas()
        {
            donorController.Load(); // Nạp dữ liệu vào danh sách người hiến
            donorList = new BindingList<DonorModel>(donorController.Items.Cast<DonorModel>().ToList());

            bloodTransferController.Load();
            bloodTransferList = new BindingList<BloodTransferModel>(bloodTransferController.Items.Cast<BloodTransferModel>().ToList());

            employeeController.Load();
            employeeList = new BindingList<EmployeeModel>(employeeController.Items.Cast<EmployeeModel>().ToList());

            bloodController.Load();
            bloodList = new BindingList<BloodModel>(bloodController.Items.Cast<BloodModel>().ToList());
        }

        private void UpdateCounts()
        {
            int totalDonors = donorList.Count; // Đếm số lượng người hiến tặng
            donorlbl.Text = totalDonors.ToString(); // Cập nhật nhãn hiển thị

            int totalBloodTransfers = bloodTransferList.Count;
            bloodtransferlbl.Text = totalBloodTransfers.ToString();

            int totalEmployees = employeeList.Count;
            employeelbl.Text = totalEmployees.ToString();

            int totalBloods = bloodList.Count;
            total.Text = totalBloods.ToString();

            // Đếm số lượng từng nhóm máu
            UpdateBloodTypeCounts();
        }

        private void UpdateBloodTypeCounts()
        {
            if (!bloodController.Load())
            {
                Console.WriteLine("Không thể tải dữ liệu nhóm máu.");
                return;
            }

            var bloodItems = bloodController.Items.OfType<BloodModel>().ToList();

            // Lấy số lượng cho từng nhóm máu
            int oPlusQuantity = bloodItems.FirstOrDefault(b => b.NhomMau == "O+")?.SoLuongMau ?? 0;
            int oMinusQuantity = bloodItems.FirstOrDefault(b => b.NhomMau == "O-")?.SoLuongMau ?? 0;
            int abPlusQuantity = bloodItems.FirstOrDefault(b => b.NhomMau == "AB+")?.SoLuongMau ?? 0;
            int abMinusQuantity = bloodItems.FirstOrDefault(b => b.NhomMau == "AB-")?.SoLuongMau ?? 0;

            // Tính tổng số lượng máu
            int totalBloodQuantity = bloodItems.Sum(b => b.SoLuongMau);

            // Tính phần trăm cho từng nhóm
            double oPlusPercentage = totalBloodQuantity > 0 ? (double)oPlusQuantity / totalBloodQuantity * 100 : 0;
            double oMinusPercentage = totalBloodQuantity > 0 ? (double)oMinusQuantity / totalBloodQuantity * 100 : 0;
            double abPlusPercentage = totalBloodQuantity > 0 ? (double)abPlusQuantity / totalBloodQuantity * 100 : 0;
            double abMinusPercentage = totalBloodQuantity > 0 ? (double)abMinusQuantity / totalBloodQuantity * 100 : 0;

            // Giới hạn giá trị của thanh tiến trình
            OPlusProgress.Value = Math.Min((int)oPlusPercentage, 100);
            OMinusProgres.Value = Math.Min((int)oMinusPercentage, 100); // Giả sử bạn có OMinusProgress
            ABPlusProgress.Value = Math.Min((int)abPlusPercentage, 100); 
            ABMinusProgress.Value = Math.Min((int)abMinusPercentage, 100); 

            // Cập nhật nhãn hiển thị số lượng cho từng nhóm
            OPlusNumlbl.Text = oPlusQuantity.ToString();
            Ominus.Text = oMinusQuantity.ToString(); // Giả sử bạn có OminusNumlbl
            ABPlusNumlbl.Text = abPlusQuantity.ToString();
            ABminus.Text = abMinusQuantity.ToString(); 
        }

        private void OPlusNumlbl_Click(object sender, EventArgs e)
        {
            
        }

        private void Ominus_Click(object sender, EventArgs e)
        {
            
        }

        private void OPlusProgress_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Tạo một Font để in
            Font font = new Font("Arial", 12);

            // Tính toán vị trí bắt đầu in
            float x = 50;
            float y = 50;
            float lineHeight = font.GetHeight();

            // In tiêu đề
            e.Graphics.DrawString("Thông tin Dashboard", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, y);
            y += lineHeight * 2;

            // In thông tin người hiến tặng
            e.Graphics.DrawString($"Tổng số người hiến tặng: {donorlbl.Text}", font, Brushes.Black, x, y);
            y += lineHeight;

            // In thông tin chuyển máu
            e.Graphics.DrawString($"Tổng số giao dịch chuyển máu: {bloodtransferlbl.Text}", font, Brushes.Black, x, y);
            y += lineHeight;

            // In thông tin nhân viên
            e.Graphics.DrawString($"Tổng số nhân viên: {employeelbl.Text}", font, Brushes.Black, x, y);
            y += lineHeight;

            // In thông tin lượng máu
            e.Graphics.DrawString($"Tổng số lượng máu: {total.Text}", font, Brushes.Black, x, y);
            y += lineHeight;

            // In thông tin từng nhóm máu
            e.Graphics.DrawString($"O+: {OPlusNumlbl.Text}", font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString($"O-: {Ominus.Text}", font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString($"AB+: {ABPlusNumlbl.Text}", font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString($"AB-: {ABminus.Text}", font, Brushes.Black, x, y);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}