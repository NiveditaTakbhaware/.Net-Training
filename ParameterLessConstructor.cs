using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterLessconstructor
{
    class Bank
    {
        public int acc;
        public string name;
        public Bank() //constructor is used for initializing the variable
        {
            acc = 123;
            name = "nivi";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            Console.WriteLine("account no {0} is of {1}", b.acc, b.name);
            Console.ReadKey();
        }
    }
}
