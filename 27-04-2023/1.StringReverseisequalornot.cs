using System;
using System.Linq;

namespace C_sharptasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string reverse = new string(a.Reverse().ToArray());
            if (reverse == b)
            {
                Console.WriteLine("both are equal");
            }
            else
            {
                Console.WriteLine("both are not equal");
            }

        }
    }
}
