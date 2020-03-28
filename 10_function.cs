using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass10
{
  public  class Program
    {
        public static int digit()
        {
            int d,num=1234, org,sum=0;
            //Console.WriteLine("enter the number");
            //num = int.Parse(Console.ReadLine());
           // org = num;
            do
            {
                d = num % 10;
                num = num / 10;
                sum = sum + d;
            } while (num != 0);
            return sum;
            //Console.WriteLine("sum of digits=" + sum);
        }
        static void Main(string[] args)
        {
            int res = digit();
            Console.WriteLine("the sum of number 1234 is " + res);
            Console.ReadKey();
        }
    }
}
