using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c.netass5
{
    public class Program
    {
        public static int sum()
        {
            int[] arr = new int[] { 5, 7, 3, 2, 9 };
            int sum = 0;
            for (int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }
            //Console.WriteLine("the sum of the elements of the array is " + sum);
            return sum;
        }
        static void Main(string[] args)
        {
            int res=sum();
            Console.WriteLine("the sum of the elements of the array is " + res);
            Console.ReadKey();
        }
    }
}
