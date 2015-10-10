using System;

namespace FactoryMethodEx
{
	class Program
	{
		static void Main(string[] args)
		{
			var factory = new FordFiestaFactory() as ICreateCars;
			var myCar = factory.CreateACar("red");
			Console.Writeline("Make: " myCar.Make + " " + myCar.Model + " " myCar.Colour);
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
			return new FordFiesta(){Colour = colour};
		}
	}
	
	abstract class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public string Engine { get; set; }
		public string Colour { get; set; }
	}
	
	public class FordFiesta : Car
	{
		public FordFiesta()
		{
			Make = "Ford";
			Model = "Fiesta";
			Engine = "1.1";
		}
	}
}