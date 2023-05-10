using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Even_Odd_In_An_Array
    {
        public static void Main()
        {
            Console.WriteLine("Enter the size of an array:");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Enter the array elements:");//Array elements
            for(int i = 0; i < s; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Even numbers condition
            Console.WriteLine("The even numbers in the given array are:");
            for(int i = 0; i < s; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            //Odd Numbers condition
            Console.WriteLine("The odd numbers in the given array are:");
            for(int i = 0; i < s; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
