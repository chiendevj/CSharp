using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT3_Chuong3_OOP
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle()
        {
           this._radius = 1.0;
        }

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this._radius = radius;
            this.setColor(color);
            this.setFilled(filled);
        }

        public double getRadius()
        {
            return this._radius;
        }

        public void setRadius(double radius)
        {
            this._radius = radius;
        }

        public double getArea()
        {
            const double PI = 3.14;
            double area = 0;
            area = PI * Math.Pow(this._radius,2);
            return area;
        }

        public double getPerimeter()
        {
            const double PI = 3.14;
            double per = 0;
            per = 2 * PI * this._radius;
            return per; 
        }

        public new string toString()
        {
            return ($"Area of Circle: {getArea()}\nPerimeter of Circle: {getPerimeter()}");
        }

    }

}