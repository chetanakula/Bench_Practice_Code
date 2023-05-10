using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Remove_Spaces_From_String
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("After removing spaces");
            string str1 = str.Replace(" ", "");
            Console.WriteLine(str1);
        }
    }
}
