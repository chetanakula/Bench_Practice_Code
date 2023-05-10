using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Sorting_Array
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the element:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];
            for(int i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            Console.WriteLine("After sorting:");
            for(int i = 0; i < b.Length; i++)
            {
                for(int j = i + 1; j < b.Length; j++)
                {
                    int temp = 0;
                    if (b[i] > b[j])
                    {
                        temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
                }
                Console.WriteLine(b[i]);

            }
            int[] arr = new int[b.Length];
            arr = b;
            Console.WriteLine("copied elements of array1 to array2");
            for(int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
