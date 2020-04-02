using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass my = new DerivedClass();

            //my.field1 = 1;
            //my.field2 = 2;
            //my.field3 = 3;

            //my.field4 = 4;
            //my.field5 = 5;
            ////Console.WriteLine(my.publicfield);
            //BaseClass bas = (BaseClass)my; //UpCast
            ////my.Show();
            //Console.WriteLine(my.field1);
            //Console.WriteLine(my.field2);
            //Console.WriteLine(my.field3);

            ////Console.WriteLine(my.field4);
            ////Console.WriteLine(my.field5);

            ////Console.WriteLine(my.BaseNumber);
            ////Console.WriteLine(my.DerivedField);

            //Console.WriteLine("my id - {0}",my.GetHashCode());
            //Console.WriteLine("bas id - {0}",bas.GetHashCode());

            DerivedClass instance = new DerivedClass();
            instance.Method();                                      //ClasB : ClassA
                                                                   //ClassB b, ClassA a
            BaseClass instanceUp = instance as BaseClass; //BaseClass instanceUp = instance  / (b as BaseClass)
            instanceUp.Method();

            DerivedClass instanceDown = instanceUp as DerivedClass; //(DerivedClass)instanceUp
            instanceDown.Method();

            Console.ReadKey();
        }
    }
}
