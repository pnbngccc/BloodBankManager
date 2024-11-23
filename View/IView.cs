using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.View
{
    internal interface IView
    {
        void SetDataToText();
        void GetDataFromText();
    }
}
