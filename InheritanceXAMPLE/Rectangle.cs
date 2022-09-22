using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Rectangle:Polygon
    {
            private int SR;
            private int PR;

            public Rectangle(int S, int P, int amountofsides, string shapename) : base(amountofsides, shapename)
            {
                this.SR = S;
                this.PR = P;
            }
        }
    }
}
