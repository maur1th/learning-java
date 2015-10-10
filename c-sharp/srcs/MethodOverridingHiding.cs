using System;

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Base Class");
    }
}

public class ChildClass : BaseClass
{
    public override void Print() // 'new' to hide
    {
        Console.WriteLine("Child Class");
    }
}

public class Polymorphism
{
    public static void Main()
    {
        var a = new BaseClass();
        var b = new ChildClass();
        a.Print();
        b.Print();
    }
}