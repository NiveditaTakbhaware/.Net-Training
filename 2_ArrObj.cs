using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrobj2
{
    class Student
    {
        public int rollno { get; set; }
        public int Mathmarks { get; set; }
        public int Scimarks { get; set; }
        public int Engmarks { get; set; }
        public int avg { get; set; }
        public void Avrage()
        {
            avg = (Mathmarks + Scimarks + Engmarks)/3;
            Console.WriteLine("avrage marks of {0} is {1}",rollno,avg);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[8];
            for(int i=0;i<8;i++)
            {
                st[i] = new Student();
                Console.WriteLine("enter roll number");
                st[i].rollno = int.Parse(Console.ReadLine());
                Console.WriteLine("enter marks of maths");
                st[i].Mathmarks = int.Parse(Console.ReadLine());
                Console.WriteLine("enter marks of science");
                st[i].Scimarks = int.Parse(Console.ReadLine());
                Console.WriteLine("enter marks of english");
                st[i].Engmarks = int.Parse(Console.ReadLine());
                st[i].Avrage();

            }
            Console.ReadKey();
        }

    }
}
