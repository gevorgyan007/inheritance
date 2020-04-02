using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    interface IInterface
    {
        void Method();

    }
    struct Structe: IInterface
    { 
        public   void Method()
        {
            Console.WriteLine("hello'");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1
            short a = 5;
            Object o = a;

            short b = (short)o;
            //2
            Structe str = new Structe();
            ValueType v =( Structe)str;

            //3
            IInterface Inter= str;
            Structe str1 = (Structe)Inter;

            GC.GetTotalMemory(false);
            Console.ReadKey();

            
        }
    }
}
