using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] even = new int[50];
            int c= 0;
            for(int i=0;i<50;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("even=" + i);
                    c++;
                }
                
            }
            Console.WriteLine("there are {0} even numbers", c);
            Console.ReadKey();
        }
    }
}
