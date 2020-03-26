using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9displayarray
{
    class Program
    {
        static int[] reverse(params int[] a)
        {
            int j;
            Console.WriteLine("array");
            for(j=0;j<a.Length;j++)
            {
                Console.WriteLine(a[j]);
            }
           
            return a;                                 
        }        
        static void Main(string[] args)
        {
            int i,j;
            int[] res = new int[5];
            int[] arr = new int[5];
            Console.WriteLine("enter elements");
            for(i=0;i<=4;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
           res=reverse(arr);
            Console.WriteLine("reverse");
            for (j = res.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(res[j]);
            }
            Console.ReadKey();
        }
    }
}
