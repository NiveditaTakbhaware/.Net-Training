using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Rsir2_3
{
    class Calculate
    {
        //public float Numerator = 1;
        public double sum=1.0f;
        public void Cal()
        {
            for(float denominator=2;denominator<=50;denominator++)
            {
                
                sum = sum+ (1 / denominator);
                //Console.WriteLine("sum=" + sum);
            }
           Console.WriteLine("sum="+sum);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.Cal();
            Console.ReadKey();
        }
    }
}
