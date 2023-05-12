using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE4_EXE2
{
    internal class MonHoc
    {
        // field
        private string maMH;
        private string tenMH;
        private DateTime ngayDK;
        private int soTC;

        // properties
        public string MaMH
        {
            get
            {
                return maMH;
            }

            set
            {
                maMH = value;
            }
        }
        public string TenMH 
        {
            get 
            { 
                return tenMH; 
            } 

            set 
            {
                tenMH = value;
            }
             
        }
        public DateTime NgayDK 
        {
            get 
            {
                return ngayDK; 
            }

            set
            {
                ngayDK = value;
            } 
        }
        public int SoTC
        {
            get
            {
                return soTC;
            }

            set
            {
                soTC = value;
            }
        }

        // Constructor
        public MonHoc()
        {

        }

        public MonHoc(string maMH, string tenMH, DateTime ngayDK, int soTC)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.ngayDK = ngayDK;
            this.soTC = soTC;
        }
    
        // method
        public string toString()
        {
            return ($"{this.maMH,-15}{this.tenMH,-15}{this.ngayDK.ToString("dd/MM/yyyy"),-15}{"",-5}{this.soTC,-15}");
        }
    
    
    
    
    }
}
