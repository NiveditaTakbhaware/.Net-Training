using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
    
namespace NamespaceAlias.find
{
    

    public class Widget
    {
        public void show()
        {
            Console.WriteLine("this is widget class");
        }
        using Widget = NamespaceAlias.find.Wideget;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Widget w = new Widget();
            Console.ReadKey(); 
        }
    }
}
