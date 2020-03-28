using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Rsir27
{
    class Program
    {
        int n1=2, n2=3, n3=4;
        public void lines(int size)
        {
            for(int i=1;i<=size;i++)
            {
                Console.WriteLine("{0}{1}{2}",n1, n2, n3);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter the no. of lines");
            int n = int.Parse(Console.ReadLine());
            p.lines(n);
            Console.ReadKey();
        }
    }
}
