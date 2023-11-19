using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class MovableRectangle : Movable
    {
        // fields
        private MovablePoint _topLeft;
        private MovablePoint _bottomRight;

        // properties
        internal MovablePoint TopLeft
        {
            get
            {
                return _topLeft;
            }

            set
            {
                _topLeft = value;
            }
        }

        internal MovablePoint BottomRight
        {
            get
            {
                return _bottomRight;
            }

            set
            {
                _bottomRight = value;
            }
        }

        // Constructor
        public MovableRectangle()
        {
            this._topLeft = new MovablePoint();
            this._bottomRight = new MovablePoint();
        }

        public MovableRectangle(int x1, int y1, int x2, int y2, int xSpeed, int ySpeed)
        {
            this._topLeft = new MovablePoint(x1, y1, xSpeed, ySpeed);
            this._bottomRight = new MovablePoint(x2, y2, xSpeed, ySpeed);
        }

        // Method
        public string toString()
        {
            return ($"Top Left: {this._topLeft}\nBottom Right: {this._bottomRight}");
        }

        public void moveUp()
        {
            TopLeft.moveUp();
            BottomRight.moveUp();
        }

        public void moveDown()
        {
            TopLeft.moveDown();
            BottomRight.moveDown();
        }

        public void moveLeft()
        {
            TopLeft.moveLeft();
            BottomRight.moveLeft();
        }

        public void moveRight()
        {
            TopLeft.moveRight();
            BottomRight.moveRight();
        }
    }
}
