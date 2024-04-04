using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple__Record__Abstract_class__override
{
    internal class Chicken : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("chicken as eat");
        }
        public override void Fly()
        {
            Console.WriteLine("chicken can not fly");
        }
    }
}
