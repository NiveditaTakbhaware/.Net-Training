using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodstestcase
{
    public class Program
    {
        public int Prime(int num)
        {
            int k = 0;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());            
                if (num % 2 == 0)
                    k = k + 1;
            if (k == 2)
            return num;

             
        }
        static void Main(string[] args)
        {
        }
    }
}
