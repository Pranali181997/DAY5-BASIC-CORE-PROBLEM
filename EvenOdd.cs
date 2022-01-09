using System;
using System.Collections.Generic;
using System.Text;

namespace BasiccodeProgram
{
    class EvenOdd
    {
        public static void Eodd()
        {
            Console.WriteLine("Enter the Number");
            //string name = Console.ReadLine();
            int a;
            a = int.Parse(Console.ReadLine());
            if (a %2 == 0)
                    {
                Console.WriteLine("The Number Is Even");
            }
                else
            {
                    Console.WriteLine("The Number Is odd");
            }
            }
        }
    }
