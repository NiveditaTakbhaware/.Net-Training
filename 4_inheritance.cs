using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ksir3_3
{
    class Rectangle
    {
        public float length { get; set; }
        public float breadth { get; set; }
        public Rectangle() //first base class, this constructor is always called  
        {
            //Console.WriteLine("constructor of rectangle");
        }
        public Rectangle(float len,float bre)
        {
            length = len;
            breadth = bre;
        }
      public void area()
        {
            float area = length* breadth;
            Console.WriteLine("Area of rectangle="+area);
        }
        public void perimeter()
        {
            float perimeter = 2 * (length + breadth);
            Console.WriteLine("perimeter of rectangle=" + perimeter);
        }
    }
    class Square:Rectangle
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
            
            Rectangle r = new Rectangle(4,5);
            Square s1 = new Square(6);
            Console.WriteLine("rectangle details");
            r.area();
            r.perimeter();
            Console.WriteLine();
            Console.WriteLine("square details");
            s1.area();
            s1.perimeter();
            Console.ReadKey();
        }
    }
}
