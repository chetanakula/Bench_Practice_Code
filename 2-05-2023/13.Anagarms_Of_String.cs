using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class Anagarms_Of_String
    {
        public static void Main(string[] args)
        {
            //anagram-if the two strings contains the same characters
            Console.WriteLine("Enter the strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            char[] S1 = s1.ToCharArray();
            char[] S2 = s2.ToCharArray();
            Array.Sort(S1);
            Array.Sort(S2);
            string c1 = new string(S1);
            string c2 = new string(S2);
            if (c1 == c2)
            {
                Console.WriteLine("Both the strings are anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not anagrams");
            }

        }
    }
}
