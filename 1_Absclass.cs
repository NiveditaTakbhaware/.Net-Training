using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass1
{
    abstract class Parent
    {
        abstract public void message();
    }
    class Subclass1:Parent
    {
       override public void message()
        {
            Console.WriteLine("this is subclass 1");
        }
        
    }
    class Subclass2 : Parent
    {
        override public void message()
        {
            Console.WriteLine("this is subclass 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Subclass1 s1 = new Subclass1();
            s1.message();
            Subclass2 s2 = new Subclass2();
            s2.message();
           
            Console.ReadKey();
        }
    }
}
