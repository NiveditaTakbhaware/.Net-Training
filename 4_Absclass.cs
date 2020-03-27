using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass4
{
    abstract class Machine
    {
         public Machine()
        {
            Console.WriteLine("this is constructor of abstract class");
        }
        abstract public void A_method();
        public void method()
        {
            Console.WriteLine("this is normal method of abstract class");
        }
    }
    class Subclass:Machine
    {
        public override void A_method()
        {
           Console.WriteLine("this is abstract method from subclass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Subclass s = new Subclass();
            s.A_method();
            s.method();
            Console.ReadKey();
        }
    }
}
