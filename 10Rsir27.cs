using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Rsir27
{
    class Program
    {
        int p, q;
        public void show(int b)
        {
            Console.WriteLine("enter the value of p ,q");
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("the value of q ="+q);
            //b = int.Parse(Console.ReadLine());
            for(int i=1;i<= b;i++)
            {
                Console.WriteLine(p);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter the value of b");
            int n = int.Parse(Console.ReadLine());
            p.show(n);
            Console.ReadKey();
        }
    }
}
