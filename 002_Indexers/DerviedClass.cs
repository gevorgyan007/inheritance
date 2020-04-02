using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Indexers
{
    class DerviedClass : BaseClass
    {
        private string[] DerviedArray = null;

        public DerviedClass()
        {
            DerviedArray = new string[3];
            DerviedArray[0] = "one";
            DerviedArray[1] = "two";
            DerviedArray[2] = "tree";
        }

        public override string this[int index]
        {
            get
            {
                return base[index] + "-" + DerviedArray[index];
            }
        }
    }
}
