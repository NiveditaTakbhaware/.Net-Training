using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, org, n1, n2, n3,rev=0;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            org= num;
            //Console.WriteLine(org);
            n1 = num % 10;
            num = num / 10;
            n2 = num % 10;
            num = num / 10;
            n3 = num % 10;
            rev = n1 * 100 + n2 * 10 + n3 * 1;
            if (rev == org)
                Console.WriteLine(org +" is palindrome");
            else
                Console.WriteLine(org +" is not palindrome");
            Console.ReadKey();
            
        }
    }
}
