using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Rsir5_3
{
    class Shift
    {
        public int number { get; set; }
       public Shift(int num)
        {
            number = num;
            Console.WriteLine("before="+number);
            number <<= 2;                             ///bitwise left shieft
            Console.WriteLine("after="+number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Shift s = new Shift(n);
            Console.ReadKey();
        }
    }
}
