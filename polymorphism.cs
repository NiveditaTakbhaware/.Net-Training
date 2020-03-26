using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2polymorphism
{
    class Account
    {
        public int AccountNumber=123;
        public double Balance;
        public Account()
        {
            Balance = 1000;
        }
        public virtual string deposit(int amount)
        {
            Balance = Balance + amount;
            return "total balance of "+AccountNumber+ " of Account class is :"+ Balance;
        }
        public void ShowBalance()
        {
            Console.WriteLine("total balance is :{0}", Balance);
        }
    }
    class Saving:Account
    {
        public override string deposit(int amount)
        {
            int interest = 200;
            Balance = Balance + amount + interest;
            return "total balance of " + AccountNumber + " of saving class is :" + Balance;
        }
    }
    class Current:Account
    {
        public override string deposit(int amount)
        {
            Balance = Balance + amount;
            return "total balance of " + AccountNumber + " of current class is :" + Balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount");
            int amt = int.Parse(Console.ReadLine());
            Account s = new Saving();
           string result= s.deposit(amt);
            Console.WriteLine(result);
            Account c = new Current();
            string result2= c.deposit(amt);
            Console.WriteLine(result2);
            Console.ReadKey();

        }
    }
}
