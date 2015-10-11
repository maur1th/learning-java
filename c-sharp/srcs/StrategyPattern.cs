using System;

public interface IWeapon
{
	void Use();
}

public class Sword : IWeapon
{
	public void Use()
	{
		Console.WriteLine("Using Sword.");
	}
}

public class Axe : IWeapon
{
	public void Use()
	{
		Console.WriteLine("Using Axe.");
	}
}

public class Club : IWeapon
{
	public void Use()
	{
		Console.WriteLine("Using Club.");
	}
}

public class Character
{
	public IWeapon _weapon;

	public void SetWeapon(IWeapon weapon)
	{
		_weapon = weapon;
	}

	public void Attack()
	{
		_weapon.Use();
	}
}

public class StrategyPattern
{
	static void Main()
	{
		IWeapon weapon = null;
		var Tom = new Character();

		while (true)
		{
			Console.WriteLine("Choose a weapon: (1 = Sword, 2 = Axe, 3 = Club)");
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					weapon = new Sword();
					break;
				case "2":
					weapon = new Axe();
					break;
				case "3":
					weapon = new Club();
					break;
			}
			Tom.SetWeapon(weapon);
			Tom.Attack();
		}
	}
}
