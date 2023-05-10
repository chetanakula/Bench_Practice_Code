using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class Removing_Chars
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string result = "";
            foreach(char c in a)
            {
                if (!b.Contains(c))
                {
                    result += c;
                }

            }
            Console.WriteLine(result);
        }
    }
}
