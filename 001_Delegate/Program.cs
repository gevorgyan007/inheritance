using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Delegate
{
    public delegate int MyDelegate(ref int a,ref int b,out int s);

    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 1, sum2 = 2, sum ;

            MyDelegate myDelegate = delegate (ref int a,ref int b,out int s) { a++; b++; return  s = a + b; };
            sum = myDelegate.Invoke(ref sum1,ref sum2,out sum); //run

            Console.WriteLine("{0}+{1}={2}",sum1,sum2,sum);

            Console.ReadKey(); 
        }
    }
}
