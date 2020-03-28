using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedClass
{
    sealed class student
    {
        public int rollno;
        public student()
        {
            rollno = 11;
        }

        public void show()
        {
            Console.WriteLine("rollno "+rollno);
        }

    }
    class person:student ///can not derive sealed class
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.show();
            Console.ReadKey();
        }
    }
}
