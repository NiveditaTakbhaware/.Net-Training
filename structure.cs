using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1structure
{
    struct emloyee
    {
       public string name;
       public int age;
       public float sal;
    }
    class Program
    {
        static void Main(string[] args)
        {
            emloyee e;
            Console.WriteLine("enter name and age");
            e.name = Console.ReadLine();
            e.age = Convert.ToInt32(Console.ReadLine());
            e.sal = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("EmpName:"+e.name+"\n"+"Empage:"+e.age+"\n"+"Empsalary:"+e.sal);
            Console.ReadKey();

               
        }
    }
}
