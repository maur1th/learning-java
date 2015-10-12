using System;

class LeapYear
{
	internal static bool IsLeapYear(int year)
	{
		return (year % 4 == 0 && year % 100 != 0)
			|| (year % 4 == 0 && year % 400 == 0);
	}

	public static void Main(string[] args)
	{
		if(args.Length == 1)
		{
			int year = Convert.ToInt32(args[0]);
			Console.WriteLine(IsLeapYear(year));
		}
	}
}
