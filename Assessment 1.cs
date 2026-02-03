using System;

class Program
{
    static void Main()
    {
        double num1, num2, result = 0;

        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.Write("Enter operation (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+": result = num1 + num2; break;
            case "-": result = num1 - num2; break;
            case "*": result = num1 * num2; break;
            case "/":
                if (num2 == 0) { Console.WriteLine("Division by zero error."); return; }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
