using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass2
{
    abstract class Bank
    {
        public double Balance = 12000;
        abstract public void getBalnce(int amt);
    }
    class BankA:Bank
    {
        public override void getBalnce(int amt)
        {
            Balance = Balance + amt;
            Console.WriteLine("balance of BankA ="+Balance);
        }
    }
    class BankB : Bank
    {
        public override void getBalnce(int amt)
        {
            Balance = Balance + amt;
            Console.WriteLine("balance of BAnkB =" + Balance);
        }
    }
    class BankC : Bank
    {
        public override void getBalnce(int amt)
        {
            Balance = Balance + amt;
            Console.WriteLine("balance of BankC =" + Balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankA a = new BankA();
            a.getBalnce(100);
            BankB b = new BankB();
            b.getBalnce(150);
            BankC c = new BankC();
            c.getBalnce(200);
            Console.ReadKey();


        }
    }
}
