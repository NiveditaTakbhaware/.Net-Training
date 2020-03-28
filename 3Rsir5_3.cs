using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Rsir5_3
{
    class Reverse
    {
        public int number { get; set; }
        public int rem { get; set; }
        public int rev { get; set; }
        public Reverse()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            number = num;
            Console.WriteLine("before="+number);
            do
            {
                rem = number % 10;
                number = number / 10;
                rev = rev * 10 + rem;
            } while (number != 0);
            Console.WriteLine("after=" + rev);

            /*for(int i=;i>0;)
            {
                rem = number % 10;
                number = number / 10;
                rev = rev * 10 + rem;
            }
            Console.WriteLine("after=" + rev);*/
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Reverse r = new Reverse();
            Console.ReadKey();
        }
    }
}
