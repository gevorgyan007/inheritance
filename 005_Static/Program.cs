 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Static
{
    class Program
    {
        static class StaticClass
        {
            public static string field;

            static StaticClass()
            {
                field = "Sun";
            }

            public static string SunStaticMethod()
            {
                return string.Format("Sun is shining ");
            }
        }
        class Planet
        {
            public readonly string PlanetName = "WORLD";
            

            public void Method()
            {
                
                Console.WriteLine("World get warm with {0}", StaticClass.SunStaticMethod());
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StaticClass.field);
            Planet planet = new Planet();
            planet.Method();
            
            Console.ReadKey();
        }
    }
}
