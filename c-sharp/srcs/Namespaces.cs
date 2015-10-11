using System;

class Namespaces
{
	public static void Main()
	{
		Console.WriteLine("Hello");
		ProjectA.TeamA.ClassA.Print();
	}
}

namespace ProjectA
{
	namespace TeamA
	{
		static class ClassA
		{
			public static void Print()
			{
				Console.WriteLine("Team A Print Method");
			}
		}
	}
}
