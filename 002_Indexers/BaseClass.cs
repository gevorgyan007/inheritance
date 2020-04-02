using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Indexers
{
    class BaseClass
    {
        private string[] BaseArray = null;

        public BaseClass()
        {
            BaseArray = new string[3];
            BaseArray[0] = "один";
            BaseArray[1] = "два";
            BaseArray[2] = "три";
        }

        public virtual string this[int index]
        {
            get
            {
                return BaseArray[index];
            }
        }
    }
}
