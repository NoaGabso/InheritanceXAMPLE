using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Polygon:Shapes
    {
        protected int amountofsides;
        public Polygon(int amountofsides, string shapename):base(shapename)
        {
            this.amountofsides = amountofsides;
        }
    }

    
}
