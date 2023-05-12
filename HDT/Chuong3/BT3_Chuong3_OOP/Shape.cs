using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT3_Chuong3_OOP
{
    public class Shape
    {
        private string _color;
        private bool _filled;

        public Shape()
        {
            this._color = "red";
            this._filled = true;
        }

        public Shape(string color, bool filled)
        {
            this._color = color;
            this._filled = filled;
        }

        public string getColor()
        {
            return this._color;
        }

        public void setColor(string color)
        {
            this._color = color;
        }

        public bool isFilled()
        {
            return this._filled;
        }

        public void setFilled(bool filled)
        {
            this._filled = filled;
        }

        public string toString()
        {
            return ($"SHAPE\nColor: {this._color}\nFilled: {this._filled}");
        }
    }
}