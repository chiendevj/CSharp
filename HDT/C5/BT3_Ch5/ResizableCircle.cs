using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Ch5
{
    class ResizableCircle : Circle, Resizable
    {
        public ResizableCircle(double radius)
        {
            base.Radius = radius;
        }

        public double resize(double percent)
        {
            return (base.Radius * (percent / 100));
        }
    }
}
