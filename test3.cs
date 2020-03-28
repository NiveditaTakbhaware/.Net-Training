using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("enter the three numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
                Console.WriteLine("max=" + n1);
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine("max=" + n2);
            else
                Console.WriteLine("max=" + n3);
            Console.ReadKey();
                
        }
    }
}
