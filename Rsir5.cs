using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rsir5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number between 1 to 12");
            n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:Console.WriteLine("{0} is january", 1);
                    break;

                case 2:
                    Console.WriteLine("{0} is februray", 2);
                    break;

                case 3:
                    Console.WriteLine("{0} is march", 3);
                    break;

                case 4:
                    Console.WriteLine("{0} is april", 4);
                    break;

                case 5:
                    Console.WriteLine("{0} is may", 5);
                    break;

                case 6:
                    Console.WriteLine("{0} is june", 6);
                    break;

                case 7:
                    Console.WriteLine("{0} is july", 7);
                    break;

                case 8:
                    Console.WriteLine("{0} is augest", 8);
                    break;

                case 9:
                    Console.WriteLine("{0} is september", 9);
                    break;
                case 10:
                    Console.WriteLine("{0} is october", 10);
                    break;

                case 11:
                    Console.WriteLine("{0} is november", 11);
                    break;

                case 12:
                    Console.WriteLine("{0} is december", 12);
                    break;
                default:Console.WriteLine("invalid input");
                    break;

            }
            Console.ReadKey();
        }
    }
}
