using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrap
{
    class Person1
    {
        const double NumberOfLegs = 2;
        const string Species = "Homo Sapien sapien";
        static readonly DateTime SomeTime = DateTime.Now;
        public string firstName;
        public string lastName;
        public int age;
        public void humanstats()
        {
            Console.WriteLine("number of legs: {0}", NumberOfLegs);
            Console.WriteLine("species: {0}", Species);
            Console.WriteLine("datetime: {0}", SomeTime);
        }
    }

}
