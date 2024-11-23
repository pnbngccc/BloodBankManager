using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Model
{
    internal class EmployeeModel : IModel
    {
        public int MaNhanVien { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Role { get; set; }
        
        public bool IsValidate()
        {
            return true;
        }
    }
}
