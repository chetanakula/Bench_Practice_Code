using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_csharp
{
    class Rotation_Of_Elements_Left_Right
    {
        public static void Main()
        {
            Console.WriteLine("Enter the size of the array:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];
            Console.WriteLine("Enter the elements: ");
            for(int i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            Rotation_Of_Elements_Left_Right c = new Rotation_Of_Elements_Left_Right();
            Console.WriteLine("The rotation of given array");
            c.LeftRotation(b);
            for(int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
        private void LeftRotation(int[] b)
        {
            int x = b[0];     
            for (int i = 0; i < (b.Length - 1); i++)
            {
                b[i] = b[i + 1];
            }
            b[(b.Length - 1)] = x;

        }
    }
}

