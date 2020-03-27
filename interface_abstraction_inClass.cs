using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_abstract_inClass
{
    interface IAccount
    {
        string Name();
    }
    abstract class Student
    {
        public abstract void hello();
        public virtual string Balance()
        {
            return "balance";
        }
    }
    class Person:Student,IAccount
    {
        int balance = 1000;
       public string name { get; set; }
        public string Name()
        {
            return "name method "+name;
        }
        public override void hello()
        {
            Console.WriteLine("hello method");
        }
         new public string Balance()
        {
           
            return "balance method "+balance;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "nivedita";
            Console.WriteLine(p.Name());
            p.hello();
            Console.WriteLine(p.Balance());
            Console.ReadKey();
        }
    }
}
