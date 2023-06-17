using System;
using System.ComponentModel;

namespace SwapNumber
{
    class Program
    {
       // Write a C# Sharp program to swap two numbers.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Number:");

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Before Swap , First Number : " + firstNumber + " and Second Number :" + secondNumber);

            int tmp;
            tmp = firstNumber; 
            firstNumber= secondNumber;
            secondNumber= tmp;

            Console.WriteLine("After Swap , First Number : "+ firstNumber + " and Second Number :" + secondNumber ); 
        }
    }
}
