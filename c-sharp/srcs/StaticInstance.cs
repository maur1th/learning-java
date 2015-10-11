using System;

class Circle
{
	public static float _pi;
	// readonly: public const float pi = 3.141F;
	int radius { get; set; }

	static Circle()
	{
		Console.WriteLine("Static Constructor Called");
		Circle._pi = 3.141F;
	}

	public Circle(int radius)
	{
		Console.WriteLine("Instance Constructor Called");
		this.radius = radius;
	}

	public float CalculateArea()
	{
		return _pi * radius * radius;
	}
}

class StaticInstance
{
	public static void Main()
	{
		var c1 = new Circle(5);
		Console.WriteLine("Area = {0}", c1.CalculateArea());

		var c2 = new Circle(6);
		Console.WriteLine("Area = {0}", c2.CalculateArea());
	}
}
