using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Merging_Arrays
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            Console.WriteLine("Enter first array elements:");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the second array elements:");
            for(int i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] c = new int[a.Length + b.Length];
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
                count++;
            }
            for(int i = 0; i < b.Length; i++)
            {
                c[count++] = b[i];
            }
            Console.WriteLine("THe merging of two arrays are:");
            for(int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i] + "");
            }
        }
    }
}
