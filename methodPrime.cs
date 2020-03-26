using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4methodprime
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int n,res;
                Console.WriteLine("enter the number");
                n = int.Parse(Console.ReadLine());
               res= prime(ref n);
                if (res == 2)
                    Console.WriteLine("prime");
                else
                    Console.WriteLine("not prime");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("code not excuted");
            }
        
            Console.ReadKey();
        }
        static int prime(ref int num)
           
        {
            int k=0;
            int i = 1;
            do
            {
                if (num % i == 0)
                {
                    k = k + 1;
                }
                i++;
            } while (i<=num);
            return k;
           

        }
    }
}
