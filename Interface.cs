using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface Account
    {
        void Deposit(int amt);
    }
    interface Account2:Account
    {
        string show();
    }
    class Saving:Account2
    {
        public int Amount;
       public void Deposit(int amt)
        {
            Amount = amt;
            //Console.WriteLine(Amount);
        }
        public string show()
        {
            return "totalAmount is:" + Amount;
        }
   }
    class Program
    {
        static void Main(string[] args)
        {
            Saving s = new Saving();
            Console.WriteLine("enter amoount");
            int amt = int.Parse(Console.ReadLine());
            s.Deposit(amt);
            string result = null;
            result=s.show();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
