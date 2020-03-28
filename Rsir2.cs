using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir2
{
    public class Abc
    {
        public void sumof()
        {
            int sum = 0;
            int[] num = new int[5];
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<5;i++)
            {
                if (num[i] % 2 != 0)
                 sum = sum + num[i];
            }
            Console.WriteLine("sum of odd numbers:" + sum);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Abc a = new Abc();
            a.sumof();
            Console.ReadKey();
        }
    }
}
