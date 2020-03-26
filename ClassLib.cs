using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleClassLibrary
{
    public class Calculate
    {
        public int  num1{ get; set; }
       
        public string Remainder(int n1)
        {
            num1 = n1;
            if (num1 % 2 == 0)
            
                 return "even number";
            
            else
                 return "odd number"; 
        } 

    }
   
}
