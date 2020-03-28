using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateConstructor
{
    public class counter
    {
        public static int currntcount;
        private counter()
        {
            int salary = 1000;
            Console.WriteLine("sal=" + salary);
        }
        public counter(int salary)
        {
             //salary = 1000;
            Console.WriteLine("sal=" + salary);
        }
        public static int incr()
        {
            return currntcount++;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            counter.currntcount = 100;
            Console.WriteLine("current value=" + counter.currntcount);
            counter.incr();
            //counter c = new counter();//inaccessible due to protection i.e private
            Console.WriteLine("current value="+counter.currntcount);
            counter c = new counter(5000);
            Console.ReadKey();
            
        }
    }
}
