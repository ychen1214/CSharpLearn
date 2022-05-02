using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int firstNumber, secondNumber;
            // Assigning a constant to variable

            firstNumber = 10;
            Console.WriteLine("First Number = {0}", firstNumber);

            // Assigning a variable to another variable
            secondNumber = firstNumber;
            Console.WriteLine("Second Number = {0}", secondNumber);


            double firstDouble = 14.40, secondDouble = 4.60, result;
            int num1 = 26, num2 = 4, rem;

            // Addition operator 
            result = firstDouble + secondDouble;
            Console.WriteLine("{0} + {1} = {2}", firstDouble, secondDouble, result);

            // Subtraction operator 
            result = firstDouble - secondDouble;
            Console.WriteLine("{0} - {1} = {2}", firstDouble, secondDouble, result);

            // Modulo operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);

            bool boolTest;
            int firstBool = 10, secondBool = 20;

            // OR Operator 
            boolTest = (firstBool == secondBool) || (firstBool > secondBool);
            Console.WriteLine(boolTest);

            // AND Operator
            boolTest = (firstBool == secondBool) && (firstBool > 5);
            Console.WriteLine(boolTest);

            // TernaryOperator = IF-THEN-ELSE 
            int ternaryNum = 10;
            string ternaryResult;

            ternaryResult = (ternaryNum % 2 == 0) ? "Even Number" : "Odd Number";

            Console.WriteLine("{0} IS {1}", ternaryNum, ternaryResult);

            //BitWise Operator

            Console.ReadLine();
        }
    }
}
