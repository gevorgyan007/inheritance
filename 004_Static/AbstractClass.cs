using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Static
{
    abstract class AbstractClass
    {
        //public static AbstractClass CreateObject()
        //{
        //    Console.WriteLine("createobject.method");
        //    return new ConcretClass();
        //}
        //public abstract void Method();

        public static new void StaticMethod()
        {
            Console.WriteLine("AbstractClass.StaticMethod");
        }
    }
}