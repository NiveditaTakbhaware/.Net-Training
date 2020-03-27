using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Ksir3_3
{
    class Member
    {
        public string Name { get; set; }
        public string Address{get;set;}
        public int Age { get; set; }
        public long Phone_Number { get; set; }
        public  double salary { get; set; }
        public  virtual void PrintSalary(double sal)
        {
            salary = sal;
            Console.WriteLine("salary of the member="+salary);
        } 
    }
    class Employee:Member
    {
        public string Specialization;
        public override void PrintSalary(double sal)
        {
            salary = sal;
            Console.WriteLine("salary of the member=" + salary);
        }
        public void showEmployee()
        {
            Console.WriteLine("name=" + Name);
            Console.WriteLine("address=" +Address);
            Console.WriteLine("age=" + Age);
            Console.WriteLine("phone number=" + Phone_Number);
            Console.WriteLine("specialization=" + Specialization);
            
        }
    }
    class Manager : Member
    {
        public string Department;
        public override void PrintSalary(double sal)
        {
            salary = sal;
            Console.WriteLine("salary of the member=" + salary);
        }
        public void showManager()
        {
            Console.WriteLine("name=" + Name);
            Console.WriteLine("address=" + Address);
            Console.WriteLine("age=" + Age);
            Console.WriteLine("phone number=" + Phone_Number);
            Console.WriteLine("department=" + Department);
            

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of employee class
            Console.WriteLine("details of employee:");
            Employee emp = new Employee();
            Console.WriteLine("enter name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("enter address");
            emp.Address = Console.ReadLine();
            Console.WriteLine("enter age");
            emp.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Phone number");
            emp.Phone_Number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter specialization");
            emp.Specialization = Console.ReadLine();
            emp.showEmployee();
            Console.WriteLine("enter salary");
            double sal = double.Parse(Console.ReadLine());
           emp.PrintSalary(sal);
            

            //creating object of manager class
            Console.WriteLine();
            Console.WriteLine("details of manager");
            Manager mag = new Manager();
            Console.WriteLine("enter name");
            mag.Name = Console.ReadLine();
            Console.WriteLine("enter address");
            mag.Address = Console.ReadLine();
            Console.WriteLine("enter age");
            mag.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Phone number");
            mag.Phone_Number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter Department");
            mag.Department = Console.ReadLine();
            mag.showManager();
            Console.WriteLine("enter salary");
            double salary = double.Parse(Console.ReadLine());
            mag.PrintSalary(salary);
           

            Console.ReadKey();

        }
    }
}
