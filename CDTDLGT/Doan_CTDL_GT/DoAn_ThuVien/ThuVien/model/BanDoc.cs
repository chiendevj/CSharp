using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    internal class BanDoc
    {
        // Fields
        private string _maBanDoc;
        private string _hoTen;
        private DateTime _ngayDangKy;

        // Properties
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
        public BanDoc(string maBanDoc, string hoTen)
        {
            _maBanDoc = maBanDoc;
            _hoTen = hoTen;
            _ngayDangKy = DateTime.Now;
        }
        public BanDoc()
        {
            this._maBanDoc = "unknow";
            this._hoTen = "unknow";
            this._ngayDangKy = DateTime.ParseExact("00/00/0000", "dd/MM/yyyy", null);
        }

        // Method
        public string toString()
        {
            return ($"{this._maBanDoc,-15}{this._hoTen,-20}{this.NgayDangKy.ToString("dd/MM/yyyy"),-15}");
        }
    }
}