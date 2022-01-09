using System;
using System.Collections.Generic;
using System.Text;

namespace BasiccodeProgram
{
    class presentAbsent
    {
        public static void swapNum()
        {
            int a = 50;
            int b = 20;
            int x,y, z;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            x = a * b;       
            y = x / b;       
            z = x / a;     
            
            Console.Write("After swap a= " + z + " b= " + y);
        }
    }
}