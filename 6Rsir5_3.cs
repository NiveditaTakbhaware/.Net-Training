using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Rsir5_3
{
    class Find
    {
        public int number { get; set; }
        int count = 0;
        public void show()
        {
            /*do
            {
                Console.WriteLine("enter number");
                number = int.Parse(Console.ReadLine());
                if(number>0)
                {
                    count++;
                   
                }
                
                else if (number <= 0)
                {
                    Console.WriteLine("inavlid");
                    break;
                }
                Console.WriteLine("positive numbers =" + number);
            } while(true);
            Console.WriteLine("total positive=" + count);*/

            Console.WriteLine("enter number");
            for (int i = 0; number > 0; i++)
            {
                number = int.Parse(Console.ReadLine());
                count++;
                Console.WriteLine("total positive=" + count);
                Console.WriteLine("positive=" + number);
               
                
                if(number<=0)
                {
                    Console.WriteLine("invalid");
                    break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Find f = new Find();
            f.show();
            Console.ReadKey();
        }
    }
}
