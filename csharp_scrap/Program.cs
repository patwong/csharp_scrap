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

            //works
            //Console.WriteLine("{0}, {1}, {2} years old", p.lastName, p.firstName, p.age);
            //p.humanstats();

            //int x = 1, y = 2;
            //Console.WriteLine("1: x is {0}, y is {1}", x, y);
            AuxFuncs af1 = new AuxFuncs();

            //don't think swap works
            //af1.swapbyref(ref x, ref y);
            //af1.X = 1; af1.Y = 2;

            //Console.WriteLine("2: x is {0}, y is {1}", af1.X, af1.Y);

            if (af1.MatchesAny("green", "blue sky", "graen grass", "red apple"))
                Console.WriteLine("true!");
            else
                Console.WriteLine("false!");
            string zs;
            zs.Concat("as", "many", "strings", "as", "we", "want", "...");
            Console.WriteLine(zs);
            //Resource r;
            //if (Factory.Build(out r))
            //{
            //    /* */
            //}




            Console.ReadLine();
        }
    }
}
