using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class NotRepeatedDigits
    {
        public static void Main(string[] args)
        {
            int i, j, k;
            int[] a = new int[5];
            Console.WriteLine("Enter the values into array:");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (j = 0; j < a.Length; j++)
            {
                for (k = 0; k < a.Length; k++)
                {
                    if (a[j] == a[k] && (j != k))
                    {
                        break;
                    }
                }
                if (k == a.Length)
                {
                    Console.WriteLine("Non-repeated digits are:{0}", a[j]);
                }
            }
        }
    }
}
