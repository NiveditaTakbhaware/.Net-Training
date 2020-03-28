using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedclass
{
    class Bank
    { 
        public class account
        {
          public string name;
            public void show(string name)
            {
                this.name = name;
                Console.WriteLine("customer name=" + name);
            }
        }
        public int actno;
        public void act(int actno)
        {
            this.actno = actno;
            Console.WriteLine("account no=" + actno);
        }

}
    class Program
    {
        static void Main(string[] args)
        {
            Bank.account a = new Bank.account();
            Console.WriteLine("enter the name");
            a.name = Console.ReadLine();
            
            Bank n = new Bank();
            Console.WriteLine("enter the account no");
            //a.name = Console.ReadLine();
            n.actno = Convert.ToInt32(Console.ReadLine());
            a.show(a.name);
            n.act(n.actno);
            Console.ReadKey();
        }
    }
}
