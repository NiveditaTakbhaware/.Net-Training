using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops7
{
    class Area
    {
        float Length { get; set; }
        float Breadth { get; set; }
        float Rectarea { get; set; }
        public Area(float length,float breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public string returnArea()
        {
            Rectarea = Length * Breadth;
            return "area of rectangle is:"+Rectarea;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the values of length and breadth");
            float len = float.Parse(Console.ReadLine());
            float bre = float.Parse(Console.ReadLine());
            Area arr = new Area(len,bre);
            string result= arr.returnArea();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
