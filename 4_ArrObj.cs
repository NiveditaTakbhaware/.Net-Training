using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrobj4
{
    class BankAccount
    {
        public string DepositorName { get; set; }
        public string DepositorAddress { get; set; }
        public string DepositorAccType { get; set; }
        public double  Balance { get; set; }
        public int DepositorTransactions = 0;
        public int AccNumber { get; set; }
        public void generateUniqueAccNUmber()
        {
            int AccNumber = 1000;
            Console.WriteLine("Account Number:"+AccNumber);
            AccNumber++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name:"+ DepositorName);
            Console.WriteLine("Address:" + DepositorAddress);
            Console.WriteLine("Account Number:" + AccNumber);
            Console.WriteLine("Account Type:" + DepositorAccType);
            Console.WriteLine("Balance:" + Balance);
            //Console.WriteLine("Number of Transaction:"+DepositorTransactions);
        }
        public void Deposit(double amt)
        {
            Balance = Balance + amt;
            Console.WriteLine("Balance:" + Balance);
        }
        public void Withdrwal(double amt)
        {
            Balance = Balance - amt;
            Console.WriteLine("Balance:" + Balance);
        }
        public void Changeaddress(string add)
        {
            DepositorAddress = add;
            Console.WriteLine("Address:" + DepositorAddress);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            Console.WriteLine("enter number of depositors" );
            int num = int.Parse(Console.ReadLine());
            BankAccount[] bk = new BankAccount[num];
            for(int i=0;i<bk.Length;i++)
            {
                bk[i] = new BankAccount();
                Console.WriteLine("enter name");
                bk[i].DepositorName = Console.ReadLine();
                Console.WriteLine("enter Address");
                bk[i].DepositorAddress = Console.ReadLine();
                Console.WriteLine("enter Account type");
                bk[i].DepositorAccType = Console.ReadLine();
                Console.WriteLine("enter balance");
                bk[i].Balance = double.Parse(Console.ReadLine());
               // Console.WriteLine("enter Number of transaction");
                //int DepositorTransactions = int.Parse(Console.ReadLine());

                bk[i].DisplayInfo();
                b.DepositorTransactions++;
                Console.WriteLine("do you want to deposit money? plz press Y/N");
                string ch = Console.ReadLine();
                if (ch == "Y")
                {
                    Console.WriteLine("enter Amount");
                    double Amount = double.Parse(Console.ReadLine());
                    bk[i].Deposit(Amount);
                    bk[i].DisplayInfo();
                    b.DepositorTransactions++;
                }
                Console.WriteLine("do you want to withdraw  money? plz press Y/N");
                string ch1 = Console.ReadLine();
                if (ch1 == "Y")
                {
                    Console.WriteLine("enter Amount");
                    double Amount = double.Parse(Console.ReadLine());
                    bk[i].Withdrwal(Amount);
                    bk[i].DisplayInfo();
                    b.DepositorTransactions++;
                }
                Console.WriteLine("do you want to change address? plz press Y/N");
                string ch2 = Console.ReadLine();
                if (ch2 == "Y")
                {
                    Console.WriteLine("enter address");
                    bk[i].DepositorAddress = Console.ReadLine();
                    bk[i].Changeaddress(bk[i].DepositorAddress);
                    bk[i].DisplayInfo();
                    b.DepositorTransactions++;
                }  
            }
            Console.WriteLine("total transaction=" + b.DepositorTransactions);
            Console.ReadKey();
        }
    }
}
