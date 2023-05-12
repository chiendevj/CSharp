using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT2_Chuong3_OOP
{
    public class Point2D
    {
        // field
        private float _x;
        private float _y;

        // properties
        public float getX()
        {
            return _x;
        }

        public void setX(float x)
        {
            this._x = x;
        }

        public float getY()
        {
            return _y;
        }

        public void setY(float y)
        {
            this._y = y;
        }

        public float[] getXY()
        {
            float[] xy = new float[2];
            xy[0] = this._x;
            xy[1] = this._y;
            return xy;
        }

        public void setXY(float x, float y)
        {
            this._x = x;
            this._y = y;
        }

        public Point2D(Point2D point2d)
        {
            this._x = point2d._x;
            this._y = point2d._y;
        }

        public Point2D()
        {
            this._x = 0;
            this._y = 0;
        }

        public Point2D(float x, float y)
        {
            this._x = x;
            this._y = y;
        }

        // methodS
        public String toString()
        {
            string str = "";
            str = $"Toa do Oxy: ({this._x},{this._y})";
            return str;
        }
    }
}