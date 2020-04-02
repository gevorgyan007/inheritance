using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interface
{
    interface IInterface
    {
        void Method();
    }
    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.method");
        }
    }
    class ConcretClass : BaseClass,IInterface
    {
        //qani vor iran e poxancvum BaseClassi method kopit asac realizacvum e IInterface -@
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConcretClass instance = new ConcretClass();
            instance.Method();

            IInterface instance1 = instance as IInterface;
            instance1.Method();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
