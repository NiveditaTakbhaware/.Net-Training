using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        public void sal()
        {
            int empid, hrm=240;
            decimal amt,sal;
            Console.WriteLine("enter the Employee id");
            empid = int.Parse(Console.ReadLine());
            Console.WriteLine(" the hours of a month="+hrm);
           // hrm = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the amount of per hour ");
            amt = Convert.ToDecimal(Console.ReadLine());
            sal = hrm * amt;
            Console.WriteLine("salary of a month of {0} is {1}", empid, sal); 

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.sal();
            Console.ReadKey();
        }
    }
}
