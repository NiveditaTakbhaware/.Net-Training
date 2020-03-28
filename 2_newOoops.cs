using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newOops2
{
    class Number
    {
        public void print(int num,char name)
        {
            Console.WriteLine(num+" and "+name);
        }
        public void print(char name, int num)
        {
            Console.WriteLine(name+ " and " + num);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            char name = Convert.ToChar(Console.ReadLine());
            n.print(number,name);
            n.print(name,number);
            Console.ReadKey();
        }
    }
}
