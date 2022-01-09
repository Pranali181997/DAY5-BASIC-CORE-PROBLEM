using System;
using System.Collections.Generic;
using System.Text;

namespace BasiccodeProgram
{
    class Factors
    {
        public static void PrimeFactor()
        {
        int a ;
        //int b;

        Console.WriteLine("Please enter your integer: ");
         a = int.Parse(Console.ReadLine());
        for (int b = 1;  b <= a; b++)
        {
            if ( a % b == 0)
            {
                Console.WriteLine(b + " is a factor of " + a);
            }
         }
         }    
     }
}
