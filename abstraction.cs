using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    abstract class Account
    {
        public double Balance { get; set; }
        public int Accountnumber { get; set; }
        public Account()
        {
            Balance = 2000;
        }
        public abstract double Deposit(int amount);
        public abstract double withdrawl( int amount);
        public  void showdetails(int accountNumber)
        {
            Accountnumber = accountNumber;
            Console.WriteLine("total balance of "+Accountnumber+" of Account class is=" + Balance);
        }      
     
    }
    class Saving : Account
    {
        int interest = 100;
        public override double Deposit(int amount)
        {
            Balance = Balance + amount + interest;
            return Balance;
        }
        public override double withdrawl( int amount)
        {
            Balance = Balance - amount;
            return Balance;
        }
        public new void showdetails(int accountNumber)
        {
            Accountnumber = accountNumber;
            Console.WriteLine("total balance of " + Accountnumber + " of saving class is=" + Balance);
        }
    }
    class Current:Account
    {
        public override double Deposit( int amount)
        {
            Balance = Balance + amount;
            return Balance;
        }
        public override double withdrawl( int amount)
        {
            Balance = Balance - amount;
            return Balance;
        }
        public new void showdetails(int accountNumber)
        {
            Accountnumber = accountNumber;
            Console.WriteLine("total balance of " + Accountnumber + " of current class is=" + Balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("saving or current account?");
            string ch = Console.ReadLine();
            if (ch == "saving")
            {
                Saving s = null;
                 s = new Saving();
                Console.WriteLine("for deposit press 1 or for withdrawl press 2");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter account number");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter amount");
                        int amt = Convert.ToInt32(Console.ReadLine());
                        double result = 0; 
                        result=s.Deposit( amt);
                        Console.WriteLine(result);
                        s.showdetails(accno);
                        break;

                    case 2:
                        Console.WriteLine("enter account number");
                        int Accno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter amount");
                        int Amt = Convert.ToInt32(Console.ReadLine());
                        double Result = 0;
                        Result= s.withdrawl( Amt);
                        Console.WriteLine(Result);
                        s.showdetails(Accno);
                        break;
                }
            }
           
           else if (ch=="current")
            {
                Current c = null;
                c = new Current();
                Console.WriteLine("for deposit press 1 or for withdrawl press 2");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter account number");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter amount");
                        int amt = Convert.ToInt32(Console.ReadLine());
                        double result = 0;
                        result = c.Deposit(amt);
                        Console.WriteLine(result);
                        c.showdetails(accno);
                        break;

                    case 2:
                        Console.WriteLine("enter account number");
                        int Accno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter amount");
                        int Amt = Convert.ToInt32(Console.ReadLine());
                        double Result = 0;
                        Result = c.Deposit(Amt);
                        Console.WriteLine(Result);
                        c.showdetails(Accno);
                        break;
                }
            }
            else
            {
                Console.WriteLine("inavlid input");
            }
            

            Console.ReadKey();

        }
    }
}
