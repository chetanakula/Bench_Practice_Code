﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class First_Two_Charecters_PresentAt_End_Of_String
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            if ((str.Substring(0, 2) == str.Substring(str.Length - 2)))
            {
                Console.WriteLine("the first and last two charcters of given string are same");
            }
        }
    }
}
