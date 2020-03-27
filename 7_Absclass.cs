using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass7
{
        abstract class Shape
        {
            public double Area { get; set; }
            abstract public void RectangleArea(int l, int b);
            abstract public void SquareArea(int s);
            abstract public void CircleArea(int r);
        }
        class Area : Shape
        {
            override public void RectangleArea(int l, int b)
            {
                Area = l * b;
                Console.WriteLine("area of rectangle=" + Area);
            }
            override public void SquareArea(int s)
            {
                Area = s * s;
                Console.WriteLine("area of square=" + Area);
            }
            override public void CircleArea(int r)
            {
                Area = 2 * 3.14 * r * r;
                Console.WriteLine("area of circle=" + Area);
            }
        }
       

    class Program
    {
        static void Main(string[] args)
        {
            Area[] arr = new Area[5];
            for(int i=0;i<5;i++)
            {
                arr[i] = new Area();
                Console.WriteLine("enter length and breadth");
                int l = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                arr[i].RectangleArea(l,b);
            }
            for (int i = 0; i < 5; i++)
            {
                arr[i] = new Area();
                Console.WriteLine("enter side");
                int s = int.Parse(Console.ReadLine());
                arr[i].SquareArea(s);
            }
            for (int i = 0; i<=5; i++)
            {
                arr[i] = new Area();
                Console.WriteLine("enter radius");
                int r = int.Parse(Console.ReadLine());
                arr[i].CircleArea(r);
            }
            Console.ReadKey();
        }
    }
}
