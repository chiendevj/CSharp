using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Ch5
{
    class Circle : GeometricObject
    {
        // fields
        private double radius = 1.0;

        // properties
        protected double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle()
        {
            this.radius = 1.0;
        }

        // Method
        public double getPerimeter()
        {
            return 2 * 3.14 * this.radius;
        }

        public double getArea()
        {
            return 3.14 * Math.Pow(this.radius,2);
        }

        public string toString()
        {
            return ($"Circle:\tR = {this.radius}\n\tPerimeter: {this.getPerimeter()}\n\tArea: {this.getArea()}");
        }




    }
}
