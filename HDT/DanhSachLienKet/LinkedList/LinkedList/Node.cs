using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_C4
{
    class Node
    {
        //Fields
        internal int Data;
        internal Node Next;

        //Constructor
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
