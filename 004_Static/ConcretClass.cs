using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Static
{
    class ConcretClass : AbstractClass
    {
        //public override void Method()
        //{
        //    Console.WriteLine("AbstractClass.ovveride.Method");
        //}
        public static new void StaticMethod()
        {
            Console.WriteLine("ConcretClass.StaticMethod00000");
        }
    }
}
