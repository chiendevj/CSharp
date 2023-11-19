using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class MovableCircle : Movable
    {
        // fields
        private int _radius;
        private MovablePoint _center;

        // properties
        public int Radius
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

        internal MovablePoint Center
        {
            get
            {
                return _center;
            }

            set
            {
                _center = value;
            }
        }

        // Constructor
        public MovableCircle()
        {
            this._radius = 0;
            this._center = new MovablePoint();
        }

        public MovableCircle (int _radius, MovablePoint _center)
        {
            this._radius = _radius;
            this._center = _center;
        }

        public MovableCircle(int x, int y, int xSpeed, int ySpeed, int _radius)
        {
            this._radius = _radius;
            this._center = new MovablePoint(x, y, xSpeed, ySpeed);
        }

        // Method
        public new string toString()
        {
            return ($"Radius: {this._radius}\nCenter: {this._center.toString()}");
        }

        public void moveUp()
        {
            _center.moveUp();
        }

        public void moveDown()
        {
            _center.moveDown();
        }

        public void moveLeft()
        {
            _center.moveLeft();
        }

        public void moveRight()
        {
            _center.moveRight();
        }

    }
}
