// dotnet run --property:DefineConstants="RUN_TASK1"
using System;

class Task1
{
#if RUN_TASK1
    static void Main()
    {
        Console.Write("Enter the perimeter of the square (a): ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 4;

        double area = side * side;

        Console.WriteLine($"The area of the square is: {area}");
    }
#endif
}
