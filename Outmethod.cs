using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7outmethod
{
    class Program
    {
        static void show(out int n)
        {
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            n++;
            Console.WriteLine("number is " + n);
        }
        static void Main(string[] args)
        {
            int k;
            show(out k);
            
            Console.ReadKey();
        }
    }
}
