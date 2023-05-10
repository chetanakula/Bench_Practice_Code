using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Prime_Factors_Of_A_Number
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors of a given number are:");
            for(int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + "");
                    n /= i;
                }
            }
            Console.WriteLine();
        }
    }
}
