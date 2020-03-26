using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateExample
{
    class Accoount
    {
        public int balance = 1000;
        public void deposit(int amt)
        {
            balance = balance + amt;
            Console.WriteLine( "amount deposited,balance is " + balance);
        }
        public string wihthdrwal(int amt)
        {
            balance = balance - amt;
            return "amount withdrwal,balance is " + balance;
        }
    }
    class Program
    {
        public delegate void depositdelegate(int amt);   //declaring delegate
        public delegate string withdrwaldelegate(int amt);   //declaring delegate

        static void Main(string[] args)
        {
            Console.WriteLine("enter amount");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("deposit or withdrwal");
            string choice = Console.ReadLine();
            Accoount act = new Accoount();
            depositdelegate dd = null;
            dd = new depositdelegate(act.deposit);
           withdrwaldelegate wd = null;
            wd = new withdrwaldelegate(act.wihthdrwal);
            switch (choice)
            {
                case "deposit":
                     dd(amount);
                    //Console.WriteLine(result);
                    //dd = new depositdelegate(act.deposit);

                    break;
                case "withdrwal":
                    string result2 = wd(amount);
                    Console.WriteLine();
                    Console.WriteLine(result2);
                    //wd = new withdrwaldelegate(act.wihthdrwal);
                    break;
            }
           /* if (dd != null)
            {
                string result = dd(amount);
                Console.WriteLine(result);
            }
           else if (wd != null)
            {
                string result2 = wd(amount);
                Console.WriteLine();
                Console.WriteLine(result2);
            }*/
        
            Console.ReadKey();
        }
    }
}
