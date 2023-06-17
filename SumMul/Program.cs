using System;
using System.ComponentModel;

namespace SumMul
{
    class Program
    {
        // Take two inputs (one int + one double) and make a sum, addition, and multiplication. Show the 3 output

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Number , One int and another double :");

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());    

           
            double sum = firstNumber + secondNumber;
            double mul = firstNumber * secondNumber;

            Console.WriteLine("Additon result  : " + sum);
            Console.WriteLine("Multiplication result : "+ mul);

           
        }
    }
}
