using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractClass instance = AbstractClass.CreateObject();
            //instance.Method();
            ConcretClass.StaticMethod();
            AbstractClass.StaticMethod();



            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
