using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class MovablePoint : Movable
    {
        // Fields
        private int x;
        private int y;
        private int xSpeed;
        private int ySpeed;

        // Properties
        internal int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        internal int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        internal int XSpeed
        {
            get
            {
                return xSpeed;
            }

            set
            {
                xSpeed = value;
            }
        }

        internal int YSpeed
        {
            get
            {
                return ySpeed;
            }

            set
            {
                ySpeed = value;
            }
        }

        // Constructor
        public MovablePoint()
        {
            this.X = 0;
            this.Y = 0;
            this.XSpeed = 0;
            this.YSpeed = 0;
        }

        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.X = x;
            this.Y = y;
            this.XSpeed = xSpeed;
            this.YSpeed = ySpeed;
        }

        // Method
        public string toString()
        {
            return ($"({x},{y},{xSpeed},{ySpeed})");
        }

        public void moveUp()
        {
            ySpeed++;
        }

        public void moveDown()
        {
            ySpeed--;
        }

        public void moveLeft()
        {
            xSpeed--;
        }

        public void moveRight()
        {
            xSpeed++;
        }

    }
}
