using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class SecondLargestNumberInArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
           
            Console.WriteLine("Enter the elements into array:");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("The second largest number in the array is:" + array[n - 2]);
        }
    }
}
