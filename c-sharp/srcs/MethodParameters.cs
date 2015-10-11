using System;

class MethodParameters
{
	public static void Main()
	{
		int i = 0;
		SimpleMethod(ref i);
		Console.WriteLine(i);

		int Sum;
		int Product;
		Calculate(10, 20, out Sum, out Product);
		Console.WriteLine("Sum = {0}, Product = {1}", Sum, Product);

		var Numbers = new int[3];
		Numbers[0] = 101;
		Numbers[1] = 102;
		Numbers[2] = 103;

		ParamsMethod(Numbers);
		ParamsMethod(1, 2, 3, 4, 5);
		ParamsMethod();
	}

	public static void SimpleMethod(ref int j)
	{
		j = 101;
	}

	public static void Calculate(int x, int y, out int sum, out int product)
	{
		sum = x + y;
		product = x * y;
	}

	public static void ParamsMethod(params int[] numbers)
	{
		Console.WriteLine("There are {0} elements", numbers.Length);
		foreach(int i in numbers)
		{
			Console.WriteLine(i);
		}
	}
}
