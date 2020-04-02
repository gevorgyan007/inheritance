using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_interface
{
    interface IEatGo
    {
        void Eat();
        void Go();
    }
    interface ISecuriti :IEatGo
    {
        void Guard();
    }
    class Dog :ISecuriti
    {
        public void Go()
        {
            Console.WriteLine("Dog step!");
        }
        public void Eat()
        {
            Console.WriteLine("Dog eat style!");
        }
        public void Guard()
        {
            Console.WriteLine("Dog Securit");
        }
    }
    class Cat : IEatGo
    {
        public void Go()
        {
            Console.WriteLine("Cat step!");
        }
        public void Eat()
        {
            Console.WriteLine("Cat eat style!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ISecuriti dog = new Dog();
            IEatGo cat = new Cat();

            dog.Eat();
            dog.Go();
            dog.Guard();

            Console.WriteLine(new string('_',15));

            cat.Eat();
            cat.Go();

            Console.ReadKey();

           
        }
    }
}
