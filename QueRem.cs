using System;
using System.Collections.Generic;
using System.Text;

namespace BasiccodeProgram
{
    class QueRem
    {
        public static void Remainder()
        {
        int a = 10;
            a %= 3;
            double b = 5;
            b /= 3;
        
            Console.WriteLine("The Reminder is " +a);
            Console.WriteLine("The Quotient is " +b);
    }
}
}