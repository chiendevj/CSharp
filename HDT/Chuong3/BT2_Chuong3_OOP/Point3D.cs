using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BT2_Chuong3_OOP
{
    public class Point3D : Point2D
    {
        // field
        private float _z;
   
        //properties
        public float getZ()
        {
            return _z;
        }

        public void setZ(float z)
        {
            this._z = z;
        }

        public float[] getXYZ()
        {
            float[] result = new float[3];
            result[0] = getX();
            result[1] = getY();
            result[2] = this._z;
            return result;
        }
        public Point3D() :base()
        {
            this._z = 0;
        }
        
        public Point3D(float x, float y, float z) : base (x ,y)
        {
            this._z = z;
            this.setX(x);
            this.setY(y);
        }
        public new string toString()
        {
            string str = "";
            str = $"Toa do Oxyz: ({base.toString().Remove(base.toString().Length -1)},{this._z})";
            return str;
        }
    }
}