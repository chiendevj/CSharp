using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimDuongDiNganNhat
{
    internal class Test_TienIch
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TienIch_DuongDiNganNhat.GhiFile();
            int[][] maTran = TienIch_DuongDiNganNhat.TaoMaTran();
            TienIch_DuongDiNganNhat.InMaTran(maTran);
            Console.WriteLine();
            TienIch_DuongDiNganNhat.DuongDiNganNhat_Dijkstra(maTran, 0);
        }
    }
}
