using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFlowControl
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 12;
            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is greater than or equal to 5",number);
                if (number < 10)
                {
                    Console.WriteLine("{0} proper language learning", number);
                }
                else
                {
                    Console.WriteLine("{0} improper language learning", number);
                }
            }
            else
            {
                Console.WriteLine("{0} is equal to 5",number);
            }
            Console.WriteLine("This statement is always execuated.");
            Console.ReadLine();
        }
    }
}
