using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops6
{
    class Area
    {
        float Length { get; set; }
        float Breadth { get; set; }
        float RectArea { get; set; }
        public void SetDim(float length,float breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public float GetArea()
        {
            RectArea = Length * Breadth;
            return RectArea;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area ar = new Area();
            Console.WriteLine("enter the values of length and breadth");
            float len = float.Parse(Console.ReadLine());
            float bre = float.Parse(Console.ReadLine());
            ar.SetDim(len, bre);
            float result= ar.GetArea();
            Console.WriteLine("area of rectangle is {0}",result);
            Console.ReadKey();
        }
    }
}
