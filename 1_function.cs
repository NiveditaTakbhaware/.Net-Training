using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass
{
    public class Program
    {
        public static int name (string s)
            {
            int c = 0;
             for(int i=0;i<s.Length;i++)
            {
                if (s[i] == ' ')
                {
                    c++;
                }
            }
            Console.WriteLine("sapce=" + c);
            return c;
            }


        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            int res = name(str);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
