using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankManagement.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBankManagement.Model
{
    internal class DonorModel : IModel
    {
        public int MaNguoiHien { get; set; }
        public string HoVaTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string NhomMau { get; set; }

        public bool IsValidate()
        {
            return true;
        }
    }
}
