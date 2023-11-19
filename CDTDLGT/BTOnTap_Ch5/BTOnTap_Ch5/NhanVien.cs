using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOnTap_Ch5
{
    class NhanVien
    {
        private string maNV;
        private string hoTenNV;
        private int tuoiNV;

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string HoTenNV
        {
            get
            {
                return hoTenNV;
            }

            set
            {
                hoTenNV = value;
            }
        }

        public int TuoiNV
        {
            get
            {
                return tuoiNV;
            }

            set
            {
                tuoiNV = value;
            }
        }

        public NhanVien(string maNV, string hoTenNV, int tuoiNV)
        {
            this.MaNV = maNV;
            this.HoTenNV = hoTenNV;
            this.TuoiNV = tuoiNV;
        }

        public NhanVien()
        {
            this.MaNV = "";
            this.HoTenNV = "";
            this.TuoiNV = 0;
        }
    }
}
