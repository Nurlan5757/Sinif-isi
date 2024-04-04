﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple__Record__Abstract_class__override
{
    internal abstract class animal
    {
        public string Name { get; set; }
        public abstract void Eat();
        public virtual void Grow()
        {
            Console.WriteLine("Grew");
        }
        public override string ToString()
        {
            return Name;
        }
    }
}