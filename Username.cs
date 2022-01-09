using System;
using System.Collections.Generic;
using System.Text;

namespace BasiccodeProgram
{
    class Username

    {
        public static void Pranali()
        {
            Console.WriteLine("Please enter name");

            string name = Console.ReadLine();

            int nameLength = name.Length;

            if (nameLength >= 3)
            {
                Console.WriteLine("Hello " + name + " How are you");
                Console.WriteLine("length of string " +nameLength);
            }
        }

    }
}
