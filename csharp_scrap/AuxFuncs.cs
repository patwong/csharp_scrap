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
        public bool MatchesAny(string search, params string[] tests)
        {
            foreach (var test in tests)
            {
                if (test.Contains(search)) {
                    return true;
                }
            }
            return false;
        }
    }
    class Resource { }
    class Factory
    {
        int xyz;
        public static bool Build(out Resource r)
        {
            r = null;
            try
            {
                r = new Resource();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
    class ConstructorDemo
    {
        static int staticX;
        static int staticY = 10;
        static ConstructorDemo()
        {
            Console.Write("Static Constructor: x={0} and y={1}", staticX, staticY);
        }
        int instanceX;
        int instanceY = 5;
        public ConstructorDemo()
        {
            Console.Write("Instance Constructor: x={0} and y={1}", instanceX, instanceY);
        }
    }
}