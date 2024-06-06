// dotnet run --property:DefineConstants="RUN_TASK5"
using System;

class Task5
{
#if RUN_TASK5
    static void Main()
    {
        Console.Write("Enter first whole number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second whole number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = AddNumbers(num1, num2);
        Console.WriteLine($"Sum of {num1} and {num2} equals to {sum}.");
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
#endif
}
