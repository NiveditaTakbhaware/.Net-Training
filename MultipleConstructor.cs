using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleConstructor
{
    public class Employee
    {
        public static int salary;
        static Employee()
        {
            salary = 120000;
            Console.WriteLine("sal="+salary);
        }
        public Employee(int ansal)
        {
            salary = ansal;
        }
        public Employee(int wesal,int nofwe)
        {
            salary = wesal * nofwe;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("sal=" + Employee.salary);
            Employee e = new Employee(500000);
            Console.WriteLine("salary="+ Employee.salary);
            Employee e1 = new Employee(10000, 4);
            Console.WriteLine("sal=" + Employee.salary);
            Console.ReadKey();
        }
    }
}
