using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Rsir27
{
    class Program
    {
        int[] math = new int[5];
        public void cal()
        {
            int avg = 0, sum = 0;
            Console.WriteLine("enter maths marks");
            for (int i = 0; i < 5; i++)
            {
                math[i] = int.Parse(Console.ReadLine());
                if (math[i] > 0)
                {
                    sum = sum + math[i];
                    //    Console.WriteLine("sum=" + sum);
                    avg = sum / 5;   
                }
                else
                
                    //Console.WriteLine("invalid marks");
                    break;
            }

            Console.WriteLine("average of math marks = " + avg);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.cal();
            Console.ReadKey();
        }
    }
}
