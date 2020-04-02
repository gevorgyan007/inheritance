using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class DerivedClass : BaseClass
    {
        //public DerivedClass()
        //{
        //    publicfield = "DerivedClass.publicfield";
        //    protectedfield = "DerivedClass.protectedfield";

        //}
        //public int DerivedField;

        //public DerivedClass(int num1,int num2)
        //    :base(num1)
        //{
        //    this.DerivedField = num2;
        //public int field4;
        //public int field5;

        public override void Method()
        {
           //base.Method();
            Console.WriteLine("Method in DerivedClass!!");
        }

    }
    }

