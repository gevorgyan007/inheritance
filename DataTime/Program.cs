using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTime
{
    class Program
    {
        enum MyEnum
        {
            zero = 0,
            one = 1,
            two = 2,
            tree = 3,
            four,
            five,
            infinite=255,
        }
        static void Main(string[] args)
        {
            Console.WriteLine(new string('_', 50));
            DateTime data = new DateTime(2020, 2, 13);
            DateTime today = DateTime.Now;

            TimeSpan left = data - today;

            Console.WriteLine("до мой днем раждения осталось {0} день", left.Days);
            Console.WriteLine("до мой днем раждения осталось {0} час", left.TotalHours);
            Console.WriteLine(new string('_', 50));


            MyEnum my = MyEnum.one;

            Console.WriteLine("{0}-{1}",my, (int)my);
            Console.WriteLine(new string('_',10));

            Type typemy = my.GetType(); //1
            Console.WriteLine(typemy);

            Type typemy1 = Enum.GetUnderlyingType(typemy); //2 //...enumi tareri typ@  
            Console.WriteLine(typemy1);

            Console.WriteLine(Enum.GetUnderlyingType(typeof(MyEnum)));//3=2
            Console.WriteLine(typeof(MyEnum)); //4=1 

            Console.WriteLine(my.ToString());
            Console.WriteLine(Enum.Format(typeof(MyEnum), MyEnum.one, "X"));
            Console.WriteLine(Enum.Format(typeof(MyEnum), MyEnum.one, "D"));
            Console.WriteLine(Enum.Format(typeof(MyEnum), 2, "G"));

           Console.WriteLine(new string('_', 10));
            for (MyEnum number = MyEnum.zero; number <= MyEnum.tree; number++)
            {
                Console.WriteLine("{0}-{1}", number,(int)number);
            }
            Console.WriteLine(new string('_', 50));

            Array array = Enum.GetValues(typeof(MyEnum)); /// enum-i tarer@ qcum enq zangvaci mej
            Console.WriteLine("Array Lenght equal -{0}",array.Length);

            for(int i=0;i<array.Length;i++)
                Console.WriteLine("name const {0} a value {0:D}",array.GetValue(i) );
            Console.ReadKey();
              
            
        }
    }
}
