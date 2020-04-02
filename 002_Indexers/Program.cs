using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            DerviedClass instance = new DerviedClass();
            //BaseClass instance1 = instance as BaseClass;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance[i]);
            }
            Console.ReadKey();
        }
    }
}
