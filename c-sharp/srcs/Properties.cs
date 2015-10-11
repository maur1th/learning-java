using System;

public class Student
{
	private int _id;
	private string _name;
	private int _passMark = 35;
	public string Email { get; set; }
	public string City { get; set; }

	public int PassMark
	{
		get
		{
			return _passMark;
		}
	}

	public int Id
	{
		set
		{
			if (value <= 0)
			{
				throw new Exception("Student id cannot be negative or zero.");
			}
			_id = value;
		}
		get
		{
			return _id;
		}
	}

	public string Name
	{
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new Exception("Name cannot be null or empty.");
			}
			_name = value;
		}
		get
		{
			return string.IsNullOrEmpty(_name) ? "No Name" : _name;
		}
	}
}

public class Properties
{
	public static void Main()
	{
		var C1 = new Student();
		C1.Id = 101;
		C1.Name = "Thomas";
		C1.Email = "student@example.com";

		Console.WriteLine("ID: {0}, Name: {1}, PassMark: {2}, Email: {3}",
			C1.Id, C1.Name, C1.PassMark, C1.Email);
	}
}
