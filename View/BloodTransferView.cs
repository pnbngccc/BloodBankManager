using BloodBankManagement.Controller;
using BloodBankManagement.Model;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BloodBankManagement.View
{
    public partial class BloodTransferView : Form, IView
    {
        private BloodController bloodController;
        private PatientController patientController;
        private BindingList<PatientModel> patientList;
        private BindingList<BloodModel> bloodList;
        private BloodModel model;

        public BloodTransferView()
        {
            InitializeComponent();
            bloodController = new BloodController();
            patientController = new PatientController();
            patientList = new BindingList<PatientModel>();
            bloodList = new BindingList<BloodModel>();
            model = new BloodModel();

            LoadBloods();
            LoadPatients();
            cboPatientID.SelectedIndexChanged += CboAccountID_SelectedIndexChanged;
        }

        private void LoadPatients()
        {
            try
            {
                if (patientController.Load())
                {
                    var patients = patientController.Items.Cast<PatientModel>().ToList();
                    patientList = new BindingList<PatientModel>(patients);
                    cboPatientID.DataSource = patientList;
                    cboPatientID.DisplayMember = "MaBenhNhan";
                    cboPatientID.ValueMember = "MaBenhNhan";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu về tài khoản để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải dữ liệu về tài khoản: {ex.Message}");
            }
        }

        private void CboAccountID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPatientID.SelectedItem is PatientModel selectedPatient)
            {
                txtname.Text = selectedPatient.HoVaTen;
                txtgroup.Text = selectedPatient.NhomMau;
                UpdateAvailability();
            }
        }

        private void LoadBloods()
        {
            try
            {
                if (bloodController.Load())
                {
                    bloodList = new BindingList<BloodModel>(bloodController.Items.Cast<BloodModel>().ToList());
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

        private void UpdateAvailability()
        {
            if (cboPatientID.SelectedItem is PatientModel selectedPatient)
            {
                model = bloodList.FirstOrDefault(b => b.NhomMau == selectedPatient.NhomMau);
                if (model != null && model.SoLuongMau > 0)
                {
                    btntransfer.Visible = true;
                    availble.Text = "Có sẵn";
                    availble.Visible = true;
                }
                else
                {
                    btntransfer.Visible = false;
                    availble.Text = "Không có sẵn";
                    availble.Visible = true;
                }
            }
            else
            {
                availble.Visible = false;
                btntransfer.Visible = false;
            }
        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            if (cboPatientID.SelectedItem is PatientModel selectedPatient && model != null && model.SoLuongMau > 0)
            {
                model.SoLuongMau--;
                if (bloodController.Update(model))
                {
                    MessageBox.Show("Chuyển giao 1 đơn vị máu thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật cơ sở dữ liệu.");
                }
            }
            else
            {
                MessageBox.Show("Không đủ máu để chuyển giao.");
            }
        }

        public void SetDataToText()
        {
            throw new NotImplementedException();
        }

        public void GetDataFromText()
        {
            throw new NotImplementedException();
        }
    }
}