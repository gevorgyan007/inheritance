using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class AbstractBaseClass
    {
       
        public void SimpleMethod()
        {
            Console.WriteLine("Base.SimpleMethod");
        }

        //virtual Method
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Base.VirtualMethod");
        }

        //Abstract method
        public abstract void AbstractMethod();
    }
}
