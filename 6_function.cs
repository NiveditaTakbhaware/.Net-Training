using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass6
{
    public class Program
    {
        public void  swap(int a,int b)
        {
             int z = a;
             a = b;
             b = z;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            
                        
        }
        static void Main(string[] args)
        {
            int a = 5,b=6;
            Program p = new Program();
            p.swap(a, b);
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadKey();

        }
    }
}
