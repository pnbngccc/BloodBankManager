using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Model
{
    internal class BloodTransferModel : IModel
    {
        public int MaChuyenGiao { get; set; }
        public string HoVaTenNguoiNhan { get; set; }
        public string NhomMau { get; set; }
        public bool IsValidate()
        {
            return true;
        }
    }
}
