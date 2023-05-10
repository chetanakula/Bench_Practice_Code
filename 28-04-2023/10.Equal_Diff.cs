using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class Equal_Diff
    {
        public  static void Main(string[] args)
        {
            string a,b;
            Console.WriteLine("Enter any two strings:");
            a = Console.ReadLine();
            b = Console.ReadLine();
            if (a.Equals(b))
            {
                Console.WriteLine("Both the strings are equal");
            }
            else
            {
                Console.WriteLine("Both the strings are not equals");
            }
            if (a == b)
            {
                Console.WriteLine("Both the strings are equal");
            }
            else
            {
                Console.WriteLine("Both the strings are not equals");
            }
        }
    }
}
