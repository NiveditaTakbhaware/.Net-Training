using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameteraizedConstructor
{
    public class person
    {
        string first, last;
        public person(string fname,string lname)
        {
            first = fname;
            last = lname;
            Console.WriteLine("first and last name is {0} {1}", first, last);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first and last name");
            string fn = Console.ReadLine();
            string ln = Console.ReadLine();
            person p = new person(fn,ln);
            Console.ReadKey();


        }
    }
}
