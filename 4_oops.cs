using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops4ass
{
    class Traiangle
    {
        public Traiangle(int s1,int s2,int s3)
            {
            int area, perimeter;
            area = s1 * s2 / 2;
            perimeter = s1 + s2 + s3;
            Console.WriteLine("area= " + area + " and" + "perimeter= " + perimeter);
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Traiangle t = new Traiangle(3,4,5);
            Console.ReadKey();
        }
    }
}
