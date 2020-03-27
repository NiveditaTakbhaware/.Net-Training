using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Ksir3_3
{
    class Parent
    {
        public void show()
        {
            Console.WriteLine("this is parent class");
        }
    }
     class Child:Parent
        {
            public new void show()
            {
                Console.WriteLine("this is child class");
            }

        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.show();
           Child c = new Child();
            c.show();
            Parent p1 = new Child();
            p1.show();
            Console.ReadKey();
        }
    }
}
