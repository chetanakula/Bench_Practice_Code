using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class Repeat_Chars_String
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any string:");
            string a = Console.ReadLine();
            Console.WriteLine("The repeated characters in the given string are:");
            while (a.Length>0)
            {
                Console.WriteLine(a[0] + "=");
                int count = 0;
                for(int j = 0; j < a.Length; j++)
                {
                    if (a[0] == a[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                a = a.Replace(a[0].ToString(), String.Empty);
            }
            Console.ReadLine();
        }
    }
}
