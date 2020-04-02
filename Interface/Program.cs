using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IInterface1
    {
        void Method1();
    }
    interface IInterface2
    {
        void Method2();
    }
    class MyClass : IInterface1,IInterface2
    {
        public  void Method1()
        {
            Console.WriteLine("Реализация интерфейса - IInterface1");
        }
        public void Method2()
        {
            Console.WriteLine("Реализация интерфейса - IInterface2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IInterface1 my = new MyClass();
            IInterface2 my2 = new MyClass();
            my.Method1();
            Console.WriteLine(new string ('_',50));
            my2.Method2();

            Console.ReadKey();
        }
    }
}
