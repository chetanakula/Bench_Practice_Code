using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class LeapYear
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter any number:");
            a = Convert.ToInt32(Console.ReadLine());
            if(a%4==0&&(a%100 !=0 || a % 400 == 0))
            {
                Console.WriteLine("given number is a leap year");
            }
            else
            {
                Console.WriteLine("Given number is not a leap year");
            }
        } 
    }
}
