using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascadingifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a,b,result=0;
           
            Console.WriteLine("1 for addition");
            Console.WriteLine("2 for subtraction");
            Console.WriteLine("3 for multiplication");
            Console.WriteLine("4 for division");
            Console.WriteLine("entre two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("plz press any number from 1 to 4");
            n = Convert.ToInt32(Console.ReadLine());
            if(n == 1)
            {
                result = a + b;
            }
            else if(n == 2)
            {
                result = a - b;
            }
            else if(n == 3)
            {
                result = a * b;
            }
            else if(n == 4)
            {
                if (a > b)
                    result = a / b;
                else
                    Console.WriteLine("error");
            }

            else
            {
                Console.WriteLine("invalid input");
            }
            Console.WriteLine("Result "+ result);
            Console.ReadKey();

               
        }
    }
}
