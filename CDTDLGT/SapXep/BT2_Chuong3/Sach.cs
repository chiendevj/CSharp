using System;
using System.IO;

namespace BT2
{
    class Sach
    {
        private string maSach, tenSach;
        private int namXB, giaBan;

        public int GiaBan
        {
            get
            {
                return giaBan;
            }

            set
            {
                giaBan = value;
            }
        }

        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public int NamXB
        {
            get
            {
                return namXB;
            }

            set
            {
                namXB = value;
            }
        }

        public string TenSach
        {
            get
            {
                return tenSach;
            }

            set
            {
                tenSach = value;
            }
        }

        public void Doc(StreamReader sr)
        {
            string[] t = sr.ReadLine().Split('#');
            MaSach = t[0];
            TenSach = t[1];
            NamXB = int.Parse(t[2]);
            GiaBan = int.Parse(t[3]);
        }
        public void Xuat()
        {
            Console.WriteLine($"{MaSach,-10}{TenSach,-10}{NamXB,-10}{GiaBan,-10}");
        }
    }
}