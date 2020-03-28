using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops3ass
{
    class Triangle
    {
        public Triangle()
        {

            float area, perimeter; //area=s1*s2/2(6); perimeter=s1+s2+s3(12)
            int s1 = 3, s2 = 4, s3 = 5;
            area = s1 * s2 / 2;
            Console.WriteLine("Area=" + area);
            perimeter = s1 + s2 + s3;
            Console.WriteLine("perimeter=" + perimeter);
        }
    }
     class Program
      {
        static void Main(string[] args)
        {
                Triangle t = new Triangle();
                Console.ReadKey();
        }
     }
   
}
