using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrobj3
{
    class Program
    {
        public float height { get; set; }
        public float Avg { get; set; }
        public int student { get; set; }

        public void Average(float s)
        {
            Avg = s / student;
            Console.WriteLine("average of students height="+Avg);
        }
        static void Main(string[] args)
        {
            float sum = 0;
            Program p = new Program();
            Console.WriteLine("enter number of students");
            p.student = int.Parse(Console.ReadLine());
            Program[] ht = new Program[p.student];
            for (int i = 0; i < ht.Length; i++)
            {
                ht[i] = new Program();
                Console.WriteLine("enter height of the student");
                ht[i].height = Convert.ToSingle(Console.ReadLine());
               sum = sum + ht[i].height;
               
            }
            p.Average(sum);
            Console.ReadKey();
        }
    }
}
