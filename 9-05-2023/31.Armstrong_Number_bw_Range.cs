using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Armstrong_Number_bw_Range
    {
        public static void Main()
        {
            int rem, sum;
            int strt, end;
            Console.WriteLine("Enter the starting range value:");
            strt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending range value:");
            end = Convert.ToInt32(Console.ReadLine());
            for(int num = strt; num <= end; num++)
            {
                int s = num;
                sum = 0;
                while (s!= 0)
                {
                    rem = s%10;
                    s = s/10;
                    sum = sum+(rem*rem*rem);
                   
                }
                if (sum == num)
                {
                    Console.WriteLine("Armstrong numbers are {0}", num);
                }
                

            }
            Console.WriteLine();
        }

    }
}
