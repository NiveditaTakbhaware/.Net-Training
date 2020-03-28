using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Rsir27
{
    class check
    {
        int n1, n2;
        public check()
        {
            Console.WriteLine("enter two numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1 < n2)
                Console.WriteLine("number is ascending order");
            else
                Console.WriteLine("number is descending order");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            check c = new check();
            Console.ReadKey();
        }
    }
}
