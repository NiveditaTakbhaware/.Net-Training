using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rsir3_3
{
    class Cube
    {
        int cube;
        public Cube()
        {
            cube = 1;
            Console.WriteLine("cubes are:");
            for (int num=1;num<10;num++)
            {
                cube = num * num * num;
               
                Console.WriteLine(cube);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cube c = new Cube();
            Console.ReadKey();
        }
    }
}
