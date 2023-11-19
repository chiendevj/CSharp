using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLinkedList
{
    class Node
    {
        public SinhVien Data;
        public Node Next;
        public Node(SinhVien d)
        {
            Data = d;
            Next = null;
        }
    }
}
