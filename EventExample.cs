using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public Student(int rno,string name)
        {
            rollno = rno;
            this.name = name;
        }
        public string show()
        {
            return name+" has roll no " + rollno;
        }
    }
    class Program
    {
        public delegate string showdelegate(); //declaring delegate
        private event showdelegate showEvent;  //decalring Event
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter roll no");
            int rn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string n = Console.ReadLine();
            Student s = new Student(rn,n);
           // showdelegate sd = null;
            p.showEvent += new showdelegate(s.show);  //subscribing an event
            string result = p.showEvent();
            Console.WriteLine(result);
            Console.ReadKey();
         }
    }
}
