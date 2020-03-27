using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass5
{
    abstract class Animals
    {
        abstract public void cats();
        abstract public void dogs();
    }
    class Cats:Animals
    {
        public override void cats()
        {
            Console.WriteLine("cats meow from Cats class");
        }
        public override void dogs()
        {
            
        }
    }
    class Dogs : Animals
    {
        public override void cats()
        {
           
        }
        public override void dogs()
        {
            Console.WriteLine("dogs bark from Dogs class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cats c = new Cats();
            c.cats();
            Dogs d = new Dogs();
            d.dogs();
            Console.ReadKey();
        }
    }
}
