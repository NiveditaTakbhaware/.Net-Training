using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Rsir2_3
{
    class Calculate
    {
        public float sum = 1.0f;
        public void cal()
        {
            for(int num=3;num<8;)
            {
               for(int den=2;den<9;)
                {
                    sum = sum + (num / den);
                    den = den * 2;
                    num = num + 2;
                }
                Console.WriteLine("sum=" + sum);

            }
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.cal();
            Console.ReadKey();
        }
    }
}
