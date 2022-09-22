using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Rectangle:Polygon
    {
        private int side1;
        private int side2;

        public Rectangle(int side1, int side2) : base(4, "Rectangle")
            {
                this.side1 = side1;
                this.side2 = side2;
            }
        
        public int GetSR()
        {
            int SR = side1 * side2;
            return SR;
        }

        public int GetPR()
        {
            int PR = 2*side1+2*side2;
            return PR;
        }

        public bool IsSuare(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            if(side1 == side2)
                return true;
            else
                return false;
        }
    }
}
