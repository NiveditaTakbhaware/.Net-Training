using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Rsir27
{
    class Numbers
    {
        public Numbers()
        {
            Console.WriteLine("enter two number");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            for(int i= n1;i< n2;i++)
            {
                if(i%7==2 || i%7==3)
                {
                    Console.WriteLine("numbers are =" + i);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numbers n = new Numbers();
            Console.ReadKey();
        }
    }
}
