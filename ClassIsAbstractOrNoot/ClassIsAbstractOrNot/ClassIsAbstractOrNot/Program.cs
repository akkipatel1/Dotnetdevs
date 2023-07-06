using System;
using System.Reflection;

abstract class abstractClass
{

    public abstract void abstractMethod();
}

class regularClass1
{

    public void regularMethod()
    {
        Console.WriteLine("This is method");
    }
}

class childClass : abstractClass
{

    public override void abstractMethod()
    {
        Console.WriteLine("This is method");
    }
}

class executeClass
{

    static void Main()
    {
        bool res1 = typeof(abstractClass).IsAbstract;
        bool res2 = typeof(regularClass1).IsAbstract;
        bool res3 = typeof(childClass).IsAbstract;

        Console.WriteLine("Is Geeks1 class is abstract class?" + res1);
        Console.WriteLine("Is Geeks2 class is abstract class?" + res2);
        Console.WriteLine("Is Geeks3 class is abstract class?" + res3);
    }
}
