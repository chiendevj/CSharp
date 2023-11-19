using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBaoTrum
{
    internal class Test_TienIch
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TienIch_CayBaoTrum.GhiFile();
            int[][] maTran = TienIch_CayBaoTrum.TaoMaTran();
            TienIch_CayBaoTrum.InMaTran(maTran);
            Edge[] timCayBaoTrum = TienIch_CayBaoTrum.Prim(maTran, 5);
            foreach (var item in timCayBaoTrum)
            {
                Console.WriteLine(item.toString());
            }

        }
    }
}
