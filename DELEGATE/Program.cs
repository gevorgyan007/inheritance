using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATE
{
    public delegate void MyDelegete();

    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("Method1.value");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2.value");
        }
        public static void Method3()
        {
            Console.WriteLine("Method3.value");
        }

        static void Main(string[] args)
        {
            MyDelegete mydelegat = null;
            MyDelegete mydelegat1 =new MyDelegete(Method1);
            MyDelegete mydelegat2 =new MyDelegete(Method2);
            MyDelegete mydelegat3 =new MyDelegete(Method3);

            mydelegat = mydelegat1 + mydelegat2 + mydelegat3;

           Console.WriteLine("Enter your number pls.");

            label: string choise = Console.ReadLine();

            int n = Int32.Parse(choise);

            switch (n)
            {
                case 1:
                    {
                        mydelegat1.Invoke();
                        break;
                    }
                case 2:
                    {
                        mydelegat2.Invoke();
                        break;
                    }
                case 3:
                    {
                        mydelegat3.Invoke();
                        break;
                    }
                case 4:
                    {
                        MyDelegete mydelegat4 = mydelegat - mydelegat1;
                        mydelegat4.Invoke();
                        break;
                    }
                case 5:
                    {
                        MyDelegete mydelegat5 = mydelegat - mydelegat2;
                        mydelegat5.Invoke();
                        break;
                    }
                case 6:
                    {
                        MyDelegete mydelegat6 = mydelegat - mydelegat3;
                        mydelegat6.Invoke();
                        break;
                    }
                case 7:
                    {
                       mydelegat.Invoke();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You enter wrong number!! --please try again!!");
                        goto label;
                    }
            }

            Console.ReadKey();
        }
    }
}

