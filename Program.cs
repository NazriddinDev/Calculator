using System;
namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter values: ");
            Console.Write("First number: ");
            string firstUerValues = Console.ReadLine();
            Console.Write("Second number: ");
            string secondUserValues=Console.ReadLine();

            Console.WriteLine("Converting values in progress...");
            decimal firstNumber = Convert.ToDecimal(firstUerValues);
            decimal secondNumber = Convert.ToDecimal(secondUserValues);

            Console.WriteLine("Here are your results: "); 
            Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber+secondNumber}");
        }
    }
}

