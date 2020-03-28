using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops14
{
    class Matrix
    {
        public int rows1 { get; set; }
        public int columns1 { get; set; }
        public int rows2 { get; set; }
        public int columns2 { get; set; }
       
        public int[,] mul { get; set; }
        int[,] ele = new int[2, 2];
        int[,] elm = new int[2, 2];
        public int[,] Add = new int[2, 2];
        public int[,] mult = new int[2, 2];
        public void GetRows()
        {
            rows1 = 2;
            rows2 = 2;
        }
        public void GetColumns()
        {
            columns1 = 2;
            columns2 = 2;
        }
        public void SetElemnts()
        {
            Console.WriteLine("enter elments for 1st matrix");
            //int[,] ele = new int[2, 2];
            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                   
                        {
                            ele[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    
            }
            Console.WriteLine("enter elments for 2nd matrix");
           // int[,] elm = new int[2, 2];
            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    elm[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("1st matrix is:");
            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j <2; j++)
                  
                        {
                            Console.Write(ele[i, j] + "\t");
                        }
                    
                Console.WriteLine();
            }

            Console.WriteLine("2nd matrix is:");
            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    Console.Write(elm[i, j]+"\t");
                }
                Console.WriteLine();
            }

        }
        public void AddMatrix()
        {
            Console.WriteLine("Addition of matrix :");
            if (rows1==rows2 && columns1==columns2)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                      
                            {
                                Add[i, j] = ele[i, j] + elm[i, j];
                                Console.Write(Add[i, j] + "\t");
                            }
                        
                    Console.WriteLine();
                }

            }
            else
                Console.WriteLine("matrices are not Addable");
        }
        public void MulMarix()
        {


            Console.WriteLine("multiplication of matrix :");
            if (rows1 == rows2 && columns1 == columns2)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                       
                            {
                                mult[i, j] = ele[i, j] * elm[i, j];
                                Console.Write(mult[i, j] + "\t");
                            }
                        
                    Console.WriteLine();
                }

            }
            else
                Console.WriteLine("matrices are not Addable");


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            
            m.SetElemnts();
            m.AddMatrix();
            m.MulMarix();
            Console.ReadKey();
        }
    }
}
