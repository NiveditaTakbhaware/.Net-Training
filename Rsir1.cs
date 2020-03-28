using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir1
{
    public class number
    {
        int num;
        public void show(int num)
        {
            this.num = num;
            if(num<=10 && num>0)
                Console.WriteLine("number is from 1 to 10");
            else if (num <=20 && num > 10)
                Console.WriteLine("number is from 11 to 20");
            else if (num <=30 && num > 20)
                Console.WriteLine("number is from 21 to 30");
            else if (num <=40 && num > 30)
                Console.WriteLine("number is from 31 to 40");
            else if (num <= 50 && num > 40)
                Console.WriteLine("number is from 41 to 50");
            else if (num <= 60 && num > 50)
                Console.WriteLine("number is from 51 to 60");
            else if (num <= 70 && num > 60)
                Console.WriteLine("number is from 61 to 70");
            else if (num <= 80 && num > 70)
                Console.WriteLine("number is from 71 to 80");
            else if (num > 80)
                Console.WriteLine("number is greater than 80");
            else if (num < 0)
                Console.WriteLine("number is less than zero");   
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            number n = new number();
            n.show(-2);
            Console.ReadKey();
        }
    }
}
