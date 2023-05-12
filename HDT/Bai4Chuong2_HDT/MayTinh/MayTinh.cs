using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai8_QLMayTinh
{
    public class MayTinh
    {
        // field
        private string _LoaiMay;
        private string _NoiSX;
        private int _thoiGianBH;
        private static int qty = 0;

        // properties
        public string LoaiMay { get => _LoaiMay; set => _LoaiMay = value; }
        public string NoiSX { get => _NoiSX; set => _NoiSX = value; }
        public int ThoiGianBH { get => _thoiGianBH; set => _thoiGianBH = value; }
        public static int Qty { get => qty; set => qty = value; }

        public MayTinh()
        {
            this._LoaiMay = "";
            this._thoiGianBH = 0;
            this._NoiSX = "";
            Qty++;
        }

        public MayTinh(MayTinh mt)
        {
            this.LoaiMay = mt._LoaiMay;
            this._NoiSX = mt._NoiSX;
            this._thoiGianBH = mt._thoiGianBH;
            Qty++;
        }

        public MayTinh(string loaiMay, string noiSX, int thoiGianBH)
        {
            this._LoaiMay = loaiMay;
            this._NoiSX = noiSX;
            this._thoiGianBH = thoiGianBH;
            Qty++;
        }

        // Method
        public string toString()
        {
            return $"| {this._LoaiMay,-25} | {this._NoiSX,-15} | {this._thoiGianBH,-15} |";
        }
    }
}