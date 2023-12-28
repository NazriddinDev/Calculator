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
            Console.Write("Create operation: [+,-,*,/,%] ");
            string operation = Console.ReadLine();
            Console.Write("Second number: ");
            string secondUserValues=Console.ReadLine();

            Console.WriteLine("Converting values in progress...");
            decimal firstNumber = Convert.ToDecimal(firstUerValues);
            decimal secondNumber = Convert.ToDecimal(secondUserValues);

            Console.WriteLine("Here are your results: "); 

            string template = $"{firstNumber} {operation} {secondNumber} =";
            decimal result = operation switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "%" => firstNumber % secondNumber,
                "_" => 0
            };

            Console.WriteLine($"{template} {result}");

            Console.Write("Enter your age:");
            string userAgeValue = Console.ReadLine();
            int userAge = Convert.ToInt32(userAgeValue);

            string message = (userAge >= 18 && userAge < 28)
                            ? "You are eligible to military service."
                            : "You are not eligible to military service.";

            Console.WriteLine(message);
        }
    }
}

