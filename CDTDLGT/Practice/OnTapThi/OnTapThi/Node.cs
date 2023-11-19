using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnTapThi
{
    public class Node
    {
        //fields
        internal NhanVien Data;
        internal Node Next;

        //constructors
        public Node(NhanVien data)
        {
            Data = data;
            Next = null;
        }
    }
}