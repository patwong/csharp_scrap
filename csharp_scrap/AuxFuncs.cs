using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrap
{
    class AuxFuncs
    {
        int x, y;
        void swapbyref(ref int a, ref int b)
        {
                 int temp = a;
                a = b;
                b = temp;
        }
        public int X
        {
            get;set;
        }
        public int Y
        {
            get; set;
        }
    }
}