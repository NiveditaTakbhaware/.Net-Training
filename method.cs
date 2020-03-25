using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1method
{
    class Program
    {
         void arm()
        {
            int num, rev = 0, org, d;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            org = num;
            while(num!=0)
            {
                d = num % 10;
                num = num / 10;
                rev = rev+ d * d * d;
            }
            if (rev == org)
                Console.WriteLine("armstrong");
            else
                Console.WriteLine("not armstrong");         
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.arm();
            Console.ReadKey();

        
        }
       
        


        
    
   

    }
}
