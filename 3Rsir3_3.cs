using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Rsir3_3
{
    class Square
    {
        int upto;
        int sq;
        public Square()
        {
            upto = 10;
            sq = 1;
            for(int num=1;num<= upto;num++)
            { 
                sq = num * num;
                Console.WriteLine(sq);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            Console.ReadKey();
        }
    }
}
