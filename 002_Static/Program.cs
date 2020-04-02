using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Static
{
    class NonStaticClass
    {
        public int num;
        static int field;

        public static int Proprty
        {
            get { return field; }
            set { field = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass inst = new NonStaticClass();

            NonStaticClass.Proprty = 55;

            inst.num = NonStaticClass.Proprty;

            Console.WriteLine(NonStaticClass.Proprty);
            Console.WriteLine(inst.num);
            Console.ReadKey();

            
        }
    }
}
