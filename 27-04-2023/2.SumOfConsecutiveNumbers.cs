using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class SumOfConsecutiveNumbers
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[4];
            Console.WriteLine("Enter the elements into array:");
            for(int i = 0; i < a.Length; i++)
            {
               a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Sum of the numbers is:{a.Sum()}");
            for (int i = 0; i < a.Length - 1;i++)
            {
                b[i] = a[i] + a[i + 1];
            }
            Console.WriteLine($"The smallest sum of numbers is:{b.Min()}");
        }
    }
}
