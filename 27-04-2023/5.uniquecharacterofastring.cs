using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class uniquecharacterofastring
    {
        public static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter a string:");
            s = Console.ReadLine();
            char uniqueChar = '\0';
            foreach(char c in s)
            {
                if (s.IndexOf(c) == s.LastIndexOf(c))
                {
                    uniqueChar = c;
                    break;
                }
            }
            if (uniqueChar == '\0')
            {
                Console.WriteLine("no unique character is found");
            }
            else
            {
                Console.WriteLine("unique character is :"+ uniqueChar);
            }
        }
    }
}
