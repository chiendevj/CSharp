using System;

namespace Program
{
    class String
    {
        static void Main(string[] args)
        {
            // string s = null;
            // Console.Write("Nhap mot chuoi bat ky: ");
            // s = Console.ReadLine();
            //// Cau 2
            //Console.WriteLine(demSoKiTuLaChuHoa(s));
            //// Cau 5
            // Console.WriteLine(daoNguocChuoi(s));
            //// Cau 6
            //Console.WriteLine(demKiTuSoTrongChuoi(s));
            //// Cau 7
            //if (KiemTraHaiChuoi(s))
            //{
            //    Console.WriteLine("Hai chuoi giong nhau");
            //}
            //else
            //{
            //    Console.WriteLine("Hai chuoi khac nhau");
            //}
            //// Cau 9
            //if (KiemTraChuoiEmail(s))
            //{
            //    Console.WriteLine("Email hop le!!");
            //}
            //else
            //{
            //    Console.WriteLine("Email khong hop le!!");
            //}
            // Cau 10
            //if (CheckChuoiHL(s))
            //{
            //    Console.WriteLine("Chuoi Hop Li.");
            //}
            //else
            //{
            //    Console.WriteLine("Chuoi khong hop li.");
            //}
            // Câu 11
            TaoTaiKhoan();
        }
        // Ngoài Main
        // Câu 11 Tạo tài khoản 
        public static void TaoTaiKhoan() 
        {
            // Decalre variable
            Random rand = new Random();
            string name = null;
            string[] arr = null;
            string username = "";
            string pass = null;
            int passRandom = rand.Next(100000,1000000);
            // Input
            System.Console.Write("What your name? ->  ");
            name = Console.ReadLine();
            // Processing
            arr = name.Split(' ');
            // System.Console.WriteLine(arr.Length); // kiem tra chuoi bao nhieu phan tu
            username = arr[0] + arr[arr.Length -1];
            for (int i = 0; i < arr.Length; i++)
            {
                pass += arr[i][0];
            }
            pass += passRandom;
            // Output
            System.Console.WriteLine("Username: " + username);
            System.Console.WriteLine("Pass: " + pass.ToLower());
        }
        // Cau 10
        public static bool CheckChuoiHL(string s)
        {
            if (s[0] == ' ' || s[s.Length -1] == ' ' || s[0] < 'A' || s[0] > 'Z' || s.Contains("  ") == true)
            {
                return false;
            }
            return true;
        }
        // Cau 9
        public static bool KiemTraChuoiEmail(string s)
        {
            s = s.Replace(" ","");
            if(s != "#" && s != "%" && s !="$" && s != "&" && s != "^")
            {
                if (s == "@")
                {
                    return true;
                }
            }
            return false;
        }
        // Cau 7
        public static bool KiemTraHaiChuoi(string s)
        {
            string s2 = null;
            Console.Write("Nhap chuoi thu 2: ");
            s2 = Console.ReadLine();
            s = s.ToLower();
            s2 = s2.ToLower();
            if (s == s2)
            {
                return true;
            }
            return false;
        }
        // Cau 6
        public static int demKiTuSoTrongChuoi(string s)
        {
            string[] a = s.Split(' ');
            return a.Length;
        }
        // Cau 5
        public static string daoNguocChuoi(string s)
        {
            string[] a = s.Split(' ');  
            string s1 = null;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                s1 += a[i]+" ";
            }
            return s1;
        }
        // Cau 2
        public static int demSoKiTuLaChuHoa(string s)
        {
            int dem = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A'&& s[i] <= 'Z' )
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}