using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3Chap1
{
    internal class Test_DoThi
    {
        static void Main(string[] args)
        {
            TienIch_DoThi.GhiFile("matran.DAT");
            int[][] maTran = TienIch_DoThi.CreateMatrix("matran.DAT");
            TienIch_DoThi.InMaTran(maTran);
        }
    }
}
