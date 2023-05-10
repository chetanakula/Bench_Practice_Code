using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class Powerofanumber
    {
        public static void Main(string[] args)
        {
            //int basenumber, expnumber, result = 1;
            //Console.WriteLine("Enter the base number:");
            //basenumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the exp number:");
            //expnumber = Convert.ToInt32(Console.ReadLine());
            //while (expnumber != 0)
            //{
            //    result *= basenumber;
            //    --expnumber;
            //}
            //Console.WriteLine("Result is {0}", result);

            int result = 1;
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power");
            int pow = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<pow; i++)
            {
                result *= n;

            }
            Console.WriteLine(result);
                
        }
    }
}
