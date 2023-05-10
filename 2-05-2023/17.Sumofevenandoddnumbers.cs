using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Sumofevenandoddnumbers
    {
        public static void Main(string[] args)
        {
            int x = 0, y = 0;
            int[] a = new int[10];
            Console.WriteLine("Enter any numbers:");
            for (int i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] % 2 == 0)
                {
                    x += a[i];
                }
                else
                {
                    y += a[i];
                }
            }
            Console.WriteLine($"Sum of all even numbers is :{x}");
            Console.WriteLine($"Sum of all odd numbers is : {y}");

        }
    }
}
