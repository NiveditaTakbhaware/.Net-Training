using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            float w1,w2,nw1,nw2,avg=0.0f;
            Console.WriteLine("enter the two items weight");
            w1 = Convert.ToSingle(Console.ReadLine());
            w2= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the number of purchases of weighted items");
            nw1=Convert.ToSingle(Console.ReadLine());
            nw2= Convert.ToSingle(Console.ReadLine());
            avg = w1 * nw1+ w2 * nw2 / nw1 + nw2;
            Console.WriteLine("average  value of items=" + avg);
            Console.ReadKey();
        }
    }
}
