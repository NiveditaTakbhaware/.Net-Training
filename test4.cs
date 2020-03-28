using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d, f,avg;
            Console.WriteLine("enter the distance in km");
            d = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the fuel in liters");
            f = decimal.Parse(Console.ReadLine());
            avg = d / f;
            Console.WriteLine("bike's avg consumption=" + avg);
            Console.ReadKey();
        }
    }
}
