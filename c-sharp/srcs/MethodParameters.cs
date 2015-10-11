using System;

class MethodParameters
{
	public static void Main()
	{
		int i = 0;
		SimpleMethod(ref i);
		Console.WriteLine(i);

		int Total = 0;
		int Product = 0;
		Calculate(10, 20, out Total, out Product);
		Console.WriteLine("Sum = {0}, Product = {1}", Total, Product);
	}

	public static void SimpleMethod(ref int j)
	{
		j = 101;
	}

	public static void Calculate(int x, int y, out int Sum, out int Product)
	{
		Sum = x + y;
		Product = x * y;
	}
}
