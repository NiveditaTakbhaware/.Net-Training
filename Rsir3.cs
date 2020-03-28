using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir3
{
    public class Triangle
    {
        float v1, v2, v3;
        public void show()
        {
            float perimeter = 0.0f;
            Console.WriteLine("enter the values");
            v1 = float.Parse(Console.ReadLine());
            v2 = float.Parse(Console.ReadLine());
            v3 = float.Parse(Console.ReadLine());
            if (v1 < (v2 + v3) && v2 < (v1 + v3) && v3 < (v1 + v2))
            {
                Console.WriteLine("can make triangle");
                perimeter = v1 + v2 + v3;
            Console.WriteLine("perimeter=" + perimeter);
            }
            else 
            Console.WriteLine("invalid values and can not make triangle");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.show();
            Console.ReadKey();
        }
    }
}
