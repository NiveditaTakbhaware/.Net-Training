using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops10
{
    class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string YearofJoing { get; set; }
        public void Show()
        {
           Console.WriteLine("{0}       {1}        {2}        {3} ",Name,Address,Salary,YearofJoing);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            Employee[] emp = new Employee[3];
            for (int i = 0; i < 3; i++)
            { 
                    emp[i] = new Employee();
                    Console.WriteLine("enter name");
                    emp[i].Name = Console.ReadLine();
                    Console.WriteLine("enter address");
                    emp[i].Address = Console.ReadLine();
                    Console.WriteLine("enter salary");
                    emp[i].Salary = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter year of joing");
                    emp[i].YearofJoing = Console.ReadLine();  
            }
            Console.WriteLine("Name     Address      Salary     Year");
            for (int i = 0; i < 3; i++)
            {
                              
                    emp[i].Show();
               
            }
                    Console.ReadKey();
        }
    }
}
