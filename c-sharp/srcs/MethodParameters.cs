using System;

class MethodParameters
{
	public static void Main()
	{
		int i = 0;
		SimpleMethod(ref i);
		Console.WriteLine(i);
	}

	public static void SimpleMethod(ref int j)
	{
		j = 101;
	}
}
