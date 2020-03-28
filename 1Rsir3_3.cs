using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Rsir3_3
{
    class Arithmetic
    {
        public Arithmetic(int upto)
        {
            for(int num=1;num< upto;)
            {
                Console.WriteLine(num);
                num = num + 3;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic ari = new Arithmetic(100);
            Console.ReadKey();
                
        }
    }
}
