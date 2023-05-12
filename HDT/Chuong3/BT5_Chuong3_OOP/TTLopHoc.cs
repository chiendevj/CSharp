using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_Chuong3_OOP
{
    class TTLopHoc
    {
        //field
        private string _tenLop;
        private string _khoa;

        // properties
        public string TenLop
        {
            get
            {
                return _tenLop;
            }

            set
            {
                _tenLop = value;
            }
        }

        public string Khoa
        {
            get
            {
                return _khoa;
            }

            set
            {
                _khoa = value;
            }
        }

        // Constructor
        public TTLopHoc()
        {

        }

        public TTLopHoc(string tenLop, string khoa)
        {
            this._tenLop = tenLop;
            this._khoa = khoa;
        }

        public string toString()
        {
            return ($"Ten Lop: {this._tenLop,-25}Khoa: {this._khoa}");
        }
    }
}
