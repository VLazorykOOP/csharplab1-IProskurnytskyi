// dotnet run --property:DefineConstants="RUN_TASK4"
using System;

class Task4 
{
#if RUN_TASK4
	static void Main() 
	{
		Console.Write("Enter the serial number of the month: ");
		int monthNumber = Convert.ToInt32(Console.ReadLine());

		if (monthNumber < 0 || monthNumber > 12)
		{
			Console.WriteLine("Error: Incorrect month number.");
			return;
		}

		int monthsRemaining = 12 - monthNumber;

		Console.WriteLine($"There are {monthsRemaining} months left until the end of the year.");
	}
#endif
}
