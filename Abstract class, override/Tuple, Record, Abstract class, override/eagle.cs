﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple__Record__Abstract_class__override
{
    internal class eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("eat as eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("fly as eagle");
        }

        public void hunt()
        {
            Console.WriteLine("hunt");
        }
    }
}
