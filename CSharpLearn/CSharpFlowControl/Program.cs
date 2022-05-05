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
            //IF ELSE
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


            //SWITCH Stmt
            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
            Console.WriteLine("This statement is always execuated.");
            Console.ReadLine();
        }
    }
}
