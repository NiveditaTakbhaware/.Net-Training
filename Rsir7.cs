using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            Console.WriteLine("enter numbers");
            for(int i=0;i<5;i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (n[i] < 0)
                    Console.WriteLine("number is negative="+n[i]);
                else
                    Console.WriteLine("number is positive="+n[i]);
            }
            Console.ReadKey();
        }
    }
}
