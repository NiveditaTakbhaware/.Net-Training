using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Rsir27
{
    class Calculate
    {
        public Calculate()
        {
            int sum = 0;
            Console.WriteLine("enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for(int i= num1;i<= num2;i++)
            {
                if(i%17!=0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of number which are not divisible by 17 =" + sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            Console.ReadKey();
        }
    }
}
