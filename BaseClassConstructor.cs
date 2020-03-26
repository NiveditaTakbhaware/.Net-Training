using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassConstructor
{
    class Token
    {
        protected Token(string name)
        {
            Console.WriteLine("base class constructor "+name);
        }
    }
    class Comment:Token
    {
        public Comment(string name):base(name)
        {
            Console.WriteLine("derived class constructor "+name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string str = Console.ReadLine();
            Comment c = new Comment(str);
            Console.ReadKey();
        }
    }
}
