using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface
{
    interface Interface1
    {
        void Method();
    }
    interface Interface2
    {
        void Method();
    }
    class ConcretClass : Interface2, Interface1
    {
        public void Method()
        {
            Console.WriteLine("Interface1-2 Method realisation!");
        }
        //void Interface2.method()
        //{
        //    Console.WriteLine("Interface2 Method realisation!");
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {

            ConcretClass instance = new ConcretClass();
            instance.Method(); 

            Interface1 instance1 = instance as Interface1;
            instance1.Method();

            Interface2 instance2 = instance as Interface2;
            instance2.Method();
       
            Console.ReadKey();

             
        }
    }
}
