using System;

public class Employee
{
	public string _firstName;
	public string _lastName;
	public string _email;

	public void PrintFullName()
	{
		Console.WriteLine(_firstName + " " + _lastName);
	}
}

public class FullTimeEmployee : Employee
{
	public float _yearlySalary;
}

public class PartTimeEmployee : Employee
{
	public float _hourlyRate;
}

class Inheritance
{
	public static void Main()
	{
		var FTE = new FullTimeEmployee();
		FTE._firstName = "Pragim";
		FTE._lastName = "Tech";
		FTE._yearlySalary = 50000;
		FTE.PrintFullName();

		var PTE = new PartTimeEmployee();
		PTE._firstName = "Part";
		PTE._lastName = "Tech";
		PTE._hourlyRate = 10;
		PTE.PrintFullName();
	}
}
