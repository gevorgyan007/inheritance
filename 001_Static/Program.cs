using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{
    class NoStaticClass
    {
        private int id;
        public static int field;

        public NoStaticClass(int id)
        {
            this.id = id;
        }
        public void Method()
        {
            Console.WriteLine("instance{0}.Field={1}", id, field);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            NoStaticClass instance1 = new NoStaticClass(1);
            NoStaticClass instance2 = new NoStaticClass(2);

            instance1.Method();
            instance2.Method();

            NoStaticClass.field = 5;
            Console.WriteLine(new string('_',20));

            instance1.Method();
            instance2.Method();

            Console.ReadKey();
            
        }
    }
}

