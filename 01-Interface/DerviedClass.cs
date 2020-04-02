using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface
{
    class DerviedClass :BaseClass, Interface1,Interface2
    {
       public void Method1()
        {
            Console.WriteLine("Interface1 realisation");
        }
       public void Method2()
        {
            Console.WriteLine("Interface2 realisation");
        }
    }
}
