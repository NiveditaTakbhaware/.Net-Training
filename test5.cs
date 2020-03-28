using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the start & end  points of x");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the start & end  points of y");
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int dis = (x2 - x1 )*(x2-x1) + (y2- y1) *(y2-y1);

            Console.WriteLine("distance of two points=" +dis);
            Console.ReadKey();

        }
    }
}
