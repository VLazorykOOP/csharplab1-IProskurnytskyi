// dotnet run --property:DefineConstants="RUN_TASK2"
using System;

class Task2
{
#if RUN_TASK2
    static void Main()
    {
        Console.Write("Enter fisrt number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double maxNumber = Math.Max(number1, number2);

        Console.WriteLine($"Maximum value: {maxNumber}");
    }
#endif
}
