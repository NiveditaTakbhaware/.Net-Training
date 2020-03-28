using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword
{
    public class Thisclass
    {
        string name;
        public void emp(string name)
        {
            this.name = name;
            Console.WriteLine("employee name=" + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thisclass th = new Thisclass();
            th.emp("nivi");
            Console.ReadKey();
        }
    }
}
