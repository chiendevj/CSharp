using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOnTap_Ch5
{
    class Node
    {
        internal NhanVien Data;
        internal Node Next;

        public Node(NhanVien nv)
        {
            Data = nv;

            Next = null;
        }

    }  
    
}
