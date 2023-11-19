using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu1
{
    internal class Node
    {
        // field
        internal MonHoc Data;
        internal Node Next;

        public Node(MonHoc data) 
        {
            this.Data = data;
            this.Next = null;
        }   
    }
}
