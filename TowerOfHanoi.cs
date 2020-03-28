using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerofHanoi
{
    class Moves
    {
        public void Tower(int discs, int source, int aux, int destination)
        {
            if (discs == 1)
            {
                Console.WriteLine("move disc{0} from{1} to{2}", discs, source, destination);
                return;
            }
            else
            {
                Tower(discs - 1, source, destination, aux);
                Console.WriteLine("move disc{0} from{1} to{2}", discs, source, aux);
                Tower(discs - 1, aux, source, destination);
            }    
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Moves m = new Moves();
            Console.WriteLine("enter number of discs");
            int NumDisc = int.Parse(Console.ReadLine());
            m.Tower(NumDisc, 1, 2, 3);
            Console.ReadKey();
        }
    }
}
