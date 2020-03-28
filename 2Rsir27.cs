using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Rsir27
{
    class Program
    {
        string p;
        public Program()
        {
            p = "1234";
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("enter the password");
                string pass = Console.ReadLine();
                if (pass == p)
                {
                    Console.WriteLine("correct password");
                    break;
                }
                else
                {
                    Console.WriteLine("incorrect password");
                    if (i == 3)
                        Console.WriteLine("unautherized user");
                }
                Console.WriteLine();
            }
            

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadKey();
        }
    }
}
