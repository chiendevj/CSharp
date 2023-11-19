using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT3_Chuong3_OOP
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _length;

        public Rectangle()
        {
            this._width = 1.0;
            this._length = 1.0;
        }

        public Rectangle(double width, double length)
        {
            this._width = width;
            this._length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this._width = width;
            this._length = length;
            this.setColor(color);
            this.setFilled(filled);
        }

        public double getWidth()
        {
            return this._width;
        }

        public void setWidth(double width)
        {
            this._width = width;
        }

        public double getLength()
        {
            return this._length;
        }

        public void setLength(double length)
        {
            this._length = length;
        }

        public override double getArea()
        {
            return (this._length * this._width);
        }

        public override double getPerimeter()
        {
            return ((this._length + this._width) * 2);
        }

        public override string toString()
        {
            return ($"\nRectangle:\n\tPerimeter of RTG: {getPerimeter()}\n\tArea of RTG: {getArea()}");
        }
    }
}