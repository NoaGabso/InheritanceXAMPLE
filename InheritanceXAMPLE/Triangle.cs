using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Triangle:Polygon
    {
        private int side1;
        private int side2;
        private int base1;
        private int high;
       
        public Triangle(int side1, int side2, int base1, int high):base(3, "Triangle")
        {
           this.side1 = side1;
            this.side2 = side2; 
            this.base1 = base1; 
            this.high = high;
        }

        public int GetST()
        {
            int ST = (this.base1 * this.high) / 2;
            return ST;
        }

        public int GetPT()
        {
            int PT = side1+side2+base1;
            return PT;
        }
    }
}
