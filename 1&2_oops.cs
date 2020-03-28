using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1ass
{
    /* class Student
     {
          public string Name;
         public int Roll_no;
     }
     class Program
     {
         static void Main(string[] args)
         {
             Student s = new Student();
             Console.WriteLine("enter name");
             s.Name = Console.ReadLine();
             Console.WriteLine("enter rollno");
             s.Roll_no = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("name= " + s.Name + " &" + " rollno= " + s.Roll_no);
             Console.ReadKey();
        }
    }*/

    class Student
    {
        public string Name,Address;
        public int Roll_no;
        public long Phoneno;
        public void show()
        {
            Console.WriteLine("name= " +Name + " &" + " rollno= " + Roll_no+ "adress= " + Address + " &" + " phone= " + Phoneno);
            //Console.WriteLine("adress= " + Address + " &" + " phone= " + Phoneno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
           // Console.WriteLine("enter name");
            s.Name = "sam";
            Console.WriteLine("enter rollno");
            s.Roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter address");
            s.Address = Console.ReadLine();
            Console.WriteLine("enter phone number");
            s.Phoneno = Convert.ToInt64(Console.ReadLine());
            s.show();

            Student s2 = new Student();
            //Console.WriteLine("enter name");
            Console.WriteLine();
            s2.Name = "john";
            Console.WriteLine("enter rollno");
            s2.Roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter address");
            s2.Address = Console.ReadLine();
            Console.WriteLine("enter phone number");
            s2.Phoneno = Convert.ToInt64(Console.ReadLine());
            s2.show();

            Console.ReadKey();
        }
    }
}

