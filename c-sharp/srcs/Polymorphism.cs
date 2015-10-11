using System;

public class Employee
{
	public string _firstName;
	public string _lastName;
	public string _email;

	public virtual void PrintFullName()
	{
		Console.WriteLine(_firstName + " " + _lastName);
	}
}

public class FullTimeEmployee : Employee
{
	public override void PrintFullName()
	{
		Console.WriteLine(_firstName + " " + _lastName + " - Full Time");
	}
}

public class PartTimeEmployee : Employee
{
	public override void PrintFullName()
	{
		Console.WriteLine(_firstName + " " + _lastName + " - Part Time");
	}
}

class Polymorphism
{
	public static void Main()
	{
		var FTE = new FullTimeEmployee();
		FTE._firstName = "Pragim";
		FTE._lastName = "Tech";
		FTE.PrintFullName();

		var PTE = new PartTimeEmployee();
		PTE._firstName = "Part";
		PTE._lastName = "Tech";
		PTE.PrintFullName();
	}
}
