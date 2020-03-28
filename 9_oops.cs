using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops9
{
    class Complex
    {
        public int Real1 { get; set; }
        public float Imagionary1 { get; set; }
        public float I1 { get; set; }

        public int Real2 { get; set; }
        public float Imagionary2 { get; set; }
        public float I2 { get; set; }
        public float complex1 {get;set; }
        public float complex2 { get; set; }
        public void Sum()
        {
            complex1 = (Real1 + (Imagionary1 * (I1)));
            complex2 = (Real2 + (Imagionary2 * (I2)));
            Console.WriteLine();
            Console.WriteLine("1st number=" + complex1);
            Console.WriteLine("2nd number=" + complex2);
            //float Sumofcomplex = (Real1 + (Imagionary1*(I1))) + (Real2 + (Imagionary2* (I2)));
            float Sumofcomplex = complex1 + complex2 ;
            Console.WriteLine("sum ="+Sumofcomplex);
        }
        public void Difference()
        {
            complex1 = (Real1 + (Imagionary1 * (I1)));
            complex2 = (Real2 + (Imagionary2 * (I2)));
            Console.WriteLine();
            Console.WriteLine("1st number="+complex1);
            Console.WriteLine("2nd number=" + complex2);
            float Diffcomplex = complex1 - complex2;
            //float Diffcomplex = (Real1 + (Imagionary1 * (I1))) - (Real2 + (Imagionary2 * (I2)));
            Console.WriteLine("differnce =" + Diffcomplex);
        }
        public void Product()
        {
            complex1 = (Real1 + (Imagionary1 * (I1)));
            complex2 = (Real2 + (Imagionary2 * (I2)));
            Console.WriteLine();
            Console.WriteLine("1st number=" + complex1);
            Console.WriteLine("2nd number=" + complex2);
            float Procomplex = complex1 * complex2;
            // float Procomplex = (Real1 + (Imagionary1 * (I1))) * (Real2 + (Imagionary2 * (I2)));
            Console.WriteLine("product =" + Procomplex);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            Console.WriteLine("enter 1 real number");
            c.Real1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter 1 imagionary  number");
            c.Imagionary1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 1 I number");
            c.I1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2 real number");
            c.Real2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2 imagionary number");
            c.Imagionary2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2 I number");
            c.I2= int.Parse(Console.ReadLine());
            c.Sum();
            c.Difference();
            c.Product();
            Console.ReadKey();
        }
    }
}
