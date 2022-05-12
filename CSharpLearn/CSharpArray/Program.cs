using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[5];

            int[] numbers = { 1, 2, 3, 4, 5 };

            age[0] = 12;
            age[1] = 4;
            age[2] = 5;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element in first index : " + numbers[i]);
            }

            //some linq
            Console.WriteLine("Smallest Element: " + numbers.Min());
            Console.WriteLine("Smallest Element: " + numbers.Max());
            Console.WriteLine("Smallest Element: " + numbers.Average());
            Console.ReadLine();

        }
    }
}
