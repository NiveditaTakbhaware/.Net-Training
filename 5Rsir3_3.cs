using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Rsir3_3
{
    class Triangular
    {
        public Triangular()
        {
           
            for(int tri=1;tri<=10;tri++)
            {
               for(int incr=2;incr<=10;incr++)
                {
                    Console.WriteLine(tri);
                    tri = tri + incr;
                    
                }
            }
        }
  }
    class Program
    {
        static void Main(string[] args)
        {
            Triangular t = new Triangular();
            Console.ReadKey();
        }
    }
}
