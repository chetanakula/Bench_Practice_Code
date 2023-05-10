using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class ReverseOfaStringWuthRecursion
    {
        public static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter any string:");
            name = Console.ReadLine();
            ReverseOfaStringWuthRecursion str = new ReverseOfaStringWuthRecursion();
            string rev = str.Reverse(name);
            Console.WriteLine("Reverse of a string :" + rev);
        }
        private string Reverse(string name)
        {
            if (name.Length > 0)
            {
                return name[name.Length - 1] + Reverse(name.Substring(0, name.Length - 1));
            }
            else
            {
                return name;
            }
        }
    }
}
