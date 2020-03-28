using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the seconds");
            int s = int.Parse(Console.ReadLine());
            int h = 3600/s;
            int m = (s - (3600 / h)) / 60;
            int sec = (s - (3600 * h) - (m * 60));
            Console.WriteLine("hours=" + h);
            Console.WriteLine("minute=" + m);
            Console.WriteLine("seconds=" + sec);
            Console.ReadKey();
        }
    }
}
