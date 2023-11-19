using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_On
{
    class Node
    {
        public MonHoc mh;
        public Node Next;
        public Node(MonHoc d)
        {
            mh = d;
            Next = null;
        }
    }
}
