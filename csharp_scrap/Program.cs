using csharp_scrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrap
{
    class Program
    {
        /*
        static void swapbyref(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("program start-oh!");
            Person1 p = new Person1();
            p.firstName = "Bob";
            p.lastName = "MacKenzie";

            Console.WriteLine("{0}, {1}, {2} years old", p.lastName, p.firstName, p.age);
            p.humanstats();

            int x = 1, y = 2;
            Console.WriteLine("1: x is {0}, y is {0}", x, y);
            AuxFuncs af1 = new AuxFuncs();
            af1.swapbyref(ref x, ref y);
            Console.WriteLine("2: x is {0}, y is {0}", x, y);
            Console.ReadLine();
        }
    }
}
