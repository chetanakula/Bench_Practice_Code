using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class Ascending_string
    {
        public static void Main(string[] args)  //small to big
        {
            string name;
            Console.WriteLine("Enter any string");
            name = Console.ReadLine();
            char[] ch = name.ToCharArray();
            Array.Sort(ch);
            Console.WriteLine("Ascending order of given string is ");
            foreach(char c in ch)
            
                Console.WriteLine(c);
            
        }
    }
}
