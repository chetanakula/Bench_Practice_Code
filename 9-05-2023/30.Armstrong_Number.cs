using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Armstrong_Number
    {
        public static void Main()
        {
            //    int n,rem,sum = 0;
            //    Console.WriteLine("Enter any number:");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    int temp = n;
            //    while (n > 0)
            //    {
            //        rem = n % 10;
            //        sum = sum + (rem * rem * rem);
            //        n = n / 10;
            //    }
            //    if (temp == sum)
            //    {
            //        Console.WriteLine("The given number is Armstrong number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The given number is not armstrong number");
            //    }
            int r, sum = 0;
            Console.WriteLine("Enter any  number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            while (m != 0)
            {
                r = m % 10;
                int fact = (int)Math.Pow(r, (int)Math.Log10(n)+1);
                m = m / 10;
                sum = sum + fact;
            }
            if (sum == n)
            {
                Console.WriteLine("Given number is armstrong number");
            }
            else
            {
                Console.WriteLine("Given number is not armstrong");
            }
        }

    }
}
