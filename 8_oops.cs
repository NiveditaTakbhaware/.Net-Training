using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops8
{
    class Average
    {
        int number1 { get; set; }
        int number2 { get; set; }
        int number3 { get; set; }
        int average { get; set; }
        public void Calculate(int num1,int num2,int num3)
        {
            number1 = num1;
            number2 = num2;
            number3 = num3;
            average = number1 + number2 + number3 / 3;
            Console.WriteLine("average of 3 numbers is : "+average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Average av = new Average();
            Console.WriteLine("enter 3 numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            av.Calculate(n1,n2,n3);
            Console.ReadKey();

        }
    }
}
