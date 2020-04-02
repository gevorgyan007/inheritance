using System;

// Техника Делегирования.

namespace Delegation
{
    class A
    {
        public string DoSomething(string s)
        {
            Console.WriteLine("Action");
            return s + "!!!!!!";
        }
    }

    class B
    {
        public string DoSomething(string s)
        {
            A a = new A();
            return a.DoSomething(s);
        }
    }

    class Program
    {
        static void Main()
        {
            B b = new B();
            string shose = b.DoSomething("change cobluk");
            Console.WriteLine(shose);
            // Delay.
            Console.ReadKey();
        }
    }
}
