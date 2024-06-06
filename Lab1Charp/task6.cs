// dotnet run --property:DefineConstants="RUN_TASK6"
using System;

class Program
{
#if RUN_TASK6
    static void Main()
    {
        Console.Write("Enter value a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = a + ((a + b - 1) / ((Math.Pow(a, 2)) + 1)) - (a * b);

        Console.WriteLine($"The value of the expression a + ((a + b - 1)/((a^2)+1)) - (a*b) equals to {result}.");
    }
#endif
}
