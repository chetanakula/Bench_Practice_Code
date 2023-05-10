using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptasks
{
    class vowelsandconsonants
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter any string :");
           string a = Console.ReadLine();
            char[] ch = a.ToCharArray();
            int vcount = 0;
            int ccount = 0;
            for(int i = 0; i <= ch.Length - 1; i++)
            {
                for(int j = i + 1; j <=ch.Length - 1; j++)
                {
                    if (ch[i]==ch[j])
                    {
                        ch[j] = ' ';
                    }
                }
                if(ch[i]!=' ')
                {
                    if(ch[i]=='a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                    {
                        vcount++;
                    }
                    else
                    {
                        ccount++;
                    }
                }
            }
            Console.WriteLine("No of Vowels:{0}", vcount++);
            Console.WriteLine("No of Consonants:{0}", ccount++);

        }
        
    }
}
