using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2structureConstructor
{
    struct employee
    {
        public string name;
        public int age;
        public float sal;
         public employee(string a,int b,float c)
        {
            name = a;
            age = b;
            sal = c;
        }
    }
    class Program
    {
       /* public void input(string k,int d,float h)
        {
            
            string n = k;
            int g =d;
            float l = h;
            show(n,g,l);
        }*/
        public void show(string x,int y,float z)
        {
            
            employee e = new employee(x,y,z);
            
            Console.WriteLine("Empname:" + e.name);
            Console.WriteLine("Empage:" + e.age);
            Console.WriteLine("Empsalary:" + e.sal);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            
            Console.WriteLine("enter name and age and salary");
            string k=Console.ReadLine();
            int d= Convert.ToInt32(Console.ReadLine());
            float h = Convert.ToSingle(Console.ReadLine());
            //p.input(k, d, h);
            p.show(k,d,h);
            Console.ReadKey();    
           
        }
    }
}
