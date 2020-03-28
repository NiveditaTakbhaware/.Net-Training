using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass2
{
     public class Program
    {
         public static string name(string n)
        {

            string n1= ("welcome friend "+ n) ;
            return n1;
        }
        public static string msg()
        {

            string n2 = "have nice day! " ;
            return n2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string s = Console.ReadLine();
            string s2 = name(s);
           string s3= msg();
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
