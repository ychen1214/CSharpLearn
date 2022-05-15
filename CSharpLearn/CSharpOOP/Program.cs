﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Dog
    {
        //string breed;

        public void bark()
        {
            Console.WriteLine("Bark Bark !!");
        }
    }
    class Program
    {

        int AddNumber(int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        void Display(int a)
        {
            Console.WriteLine("Arguments: {0}", a);
        }
        void Display(int a, int b)
        {
            Console.WriteLine("Arguments: {0}:{1}", a, b);
        }
        static void Main(string[] args)
        {
            //Crate Dog Object
            Dog bullDog = new Dog();
            
            //Bark
            bullDog.bark();

            //Employee

            Employee emp1 = new Employee();

            emp1.name = "Sarah";

            Console.WriteLine("Name: "+ emp1.name);

            emp1.work("Coding");


            //Method 
            Program p1 = new Program();

            int sum = p1.AddNumber(100, 100);

            Console.WriteLine("Sum: {0}", sum);

            p1.Display(1);
            p1.Display(1, 2);

            

            Console.ReadLine();

        }
    }
}
