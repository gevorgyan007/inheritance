using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Delegate
{
    delegate delelegat2 delegat1();
    delegate void delelegat2();

    class Program
    {
        public static delelegat2 Method1()
        {
            return new delelegat2(Method2);
        }
        public static void Method2()
        {
            Console.WriteLine("hello World");
        }

        static void Main(string[] args)
        {
            delegat1 mydelegat1 = new delegat1(Method1);

            delelegat2 mydelegat2 = mydelegat1();

            mydelegat2();

            Console.ReadKey();

            
        }
    }
}
