using System;
using System.IO;

namespace BT6_Chuong3_OOP
{
    class DSSinhVien
    {
        // Xuất DSSV
        public static void XuatFile(SinhVien[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
            }
        }

        // Đọc File DSSV
        public static SinhVien[] DanhSachSinhVien()
        {

            Console.Write("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            SinhVien[] svs = new SinhVien[n];

            for (int i = 0; i < svs.Length; i++)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@"D:\Chuong3\BT6_Chuong3_OOP\file\SV" + (i + 1) + ".txt"))
                    {
                        svs[i] = new SinhVien();
                        svs[i].MaSV = sr.ReadLine();
                        svs[i].HoTen = sr.ReadLine();
                        svs[i].NamSinh = int.Parse(sr.ReadLine());

                        // Đọc danh sách Môn Học
                        int soMonHoc = int.Parse(sr.ReadLine());
                        MonHoc[] mh = new MonHoc[soMonHoc];
                        for (int m = 0; m < soMonHoc; m++)
                        {
                            String[] t = sr.ReadLine().Split('#');
                            mh[m] = new MonHoc(t[0], t[1], int.Parse(t[2]), double.Parse(t[3]));
                        }

                        // Gán danh sách Sinh Viên
                        svs[i].MonHocs = mh;

                        // Đóng file
                        sr.Close();
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return svs;
        }

        // Tinh Diem TB Cao Nhat
        public double GetDiemTBMax()
        {
            double max = ;
        }
    }
}
