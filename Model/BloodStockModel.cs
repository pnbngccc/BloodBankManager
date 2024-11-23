using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Model
{
    internal class BloodStockModel : IModel
    {
        public string NhomMau { get; set; }
        public int SoLuongMau { get; set; }

        public bool IsValidate()
        {
            return true;
        }
    }
}
