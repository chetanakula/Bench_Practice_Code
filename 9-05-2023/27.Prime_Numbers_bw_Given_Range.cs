using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Prime_Numbers_bw_Given_Range
    {
        public static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Enter the values:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                count = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if(count==2)
                Console.WriteLine(i);
            }
        }
    }
}
