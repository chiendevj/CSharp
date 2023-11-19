using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CayBaoTrum
{
    internal class Edge
    {
        // fields
        private int startPoint;
        private int endPoint;

        // properties
        public int StartPoint { get => startPoint; set => startPoint = value; }
        public int EndPoint { get => endPoint; set => endPoint = value; }

        // constructor
        public Edge()
        {
            this.startPoint = 0;
            this.endPoint = 0;
        }

        public Edge(int startPoint, int endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        // method
        public string toString()
        {
            return ("(" + startPoint + ", " + endPoint + ")");
        }

    }
}
