using System;
using System.Collections.Generic;

public delegate void HelloFunctionDelegate(string message);

class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Salary { get; set; }
	public int Experience { get; set; }

	public void PromoteEmployee(List<Employee> employeeList)
	{
		foreach(Employee employee in employeeList)
		{
			if (employee.Experience >= 5)
			{
				Console.WriteLine(employee.Name + " promoted");
			}
		}
	}
}

class Delegates
{
	static void Main()
	{
		var del = new HelloFunctionDelegate(Hello);
		del("Hello from delegate");
	}

	public static void Hello(string message)
	{
		Console.WriteLine(message);
	}
}
