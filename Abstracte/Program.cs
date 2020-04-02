using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracte
{
    

    abstract class AbstractClassA
    {
        public abstract void Method1();
        
    }
    abstract class AbstractClassB : AbstractClassA
    {
        public abstract  void Method2();
    }
    class ConcretClass : AbstractClassB
    {
        public override void Method1()
        {
            Console.WriteLine("Method1");
        }
        public override void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConcretClass instance = new ConcretClass();
            instance.Method1();
       

            Console.ReadKey();
        }
    }
}
