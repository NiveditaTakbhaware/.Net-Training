using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Rsir3_3
{
    class Geometric
    {
        public Geometric()
        {
          for(int num=5;num<=1000;)
           {
                Console.WriteLine(num);
                num = num * 2;
           }
       }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geometric g = new Geometric();
            Console.ReadKey();
        }
    }
}
