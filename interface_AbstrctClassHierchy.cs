using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractClassHierarchy
{
    interface IToken
    {
        string Name();
    }
    abstract class token:IToken
    {
       
        public string Name()
        {
            return "name=";
        }

    }
    class Comment : token
    {
        public string name { get; set; }
       new public string Name()
        {
            return  "name=" +name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Comment c = new Comment();
            c.name = "nivi";
           Console.WriteLine(c.Name());
            Console.ReadKey();
        }
    }
}
