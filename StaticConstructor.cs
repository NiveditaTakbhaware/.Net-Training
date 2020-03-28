using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticConstructor
{
    public class adult
    {
        public  static int n;
        static adult()
        {
          n = 23;
            Console.WriteLine("value=" + n);
        }
        public adult()
        {
            n = 34;
        }
        public void show()
        {
           // n = 12;
            Console.WriteLine("value=" + n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            adult a = new adult();
            //a.show();
            Console.ReadKey();
        }
    }
}
