using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class No_Of_Digits_In_Integer
    {
        public static void Main()
        {
            int count = 0;
            Console.WriteLine("Enter the number:");
            double num = Convert.ToDouble(Console.ReadLine());
            string num1 = num.ToString();
            char[] digits = num1.ToCharArray();
            Console.WriteLine("The number of digits in the given are:");
            for(int i = 0; i < digits.Length; i++)
            {
                Console.WriteLine(digits[i]);
                count++;
            }
            Console.WriteLine("The total number of digits in the given number are:{0}", count);
        }
    }
}
