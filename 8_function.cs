using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass8
{
  public  class Program
    {
        public static int fab(int a)
        {
           // Console.WriteLine("enter the number");
          //  int a = int.Parse(Console.ReadLine());
            int f3=0,f1 = 0, f2 = 1 ;
            Console.WriteLine("sequence");
           Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 2; i < a; i++)
            {

                f3 = f1 + f2;

                f1 = f2;
                f2 = f3;
                Console.WriteLine(f3);
            }
            return f3;
        }
        static void Main(string[] args)
        {
            int rs=fab(5);
            //Console.WriteLine(rs);
            Console.ReadKey();
        }
    }
}
