using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayOfobjects
{
    class Bank
    {
       public static decimal bal = 2000;
       public string name;
        public static int intrest = 100;
        public void withdrwal(string n, decimal amt)
        {
            name = n;
            bal = bal - amt;
            Console.WriteLine("after withdrwal=" + bal);
        }
        public void deposit(string n, decimal amt, int i)
        {
            name = n;
            Console.WriteLine("interest=" + intrest);
            bal = bal+amt + i;
            Console.WriteLine("after deposit=" + bal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank[] b = new Bank[3];
            for (int i = 0; i < 3; i++)
            {
                b[i] = new Bank();
                Console.WriteLine("balance=" + Bank.bal);
                Console.WriteLine("deposit or withdrwal");
                string t = Console.ReadLine();
                Console.WriteLine("enter name");
                string n = Console.ReadLine();
                Console.WriteLine("enter amount");
                decimal amt = Convert.ToDecimal(Console.ReadLine());
                switch(t)
                {
                    case "deposit":
                        b[i].deposit(b[i].name, amt, Bank.intrest);
                        break;
                    case "withdrwal":
                        b[i].withdrwal(b[i].name, amt);
                        break;
                    default:Console.WriteLine("invalid");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
                                                                                                                                                                                                                             
