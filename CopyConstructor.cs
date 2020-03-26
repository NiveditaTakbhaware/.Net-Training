using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public person(int age,string name)  //instance constructor
        {
            Age = age;
            Name = name;
        }
        public person(person pv)  //copy constructor //pv is variable and conatins the data of p obj which have person data type
        {
            Age = pv.Age;
            Name = pv.Name;
           // Age = 21;
        }
        public void show()
        {
            Console.WriteLine("{0} is of {1}",Name,Age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person(23,"nivi");
            p.show();
            //p.Name = "riya";
            person p1 = new person(p);
            p1.show();
            Console.ReadKey();

        }
    }
}
