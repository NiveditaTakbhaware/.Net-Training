using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrobj1
{
    class Employee
    {
      public string Name { get; set; }
      public double  salary { get; set; }
      public string Date { get; set; }
        public void show()
        {
            Console.WriteLine("name=" + Name);
            Console.WriteLine("salary=" + salary);
            Console.WriteLine("dtae of joining=" + Date);
        }
    }                                                                                                                                                                                                              
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee[] emp = new Employee[10];
            for(int i=0;i<10; i++)
            {
                emp[i] = new Employee()       ;
                Console.WriteLine("enter name");
                emp[i].Name = Console.ReadLine();
                Console.WriteLine("enter salary");
                emp[i].salary =double.Parse( Console.ReadLine());
                Console.WriteLine("enter date");
                emp[i].Date = Console.ReadLine();
                emp[i].show();
            }
           
            Console.ReadKey();
        }
    }
}
