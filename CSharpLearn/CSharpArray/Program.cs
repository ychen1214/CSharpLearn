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

            //2 Dimensional Array Initialization
            int[,] x = new int[2, 3] { { 1, 2, 3 }, { 3, 4, 5 } };
            // access first element from the first row
            Console.WriteLine("Element at index [0, 0] : " + x[0, 0]);

            //Iterate throguh two datasets
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");

                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");

                }
            }

            Console.ReadLine();

        }

    }
}
