using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5methodperfect
{
    class Program
    {
        static int perfect(ref int num)
        {
            int add=0,i=1;
           
            do
            {
                if (num % i == 0)
                    add = add + i;
                i++;
            } while (i <num);
            return add;
            

        }
        static void Main(string[] args)
        {
            int n,res;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            res=perfect(ref n);
            if (res ==n)
                Console.WriteLine("perfect");
            else
                Console.WriteLine("not perfect");
            Console.ReadKey();
        }
    }
}
