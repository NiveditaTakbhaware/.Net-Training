using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Rsir27
{
    class quad
    {
        //static int x, y;
        public void find(int x,int y)
        {
            if (x > 0 && y > 0)
                Console.WriteLine("x and y belongs to quadrant I");
            else if(x<0 && y>0)
                Console.WriteLine("x and y belongs to quadrant II");
            else if (x < 0 && y < 0)
                Console.WriteLine("x and y belongs to quadrant III");
            else if (x > 0 && y < 0)
                Console.WriteLine("x and y belongs to quadrant IV");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            quad q = new quad();
            Console.WriteLine("enter the two values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            q.find(a, b);
            Console.ReadKey();
        }
    }
}
