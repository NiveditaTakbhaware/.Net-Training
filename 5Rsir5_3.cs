using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Rsir5_3
{
    class Sum
    {
        public int num { get; set; }
        public int rem { get; set; }
        public int Sumof = 0;
        public void Add(int n)
        {
            if (n >= 500)
                Console.WriteLine("please enter below 500");
            else
            {
                num = n;
                do
                {
                    rem = num % 10;
                    num = num / 10;
                    Sumof = Sumof + rem;
                } while (num != 0);
                Console.WriteLine("total=" + Sumof);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            Console.WriteLine("enter number below 500");
            int n1 = int.Parse(Console.ReadLine());
            s.Add(n1);
            Console.ReadKey();
        }
    }
}
