using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTap
{
    public abstract class XeHoi
    {
        // fields
        private string Mauxe;
        private Date NamSX = new Date();
        private string NuocSX;
        private string Hieuxe;


        // properties
        public string Mauxe1 { get => Mauxe; set => Mauxe = value; }
        public Date NamSX1 { get => NamSX; set => NamSX = value; }
        public string NuocSX1 { get => NuocSX; set => NuocSX = value; }
        public string Hieuxe1 { get => Hieuxe; set => Hieuxe = value; }


        // constructor

        public XeHoi() 
        {
            this.Mauxe = "";
            this.NamSX = new Date();
            this.NuocSX = "";
            this.Hieuxe = "";
        }

        public XeHoi(string mauxe, Date namSX, string nuocSX, string hieuxe)
        {
            this.Mauxe = mauxe;
            this.NamSX = namSX;
            this.NuocSX = nuocSX;
            this.Hieuxe = hieuxe;
        }

       
        // method
        
        public virtual string ThongTin()
        {
            return ($"{this.Mauxe}#{this.NamSX}#{this.NuocSX}#{this.Hieuxe}");
        }

        public abstract double TongTien();

    }
}