using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imp_InterfaceMethod_implicitly
{
    
    interface Iuniversity
    {
        void show(string name);
       
    }
    interface Idepartment
    {
        void display();
    }
   /*_ class Student:Iuniversity,Idepartment
    {
        string Name { get; set; }
        public void show(string name)      //implicitly taking method of Iuniversity interface
        {
            Name = name;
        }
        public void display()             //implicitly taking method of Idepartment interface
        {
            Console.WriteLine("name is "+Name);
        }
    }*/
    class Student : Iuniversity, Idepartment
    {
        string Name { get; set; }
        void Iuniversity.show(string name)      //explicitly taking method of Iuniversity interface
        {
            Name = name;
        }
        void Idepartment.display()             //explicitly taking method of Idepartment interface
        {
            Console.WriteLine("name is " + Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Iuniversity ut = new Student(); //in explicitly,create obj of class and store in interface
            ut.show("nivi");
            Idepartment dt = new Student();//in explicitly,create obj of class and store in interface
           dt.display();
                     
           Console.ReadKey();
        }
    }
}
