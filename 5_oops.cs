using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops5
{
    class Rectangle
    {
        int Length { get; set; }
        int Breadth { get; set; }
        int area { get; set; }
        public Rectangle(int length,int breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public int  Area()
        {
            area = Length * Breadth;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Rectangle[] r = new Rectangle[2];
           
             for(int i=0;i<2;i++)
              {
                Console.WriteLine("enter values of length and breadth");
                int len = int.Parse(Console.ReadLine());
                int bre = int.Parse(Console.ReadLine());
                r[i] = new Rectangle(len, bre);
                int result=r[i].Area();
                Console.WriteLine("Area="+result);
                Console.ReadKey();
            }
            
           
        }
    }
}

