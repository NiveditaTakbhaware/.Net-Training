using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass3
{
  public   class Program
    {
        public int sum(int n1,int n2)
        {
            
            int sum = n1 + n2;
            return sum;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter two number");
           int n1 = Convert.ToInt32(Console.ReadLine());
           int n2 = Convert.ToInt32(Console.ReadLine());
            int res = p.sum(n1,n2);
            Console.WriteLine("the sum of teo number is = " + res);
            Console.ReadKey();

        }
    }
}
