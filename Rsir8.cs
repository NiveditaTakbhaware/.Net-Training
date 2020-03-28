using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir8
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0,sum=0;
            int[] n = new int[5];
            Console.WriteLine("enter the numbers");
            for(int i=0;i<5;i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (n[i] > 0)
                {
                    //Console.WriteLine("positive=" + n[i]);
                    sum = sum + n[i];
                    c++;
                }
            }
            Console.WriteLine("total positive number="+c);
            Console.WriteLine("addition of positive numbers=" + sum);
            int avg = sum /5;
            Console.WriteLine("avg of positive numbers=" +avg);
            Console.ReadKey();
        }
    }
}
