using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDoc
{
    internal class BanDoc
    {
        // fields
        private string _maBanDoc;
        private string _hoTen;
        private DateTime _ngayDangKy;

        // properties
        public string MaBanDoc
        {
            get
            {
                return _maBanDoc;
            }

            set
            {
                _maBanDoc = value;
            }
        }

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public DateTime NgayDangKy
        {
            get
            {
                return _ngayDangKy;
            }

            set
            {
                _ngayDangKy = value;
            }
        }

        // Constructor
        public BanDoc(string maBanDoc, string hoTen, DateTime ngayDangKy)
        {
            _maBanDoc = maBanDoc;
            _hoTen = hoTen;
            _ngayDangKy = ngayDangKy;
        }

        public BanDoc() { }

        // Method
        public string toString()
        {
            return ($"{this._maBanDoc,-15}{this._hoTen,-20}{this.NgayDangKy.ToString("dd/MM/yyyy"),-15}");
        }

    }
}
