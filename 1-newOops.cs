using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newOops1
{
    class PrintNumber
    {
        public void printn(int num)
        {
            Console.WriteLine(num+ " is interger type");
        }
        public void printn(float num)
        {
            Console.WriteLine(num + " is float type");
        }
        public void printn(double num)
        {
            Console.WriteLine(num + " is double type");
        }
        public void printn(string num)
        {
            Console.WriteLine(num + " is string type");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumber pn = new PrintNumber();
            Console.WriteLine("enter number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            pn.printn(number1);
            Console.WriteLine("enter number");
            float number2 = Convert.ToSingle(Console.ReadLine());
            pn.printn(number2);
            Console.WriteLine("enter number");
            double number3 = Convert.ToDouble(Console.ReadLine());
            pn.printn(number3);
            Console.WriteLine("enter number");
            string number4 =Console.ReadLine();
            pn.printn(number4);
            Console.ReadKey();
        }
    }
}
