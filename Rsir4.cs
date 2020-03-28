using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir4
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            Console.WriteLine("enter two numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("n1=" + n1);
            Console.WriteLine("n2=" + n2);
            if (n1 > n2)
            {
                if (n1 % n2 == 0)
                    Console.WriteLine("{0} is multiplied of {1}", n1, n2);
                else
                    Console.WriteLine("{0} is not multiplied of {1}", n1, n2);
            }
            else
            {
                Console.WriteLine("1st number is smaller than 2nd number");
                Console.WriteLine("swapping is done");
                t = n1;
                n1 = n2;
                n2 = t;
                Console.WriteLine("n1=" + n1);
                Console.WriteLine("n2=" + n2);
                if (n1 % n2 == 0)
                    Console.WriteLine("{0} is multiplied of {1}", n1, n2);
                else
                    Console.WriteLine("{0} is not multiplied of {1}", n1, n2);
            }
            Console.ReadKey();
        }
    }
}
