using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classstatic
{
    class Bank
    {
        private decimal bal = 2000;
        //private string name;
        private static int i = 500;
        public int intrest
        {
            get
            {
                return i;
            }
        }
        public void withdrwal(string n,decimal amt)
        {
            amt = bal - amt;
            Console.WriteLine("after withdrawl=" + amt);
        }
        public void deposit(string n, decimal amt,int k) 
        {
            Console.WriteLine("interest=" + k);
             amt = bal + amt+k;
            Console.WriteLine("after deposit=" + amt);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            decimal bal = 2000;
            Console.WriteLine("balance=" + bal);
            Console.WriteLine("deposit or withdrwal");
            string t = Console.ReadLine();
            Bank b = new Bank();
            Console.WriteLine("enter the name");
            string n = Console.ReadLine();
            Console.WriteLine("enter the amount");
            decimal amt = Convert.ToDecimal(Console.ReadLine());
            int k=b.intrest;
            k = 100;
            switch (t)
            {
                case "deposit":
                    b.deposit(n, amt,k);
                    break;
                case "withdrwal":
                    b.withdrwal(n, amt);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;

            }
           // Console.WriteLine("balance=" + b.deposit());
            Console.WriteLine("deposit or withdrwal");
            string t1 = Console.ReadLine();
            Bank b1 = new Bank();
            Console.WriteLine("enter the name");
            string n1 = Console.ReadLine();
            Console.WriteLine("enter the amount");
            decimal amt1 = Convert.ToDecimal(Console.ReadLine());
            int k1 = b.intrest;
            k = 100;
            switch (t1)
            {
                case "deposit":
                    b1.deposit(n1, amt1, k1);
                    break;
                case "withdrwal":
                    b1.withdrwal(n1, amt1);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;

            }

            Console.ReadKey();
        }
    }
}
