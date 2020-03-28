using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Rsir5_3
{
    class Find
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public void Swap(int num1,int num2)
        {
            number1 = num1;
            number2 = num2;
            Console.WriteLine("1 number="+number1);
            Console.WriteLine("2 number=" + number2);
            int sum = number1 + number2;
            number1 = sum - number1;
            number2 = sum - number2;
            Console.WriteLine();
            Console.WriteLine("after swapping");
            Console.WriteLine("1 number=" + number1);
            Console.WriteLine("2 number=" + number2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Find f = new Find();
            Console.WriteLine("enter two numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            f.Swap(n1,n2);
            Console.ReadKey();
        }
    }
}
