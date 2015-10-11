using System;

public abstract class Car
{
	public string Make { get; set; }
	public string Model { get; set; }
	public string EngineSize { get; set; }
	public string Colour { get; set; }
}

public class FordFiesta : Car
{
	public FordFiesta()
	{
		Make = "Ford";
		Model = "Fiesta";
		EngineSize = "1.1";
	}
}

interface ICreateCars
{
	Car CreateACar(string colour);
}

class FordFiestaFactory : ICreateCars
{
	public Car CreateACar(string colour)
	{
		var product = new FordFiesta();
		product.Colour = colour;
		return product;
		// Same as: return new FordFiesta() { Colour = colour };
	}
}

public class FactoryPattern
{
	static void Main()
	{
		var factory = new FordFiestaFactory() as ICreateCars;
		var myCar = factory.CreateACar("red");

		Console.WriteLine("{0} {1} {2}", myCar.Make, myCar.Model, myCar.Colour);
	}
}