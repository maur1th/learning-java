using System;

public class MethodOverloading
{
	public static void Main()
	{
		Add(1, 2);
		Add(1.2, 1.1);
	}

	public static void Add(int x, int y)
	{
		Console.WriteLine("Sum = {0}", x + y);
	}

	public static void Add(double x, double y)
	{
		Console.WriteLine("Sum = {0}", x + y);
	}

}
