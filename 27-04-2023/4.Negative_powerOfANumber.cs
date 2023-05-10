using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class Negative_powerOfANumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any basenumber");
            int basenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any Expnumber");
            int Expnumber = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            for(int i = 0; i > Expnumber; i--)
            {
                result *= basenumber;
            }
            result = 1 / result;
            Console.WriteLine(result);

        }
    }
}
