﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    public class Otter:Mammels
    {
        private int underWater;

        public Otter(int underWater, int milk, string type, double weight, string name):base(milk,type,weight,name)
        {
            this.underWater = underWater;
        }
        public void addmilk(int litter)
        {
            this.milk = this.milk * litter * 1.10;
        }

    }
}
