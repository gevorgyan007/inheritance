using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExentionMethods
{
    static class ExtentionMethods
    {
        public static void ExtentionMethod(this string value,string value1,int k)
        {
            Console.WriteLine(value+value1+k);
        }

       
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            string text = "text Extention";
            string text2 = "text Extention22+++";
            int g = 5;
           
            text.ExtentionMethod(text2,g);
            
            Console.ReadKey();

            

        }
    }
}
