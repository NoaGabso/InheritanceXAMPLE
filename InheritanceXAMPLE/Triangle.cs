using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Triangle:Polygon
    {
        private int ST;
        private int PT;

        public Triangle(int S, int P, int amountofsides,string shapename):base(amountofsides, shapename)
        {
            this.ST = S;
            this.PT = P;
        }
    }
}
