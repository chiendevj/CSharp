using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT3_Chuong3_OOP
{
    public class Square : Rectangle  
    {
        public Square()
        {
            
        }

        public Square(double side):base(side,side)
        {
            
        }

        public Square(double side, string color, bool filled): base(side, side, color, filled)
        {
            
        }

        public double getSide()
        {
            return this.getWidth();
        }

        public void setSile(double side)
        {
            base.setWidth(side);
        }

        public new void setWidth(double side)
        {
            base.setWidth(side);
            base.setLength(side);
        }

        public new void setLength(double side)
        {
            base.setWidth(side);
            base.setLength(side);
        }

        public new string toString()
        {
            return ($"Square: \nArea of Square{base.getArea()}\nPerimeter of Square: {getPerimeter()}");
        }
    }
}