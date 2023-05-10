using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class Repeated_Chras
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any string:");
            string a = Console.ReadLine();
            char rptchar = '\0';
            for(int i = 0; i < a.Length; i++)
            {
                char currentChar = a[i];
                if(a.IndexOf(currentChar)!= a.LastIndexOf(currentChar))
                {
                    rptchar = currentChar;
                    break;
                }
            }
            if (rptchar == '\0')
            {
                Console.WriteLine("No repeat character is found");
            }
            else
            {
                Console.WriteLine("First repeated character is : "+rptchar);
            }

        }
    }
}
