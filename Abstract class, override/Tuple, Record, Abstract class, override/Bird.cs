using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple__Record__Abstract_class__override
{
    internal abstract class Bird: animal
    {
       /* public abstract void Fly();*/
       
        public virtual void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
