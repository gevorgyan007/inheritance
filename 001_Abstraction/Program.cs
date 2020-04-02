using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Abstraction
{
    abstract class AbstractClass
    {
        public AbstractClass()
        {
            Console.WriteLine("1 Abstraction!");
            this.AbstractMethod();
            Console.WriteLine("2 abstraction");
        }

        public abstract void AbstractMethod();
    }
    class ConcretClass : AbstractClass
    {
        string s = "First";
        public ConcretClass()
        {
            Console.WriteLine("3 Abstraction");
            s = "Second";
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("реализациа AbstractMethod в ConcretClasse {0}", s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcretClass();
            Console.WriteLine(new string('_', 50));

            instance.AbstractMethod();
            Console.ReadKey();

        }
    }
}

