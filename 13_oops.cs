using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops13
{
    class Matrix
    {
        public int rows { get; set; }
        public int columns { get; set; }
        public int elements { get; set; }
        public Matrix()
        {
           rows = 2;
           columns = 2;
        }
        public void get()
        {
            Console.WriteLine("enter elements of matrix");
            int[,] elmt = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    elmt[i, j] = int.Parse(Console.ReadLine());
                }
            }
       
            Console.WriteLine("elements of matrix");
           
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(elmt[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter number of rows" );
            //int ro = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter number of columns");
            //int co = int.Parse(Console.ReadLine());
            Matrix m = new Matrix();
            m.get();
            Console.ReadKey();
        }
    }
}
