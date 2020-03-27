using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Ksir3_3
{
    class Shape
    {
        public virtual void show()
        {
            Console.WriteLine("this is shape 0f shape class");
        }
    }
    class Rectangle:Shape
    {
        public override void show()
        {
            Console.WriteLine("this is rectangular shape of rectangle class");
        }
    }
    class Circle: Shape
    {
        public override void show()
        {
            Console.WriteLine("this is  circlular shape");
        }
    }
    class Square:Rectangle
    {
        public void showmsg()
        {
            Console.WriteLine("square is a rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.show();
            Rectangle r = new Square();
            r.show();
            Console.ReadKey();
        }
    }
}
