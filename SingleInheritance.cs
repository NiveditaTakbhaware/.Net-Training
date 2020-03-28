using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
   public class Person
    {
         //protected internal static string Name { get; set; }
        protected internal static string Name = "nivi";
        public static string Address { get; set; }
    }
    class Employee : Person
    {
       public  static string  name, address;
        private static double salary { get; set; }
        public static int No { get; set; } 
        public  void get(double Salary,int Empno)
        {
            name = Name;
            address = Address;
             salary = Salary;
             No = Empno;
         }
        public void show()
        {
            Console.WriteLine();
            Console.WriteLine("employee deatils");
            Console.WriteLine("Empid={0},Empname={1},Empaddress={2},Empsalary{3}", No, name, address, salary);
           
        }
    }
    /*class student:Employee
    {
        public string Subject { get; set; }
        public double Marks { get; set; }
        public void set ()
        {
           // No = 123;
            //name = "akshu";
            //address = "puna";
            //salary = 50000;
            Console.WriteLine();
            Console.WriteLine("enter subject");
            Subject = Console.ReadLine();
            Console.WriteLine("enter marks");
            Marks =double.Parse( Console.ReadLine());
        }
        public void Sshow()
        {
            Console.WriteLine();
            Console.WriteLine("employee and student  deatils");
            Console.WriteLine("Empid={0},Empname={1},Empaddress={2},Empsalary{3}", No, name, address, salary);
            Console.WriteLine();
            Console.WriteLine("StudentSubject={0},StudentMarks={1}", Subject, Marks);
        }

    }*/
    class student:Person
    {

        public string Subject { get; set; }
        public double Marks { get; set; }
        public void set()
        {
            Console.WriteLine();
           // Console.WriteLine("enter name");
            //Name = Console.ReadLine();
            //Console.WriteLine("enter address");
            //Address = Console.ReadLine();
            Console.WriteLine("enter subject");
            Subject = Console.ReadLine();
            Console.WriteLine("enter marks");
            Marks = double.Parse(Console.ReadLine());
        }
        public void Sshow()
        {
            Console.WriteLine();
            Console.WriteLine("students details");
            Console.WriteLine("Studentname={0},Studentaddress={1},StudentSubject={2},StudentMarks={3}", Name,Address,Subject, Marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter salary");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
             Employee.Name=Console.ReadLine();
            Console.WriteLine("enter address");
            Employee.Address = Console.ReadLine();
            emp.get(sal,num);
            emp.show();
            student s = new student();
            s.set();
            s.Sshow();
            Console.ReadKey();
        }
    }
}
