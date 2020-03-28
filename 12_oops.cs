using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops12
{
    class Employee
    {
        public double Salary { get; set; }
        public int Hours { get; set; }
        public void getInfo(double salary,int HrperDay)
        {
            Salary = salary;
            Hours = HrperDay;
        }
        public void Addsal()
        {
            Salary = Salary + 1000;
            Console.WriteLine("final salary after adding salary  =" + Salary);
        }
        public void AddWork()
        {
            Salary = Salary + 500;
            Console.WriteLine("final salary after adding hours work=" + Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("enter salary");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("enter hours per day");
            int h =Convert.ToInt32(Console.ReadLine());
            emp.getInfo(sal,h);
            if (sal < 5000)
            {
                emp.Addsal();
            }

            else if (h>6)
            {
                emp.AddWork();
            }
            else
            {
                Console.WriteLine("final salary=" + sal);
            }
            Console.ReadKey();

        }
    }
}
