using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    class Singlton
    {
        private static Singlton instance = null;

        protected Singlton()
        {

        }

        public static Singlton Method()
        {
            if (instance == null)
                return instance = new Singlton();
            else

                return instance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singlton instance1 = Singlton.Method();
            Singlton instance2 = Singlton.Method();

            if (instance1 == instance2)
                Console.WriteLine("equal");
         
            Console.ReadKey();
        }
    }
}
