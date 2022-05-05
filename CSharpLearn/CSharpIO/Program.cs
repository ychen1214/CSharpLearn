using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString;
            Console.Write("Enter a string -");
            testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", testString);
            Console.ReadLine();
        }
    }
}
