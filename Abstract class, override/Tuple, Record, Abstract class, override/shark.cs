using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple__Record__Abstract_class__override
{
    internal class shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("eat as shark");
        }

        public override void Grow()
        {
            Console.WriteLine("grew as shark");
        }

    }
}
