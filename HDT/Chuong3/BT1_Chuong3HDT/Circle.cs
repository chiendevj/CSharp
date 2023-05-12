using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT1_Chuong3HDT
{
    public class Circle
    {
        private double _radius;
        private string _color;

        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public Circle()
        {
            this._color = "red";
            this._radius = 1;
        }

        public Circle(double rad, string color)
        {
            this._radius = rad;
            this._color = color;
        }
        
        public Circle(double rad)
        {
            this._radius= rad;
        }

        // Method
        public double getArea()
        {
            const double PI = 3.14;
            double area = 0;
            area = PI * Math.Pow(this._radius, 2);
            return area;
        }
        public string toString()
        {
            string str = "";
            str = $"Circle include:\n\tRadius = {this._radius}.\n\tColor: {this._color}\nArea of Circle is: {getArea()}.";
            return str;
        }

    }
}