using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Ksir3_3
{
    class Rectangle
    {
        public float length { get; set; }
        public float breadth { get; set; }
        public Rectangle() //first base class, this constructor is always called  
        {
            //Console.WriteLine("constructor of rectangle");
        }
        public Rectangle(float len, float bre)
        {
            length = len;
            breadth = bre;
        }
        public void area()
        {
            float area = length * breadth;
            Console.WriteLine("Area of rectangle=" + area);
        }
        public void perimeter()
        {
            float perimeter = 2 * (length + breadth);
            Console.WriteLine("perimeter of rectangle=" + perimeter);
        }
    }
    class Square : Rectangle
    {
        public float side { get; set; }
        public Square(float s)  //before calling this base class contructor will be called
        {
            side = s;
            //Console.WriteLine("contructor of square class");
        }
        public new void area()
        {
            float area = side * side;
            Console.WriteLine("Area of square=" + area);
        }
        public new void perimeter()
        {
            float perimeter = 4 * side;
            Console.WriteLine("perimeter of square=" + perimeter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Square[] sq = new Square[10];
            
            for (int i=0;i<10;i++)
            {
                Console.WriteLine();
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());
                sq[i] = new Square(num);
                sq[i].area();
                sq[i].perimeter();
            }
            Console.ReadKey();
        }
    }
}
