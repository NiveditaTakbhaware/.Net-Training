using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizers_destructor
{
    class student
    {
        static int rno;
        static long mobile;
        string name, add, stream;
        public student()
        {
            Console.WriteLine("enter roll no, mobile, name, address, stream (parameterless) ");
            rno = Convert.ToInt32(Console.ReadLine());
            mobile = Convert.ToInt64(Console.ReadLine());
            name = Console.ReadLine();
            add = Console.ReadLine();
            stream = Console.ReadLine();
            Console.WriteLine("{0} {1} {2} {3} {4}", rno, mobile, name, add, stream);
            Console.WriteLine(); 
        }
        public student(int r,string n)
        {
            name = n;
            rno = r;
            Console.WriteLine("name=" + n + " and" + " rollno=" + rno + " (parametarized)");
            Console.WriteLine();
        }
        public student(student st)
        {
            name = st.name;
            //rno = student.rno;
            Console.WriteLine("name=" + name + " (copy of less)");
            Console.WriteLine("rollno=" + rno + " (copy of less)");
            Console.WriteLine();
        }
        static student()
        {
            rno = 12;
            mobile = 7709786424;
            Console.WriteLine("roll no =" + rno + " and " + " mobile =" + mobile + " (static)");
            Console.WriteLine();
        }
        ~student()
        {
            Console.WriteLine("all constructor called");
            Console.ReadKey();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            student s1 = new student(62, "nivi");
                                         //student s = new student();
            student std = new student(s);//here which value gets first it takes it in the case of static variable
           
            Console.ReadKey();
            
        }
    }
}
