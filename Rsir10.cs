using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sq;
            //Console.WriteLine("enter the numbers");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} is even", i);
                    sq = i * i;
                    Console.WriteLine("square of {0} is = {1}", i, sq);
                }
            }
            Console.ReadKey();
        }
    }
}
