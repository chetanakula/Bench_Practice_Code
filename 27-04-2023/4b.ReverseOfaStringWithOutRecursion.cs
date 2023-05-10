using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class ReverseOfaStringWithOutRecursion
    {
        public static void Main(string[] args)
        {
            string reverse = "";
            Console.WriteLine("Enter any string:");
            string s = Console.ReadLine();
            int strlen = s.Length - 1;
            while (strlen >= 0)
            {
                reverse = reverse + s[strlen];
                strlen--;
            }
            Console.WriteLine("The reversed string is :" + reverse);
        }
        
    }
}
