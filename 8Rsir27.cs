using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Rsir27
{
    class Program
    {
        int n1 = 2,sq=0,cu=-0;
        public void cal(int s)
        {
            for(int i=1;i<= s;i++)
            {
                sq = n1 * n1;
                cu = n1 * n1 * n1;
                Console.WriteLine("number={0},square={1},cube={2}", n1, sq, cu);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter no. of lines");
            int n = int.Parse(Console.ReadLine());
            p.cal(n);
            Console.ReadKey();
        }
    }
}
