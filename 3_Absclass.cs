using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass3
{
    abstract class Marks
    {
        public int marks1 { get; set; }
        public int marks2 { get; set; }
        public int marks3 { get; set; }
        public int marks4 { get; set; }
        public int sum { get; set; }
        public float percentage { get; set; }
        abstract public float getPercentage();

    }
    class A: Marks
    {
        public A(int m1,int m2,int m3)
        {
            marks1 = m1;
            marks2 = m2;
            marks3 = m3;
            sum =m1+m2+m3;
        }
        override public float getPercentage()
       {
            percentage = (sum / 300.0f) * 100.0f;
            return percentage;
        }
    }
    class B : Marks
    {
        public B(int m1, int m2, int m3,int m4)
        {
            marks1 = m1;
            marks2 = m2;
            marks3 = m3;
            marks4 = m4;
            sum = m1 + m2 + m3 + m4;
        }
        override public float getPercentage()
        {
             percentage = (sum / 400.0f) * 100.0f;
            return percentage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter marks out 100");
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            int m4 = int.Parse(Console.ReadLine());
            A a = new A(m1,m2,m3);
            float res=a.getPercentage();
            Console.WriteLine("percentage if A="+res);

            B b = new B(m1,m2, m3,m4);
            float rest = b.getPercentage();
            Console.WriteLine("percentage if B=" + rest);
            Console.ReadKey();  
        }
    }
}
