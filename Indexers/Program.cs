using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class MyClass
    {
        public string[] array = new string[5];

        public string this[int index]
        {
            get    // Аксессор.
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
            set    // Мутатор.
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            for (int i = 0; i < 6; i++)
            {
                my[i] = string.Format("string {0}",i);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(my[i]);
            }

            Console.ReadKey();

           
        }
    }
}
