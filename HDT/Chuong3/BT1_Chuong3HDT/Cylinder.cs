using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT1_Chuong3HDT
{
    public class Cylinder : Circle
    {
        // field
        private double _height;
        // properties
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }
        public Cylinder() : base()
        {
            this._height = 1.0;
        }
        public Cylinder(double height, double radius, string color) : base(radius, color)
        {
            this._height = height;
            this.Radius = radius;
            this.Color = color;
        }
        public Cylinder(double height, double radius)
        {
            this._height = height;
            this.Radius = radius;
        }
        public Cylinder(double radius)
        {
            this.Radius = radius;
        }

        // Method
        // V = pi.r2.h
        public double getVolume()
        {
            const double PI = 3.14;
            double V = 0;
            V = getArea() * this._height;
            return V;
        }
        public new string toString()
        {
            return ($"Height: {this._height}\n{base.toString()}\nVolume of Cylender: {getVolume()}");
        }
    }
}