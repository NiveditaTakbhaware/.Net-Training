using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3methodarmstrong
{
    class Program
    {
        static int arm(ref int num )
        {
            int rev = 0, org, d;
            org = num;
            do
            {
                d = num % 10;
                num = num / 10;
                rev = rev + d * d * d;
            } while (num != 0);
            return rev;
        }
        static void Main(string[] args)
        {
            int n, res,cn;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            cn = n; 
            res = arm(ref n);
            if (res == cn)
                Console.WriteLine("armstrong");
            else
                Console.WriteLine("not armstrong");
            Console.ReadKey();
          
            
        }
    }
}
