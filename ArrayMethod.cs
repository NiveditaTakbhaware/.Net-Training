using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10arraymethod
{
    class Program
    {
        static void add(out long[] a = new long[5],  out long[] b = new long[5])
        {
            //long[] c = new long[10];
            long c=0;
            int i;
           

            Console.WriteLine("enter 1array");

            for (i = 0; i < 5; i++)
            {
                a[i] = long.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter 2array");

            for (i = 0; i < 5; i++)
            {
                b[i] = long.Parse(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                c =c+a[i] + b[i];
                
            }
            Console.WriteLine("addition of 2 array:"+c);
        }
        static void Main(string[] args)
        {
            
            long[] a = new long[5];
            
            long[] b = new long[5];
            
            add(out a,out b);
            Console.ReadKey();
        }
    }
}
