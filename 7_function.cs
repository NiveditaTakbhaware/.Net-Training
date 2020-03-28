using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass7
{
   public class Program
    {
        public int power()
        {
            int pow = 1;
            // Console.WriteLine("enter the base number");
            // int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the power number");
            //int y = int.Parse(Console.ReadLine());
            int x = 3, y = 2;
            for(int i=1;i<=y;i++)
            {
                
                pow = pow * x;
            }
            return pow ;
        }
  
        static void Main(string[] args)
        {
            Program p = new Program();
            int res = p.power();
            Console.WriteLine("power="+res);
            Console.ReadKey();

        }
    }
}
