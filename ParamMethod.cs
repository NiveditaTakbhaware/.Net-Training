using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8parammethods
{
    class Program
    {
        void cal(params int[] val)
        {
            int i;
            for (i=0;i<val.Length;i++)
            {
                Console.WriteLine("array:" + val[i]);
            }
           // return ;
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.cal(2, 3, 4, 5, 6, 7);
            Console.ReadKey(); 
        }
    }
}
