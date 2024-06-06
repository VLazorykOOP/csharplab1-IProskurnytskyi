// dotnet run --property:DefineConstants="RUN_TASK3"
using System;

class Task3
{
#if RUN_TASK3
    static void Main()
    {
        Console.Write("Enter x: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        float y = float.Parse(Console.ReadLine());

        if ((x * x + y * y == 144 && y <= x) || (y == x && x * x + y * y <= 144))
        {
            Console.WriteLine("On the boundary");
        }
        else if ((x * x + y * y < 144 && y <= x))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
#endif
}
