using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 10: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        else
        {
            Console.WriteLine("Invalid");
        }

        Console.ReadKey();
    }
}
