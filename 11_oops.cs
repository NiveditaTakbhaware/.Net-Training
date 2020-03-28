using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops11
{
    class AddDistance
    {
        public int Inch1 { get; set; }
        public int Inch2 { get; set; }
        public float Feet1 { get; set; }
        public float Feet2 { get; set; }
        public float Feetadd { get; set; }
        public int Inchadd { get; set; }
        public void AddOf()
        {
            Feetadd = Feet1 + Feet2;
            Inchadd = Inch1 + Inch2;
            Console.WriteLine("feets addition="+Feetadd);
            Console.WriteLine("inchs addition="+Inchadd);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AddDistance ad = new AddDistance();
            Console.WriteLine("enter the two values of feet to find the distance");
            ad.Feet1 = Convert.ToSingle(Console.ReadLine());
            ad.Feet2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the two values of inches to find the distance");
            ad.Inch1 = Convert.ToInt32 (Console.ReadLine());
            ad.Inch2 = Convert.ToInt32(Console.ReadLine());
            ad.AddOf();
            Console.ReadKey();
        }
    }
}
