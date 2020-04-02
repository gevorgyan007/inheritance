using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCovariant
{
    interface IAnimal
    {
        void Voice();
    }
    struct Dog : IAnimal
    {
        private string name;

        

        public Dog(string name)
        {
            this.name = name;
        }
        
        public void Voice()
        {
            Console.WriteLine("Dog voice!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Dog[] dogs = new Dog[5] {new Dog(), new Dog(), new Dog(), new Dog(), new Dog(), };
           
          
            //IAnimal[] animal = dogs;

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
