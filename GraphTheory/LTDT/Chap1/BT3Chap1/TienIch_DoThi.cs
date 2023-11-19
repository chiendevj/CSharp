using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3Chap1
{
    internal class TienIch_DoThi
    {
        // kiem tra tinh lien thong
        public static bool KiemTraLienThong()
        {

            return false;
        }

        // tao ma tran tu file
        public static int[][] CreateMatrix(string fileName)
        {
            int[][] maTrix = new int[0][];
            try
            {
                BinaryReader br = new BinaryReader(new FileStream(fileName, FileMode.Open));
                int soDinh = br.ReadInt32();

                maTrix = new int[soDinh][];

                for (int i = 0; i < soDinh; i++)
                {
                    maTrix[i] = new int[soDinh];

                    string str = br.ReadString();
                    if (str != "")
                    {
                        string[] line = str.Split(new char[] {','});
                        for (int j = 0; j < soDinh; j++)
                        {
                            int x = int.Parse(line[j]);
                            maTrix[i][j] = x;
                        }
                    }
                }
                br.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return maTrix;
        }
        // in file
        public static void InMaTran(int[][] maTran)
        {
            for (int i = 0; i < maTran.GetLength(0); i++)
            {
                for (int j = 0; j < maTran.GetLength(0); j++)
                {
                    Console.Write(maTran[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        // ghi file
        public static void GhiFile(string fileName)
        {
            int soDinh = 6;
            string line1 = "0,1,1,1,0,0";
            string line2 = "1,0,1,1,1,0";
            string line3 = "1,1,0,0,1,0";
            string line4 = "1,1,0,0,0,1";
            string line5 = "0,1,1,0,0,1";
            string line6 = "0,0,0,1,1,0";
            BinaryWriter bw;
            try
            {
                bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));

                bw.Write(soDinh);
                bw.Write(line1);
                bw.Write(line2);
                bw.Write(line3);
                bw.Write(line4);
                bw.Write(line5);
                bw.Write(line6);

                bw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("Ghi file thanh cong!");
        }
    }
}
