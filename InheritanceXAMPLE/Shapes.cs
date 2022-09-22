using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace InheritanceXAMPLE
{
    internal class Shapes
    {
        protected string shapename;

        public Shapes(string shapename)
        {
            this.shapename = shapename;
        }

        public string Getshapeame()
        {
            return shapename;
        }

        public void Setshapename(string shapename)
        {
            this.shapename= shapename;
        }

    }
}
