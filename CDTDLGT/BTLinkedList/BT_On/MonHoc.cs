using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_On
{
    class MonHoc
    {
        // field
        private string _maMonHoc;
        private string _tenMonHoc;
        private int _soTC;

        public string MaMonHoc
        {
            get
            {
                return _maMonHoc;
            }

            set
            {
                _maMonHoc = value;
            }
        }

        public string TenMonHoc
        {
            get
            {
                return _tenMonHoc;
            }

            set
            {
                _tenMonHoc = value;
            }
        }

        public int SoTC
        {
            get
            {
                return _soTC;
            }

            set
            {
                _soTC = value;
            }
        }

        public MonHoc(string maMonHoc, string tenMonHoc, int soTC)
        {
            this.MaMonHoc = maMonHoc;
            this.TenMonHoc = tenMonHoc;
            this.SoTC = soTC;
        }

        public MonHoc()
        {
          
        }

        // method
        public string toString()
        {
            return ($"{this._maMonHoc, -15}{this._tenMonHoc, -15}{this._soTC, -15}");
        }

        public void Nhap()
        {
            Console.Write("Nhap ma mon: ");
            this._maMonHoc = Console.ReadLine();
            Console.Write("Nhap ten mon: ");
            this._tenMonHoc = Console.ReadLine();
            Console.Write("Nhap so TC: ");
            this._soTC = int.Parse(Console.ReadLine());
            
        }
    }
}
