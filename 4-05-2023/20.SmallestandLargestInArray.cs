using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class SmallestandLargestInArray
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter any numbers:");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($" largest number in the array :{arr.Max()}");
            Console.WriteLine($" smallest number in the array :{arr.Min()}");

        }
    }
}
