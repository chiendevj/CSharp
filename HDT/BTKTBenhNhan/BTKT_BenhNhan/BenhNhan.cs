using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BTKT_BenhNhan
{
    internal abstract class BenhNhan
    {
        // fields
        private string _maHoSo;
        private string _hoTen;
        private DateTime _ngaySinh;
        private string _chuanDoanBenh;
        private DateTime _ngayLapHoSo;
        private static int _soLuongBenhNhan;

        // properties
        public string MaHoSo { get => _maHoSo; set => _maHoSo = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string ChuanDoanBenh { get => _chuanDoanBenh; set => _chuanDoanBenh = value; }
        public DateTime NgayLapHoSo { get => _ngayLapHoSo; set => _ngayLapHoSo = value; }
        public static int SoLuongBenhNhan { get => _soLuongBenhNhan; set => _soLuongBenhNhan = value; }

        // Constructor
        public BenhNhan() { }

        public BenhNhan(string maHS, string hoTen, DateTime ngSinh, string chuanDBN, DateTime ngayLHS)
        {
            this._maHoSo = maHS;
            this._hoTen = hoTen;
            this._ngaySinh = ngSinh;
            this._chuanDoanBenh = chuanDBN;
            this._ngayLapHoSo = ngayLHS;

        }

        public BenhNhan(BenhNhan bn)
        {
            this._maHoSo = bn._maHoSo;
            this._hoTen = bn._hoTen;
            this._ngaySinh = bn._ngaySinh;
            this._chuanDoanBenh = bn._chuanDoanBenh;
            this._ngayLapHoSo = bn._ngayLapHoSo;

        }

        // METHOD
        public abstract string toString();
        

       
    }
}
