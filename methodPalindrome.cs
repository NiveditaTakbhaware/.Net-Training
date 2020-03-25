using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2methodpalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            pal( ref num);
            Console.ReadKey();
        }
      
        static void pal(ref int num)
        {
            int org, rev = 0, d;
            org = num;
            do
            {
                d =  num % 10;
                 num = num / 10;
                rev = rev * 10 + d;
            } while ( num > 0);
            if (rev == org)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("not palindrome");
        }
    }
    
}
