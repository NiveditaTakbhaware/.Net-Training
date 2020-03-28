using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass11
{
   public class Program
    {
        public static void factorial()
        {
            int fact = 1,num=5,i=1;

                fact = fact * i;
            i++;
            num--;
            factorial();
            if (num == 0)
                return;
                                       
           
           
           
            Console.WriteLine(fact);
        }
        static void Main(string[] args)
        {
            factorial();
            Console.ReadKey();
        }
    }
}
