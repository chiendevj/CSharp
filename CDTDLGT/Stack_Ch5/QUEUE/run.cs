using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;

namespace QUEUE
{
    class run
    {
        static void Main(string[] args)
        {
           
            string path = @"E:\IT_Language\CSharp\CDTDLGT\Stack_Ch5\QUEUE\dshh.txt";
            Queue dshh = DocFile(path);
            XuatFile(dshh);
            Console.WriteLine("Mon hang chuan bi lay ra: ");
            Console.WriteLine(dshh.Peek().ToString());
            ThemHangHoa(dshh);
            string noteDel = "K";
            XoaHangHoa(dshh,noteDel);

        }

        static void XoaHangHoa(Queue dshh, string maHH)
        {
            for (Node p = dshh.First; p != null; p = p.Next)
            {
                if (p.Data.MaHang == maHH)
                {
                    Console.WriteLine(dshh.DeQueue().ToString());
                }
            }    
            
        }

        static void ThemHangHoa(Queue dshh)
        {
            HangHoa hh = new HangHoa();

            Console.Write("Ma HH: ");
            string maHH = Console.ReadLine();
            Console.Write("Ten HH: ");
            string tenHH = Console.ReadLine();
            Console.Write("So Luong: ");
            int amount = int.Parse(Console.ReadLine());
            Console.Write("Gia Ban: ");
            int price = int.Parse(Console.ReadLine());

            hh = new HangHoa(maHH, tenHH, amount, price);
            dshh.EnQueue(hh);
            Console.WriteLine("Danh sach sau khi them 1 HH");
            XuatFile( dshh);
        }
        static void XuatFile(Queue dshh)
        {
            System.Console.WriteLine($"{"Ma Hang",-15}|{"Ten Hang",-15}|{"So Luong",-15}|{"Don Gia",-15}");
            for (Node p = dshh.First; p != null; p = p.Next)
            {
                System.Console.WriteLine(p.Data.ToString());
            }
        }
        static Queue DocFile(string path)
        {
            Queue q = new Queue();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int n = int.Parse(sr.ReadLine());
                    for (int i = 0; i<n; i++)
                    {
                        string[] t = sr.ReadLine().Split('#');
                        q.EnQueue(new HangHoa(t[0], t[1], int.Parse(t[2]), int.Parse(t[3])));
                    }
                }
            }
            catch (IOException)
            {
                throw new IOException();
            }
            return q;
        }

    }
}
