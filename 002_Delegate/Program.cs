using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Delegate
{
    public delegate int MyDelegete(int arg);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegete myDelegete;

            MyDelegete myDelegete1 = delegate (int x) { return x * 10; };  //
            MyDelegete myDelegete2 = (x) => { return x * 6; };            //
            MyDelegete myDelegete3 = x => x * 5;                         //

            myDelegete = myDelegete1+ myDelegete2 + myDelegete3;

            int s= myDelegete(10);

            Console.WriteLine(s);
            Console.ReadKey();

            
        }
    }
}
