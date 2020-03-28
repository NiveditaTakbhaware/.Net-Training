using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netassignmnt
{
    public class Program
    { 
        public static string msg1()
        {
            string s1 = "welocome friends";
            Console.WriteLine(s1);
            return s1;
        }
        public static string msg2()
        {
           
            string s2 = "have nice day";
            Console.WriteLine(s2);
            return s2;
        }


        static void Main(string[] args)
        {
           string str1= msg1();
            string str2=msg2();
            Console.ReadKey();
        }
    }
}
