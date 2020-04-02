using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class DerviedClass : AbstractBaseClass
    {
        //public override void VirtualMethod()
        //{
        //    Console.WriteLine("DerviedClass.Virtualmethod") ;
        //}

        public override void AbstractMethod()
        {
            Console.WriteLine("DerviedClass.AbstractMethod");
        }
    }
}
