using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class NumberofAspresentinastring
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a string:");
            string a = Console.ReadLine();
            char[] c = a.ToCharArray();
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a')
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No a's are found in the given string");
            }
            else
            {
                Console.WriteLine($"Number of a's present in the given string are:{count}");
            }
        }
    }
}
