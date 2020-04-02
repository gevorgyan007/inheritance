using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class BaseClass
    {
        ////open field
        //public string publicfield = "public.baseFaild";
        ////закритный поля
        //private string privatefield = "private.baseFaild";
        ////зашитный поля
        //protected string protectedfield = "protected.baseFaild";

        //public void Show()
        //{
        //    Console.WriteLine("{0}--{1}",privatefield, protectedfield);
        //}
        //public int field1;
        //public int field2;
        //public int field3;

        public virtual void Method()
        {
            Console.WriteLine("Method in BaseClass ");
        }

        //public BaseClass()
        //{
        //}
        //public BaseClass(int BaseNumber)
        //{
        //    this.BaseNumber = BaseNumber;
        //}

    }
}
