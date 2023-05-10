using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Perfect_Number
    {
        public static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum of the factors of a given number is:{0}", sum);
            if (sum == n)
            {
                Console.WriteLine("The given number is perfect number");
            }
            else
            {
                Console.WriteLine("The given number is not a perfect number");
            }
        }
    }
}
