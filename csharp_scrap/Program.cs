using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program start-oh!");
            Person1 p = new Person1();
            p.firstName = "Bob";
            p.lastName = "MacKenzie";

            Console.WriteLine("{0}, {1}, {2} years old", p.lastName, p.firstName, p.age);
            p.humanstats();


            Console.ReadLine();
        }
    }
}
