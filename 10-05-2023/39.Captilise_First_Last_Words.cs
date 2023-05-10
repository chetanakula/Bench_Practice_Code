using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Captilise_First_Last_Words
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string str1 = str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 2) + str.Substring(str.Length - 1).ToUpper();
            Console.WriteLine(str1);
        }
    }
}
