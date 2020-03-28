using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rsir27
{
    class Number
    {
        public Number()
        {
            int n3=0;
            Console.WriteLine("enter two numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 < n2)
                Console.WriteLine("Division not possible");
            else
            {
                n3 = n1 / n2;
                Console.WriteLine("result after division=" + n3);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            Console.ReadKey();
        }
    }
}
