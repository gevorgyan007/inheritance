using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Delegate
{
    delegate string MyDelegat();
    delegate MyDelegat Functional(MyDelegat delget1,MyDelegat delegat2);

    class Program
    {

        static void Main(string[] args)
        {
            MyDelegat delegat1 = () => { return "hello"; }, deleget2 = () => { return "World"; };

            Functional functional = delegate (MyDelegat d1, MyDelegat d2) { return delegate () { return d1.Invoke() + d2.Invoke(); }; };

            Console.WriteLine(functional.Invoke(delegat1, deleget2));

            Console.ReadKey();

        }
    }
}
