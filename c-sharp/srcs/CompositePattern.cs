using System;
using System.Collections.Generic;

abstract class EmployeeComponent
{
	public string Name { private set; get; }

	internal EmployeeComponent(string name)
	{
		this.Name = name;
	}

	public virtual void PrintSupervisorOf(int spacing)
	{
		for (int counter = 0; counter < spacing; counter++)
		{
			Console.Write(" ");
		}
		Console.WriteLine(Name);
	}
}

class EmployeeComposite : EmployeeComponent
{
	private readonly IList<EmployeeComponent> employees;

	public EmployeeComposite(string name) : base(name)
	{
		employees = new List<EmployeeComponent>();
	}

	public void AddEmployee(EmployeeComponent e)
	{
		employees.Add(e);
	}

	public void RemoveEmployee(EmployeeComponent e)
	{
		employees.Remove(e);
	}

	public override void PrintSupervisorOf(int spacing)
	{
		base.PrintSupervisorOf(spacing);

		foreach (EmployeeComponent e in employees)
		{
			e.PrintSupervisorOf(spacing + 1);
		}
	}
}

class EmployeeLeaf : EmployeeComponent
{
	public EmployeeLeaf(string name) : base(name) {}
}

class CompositePattern
{
	static void Main()
	{
		var mark = new EmployeeComposite("Mark");
		var catherine = new EmployeeLeaf("Catherine");
		var david = new EmployeeLeaf("David");

		var kathy = new EmployeeComposite("Kathy");
		var mike = new EmployeeComposite("Mike");
		var gage = new EmployeeLeaf("Gage");
		var reg = new EmployeeLeaf("Reggie");

		// Lori is the boss of Mark and Kathy
		var lori = new EmployeeComposite("Lori");
		lori.AddEmployee(mark);
		lori.AddEmployee(kathy);

		// Mark is the boss of Catherine and David
		mark.AddEmployee(catherine);
		mark.AddEmployee(david);

		// Kathy is the boss of Mike
		kathy.AddEmployee(mike);

		// Mike is the boss of Gage and Reg
		mike.AddEmployee(gage);
		mike.AddEmployee(reg);

		lori.PrintSupervisorOf(0);
	}
}
