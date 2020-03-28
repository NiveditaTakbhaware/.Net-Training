using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4rsir5_3
{
    class Find
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int n3 { get; set; }
        public int n4 { get; set; }
        public int max{get;set;}
        public int min { get; set; }
        public int dif { get; set; }
        public void diff()
        {
            Console.WriteLine("enter 4 real numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3 && n1 > n4)
                max = n1;
           else if (n2 > n1 && n2 > n3 && n2 > n4)
                max = n2;
           else if (n3 > n1 && n3 > n2 && n3 > n2)
                max = n3;
            else 
                max = n4;


            if (n1 < n2 && n1 < n3 && n1 < n4)
                min = n1;
            else if (n2 < n1 && n2 < n3 && n2 < n4)
                min = n2;
            else if (n3 < n1 && n3 < n2 && n3 < n4)
                min = n3;
            else 
                min = n4;

            dif = max - min;
            Console.WriteLine("difference="+dif);



        }
    }
            
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Find f = new Find();
            f.diff();
            Console.ReadKey();
        }
    }
}
