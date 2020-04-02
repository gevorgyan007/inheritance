using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Static
{
    class Program
    {
        //abstract class MyClass
        //{
        //    public static int field;

        //}
        class NoStaticClass
        {
            static readonly int readOnlyfield = 2;
            static int field;

            public static int Property
            {
                get{ return field; }
                set{ field = value;}
            }

            static NoStaticClass()
            {
                Console.WriteLine("Constructor");
                NoStaticClass.field = 1;

            }

            public static void StaticMethod()
            {
                Console.WriteLine("StaticMethod non arg");
            }

            public static void StaticMethod(int a)
            {
                Console.WriteLine("StaticMethod  arg {0}",a);
            }

            public static void StaticMethod(int a,string b)
            {
                Console.WriteLine("StaticMethod 2 arg 1-{0} , 2-{1}", a,b);
            }

            public void Method()
            {
                
                Console.WriteLine(field);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(NoStaticClass.Property);

            NoStaticClass.StaticMethod();
            NoStaticClass.StaticMethod(5);
            NoStaticClass.StaticMethod(6,"Second");

            NoStaticClass instance = new NoStaticClass();

            instance.Method();


            Console.ReadKey();
        }
    }
}
