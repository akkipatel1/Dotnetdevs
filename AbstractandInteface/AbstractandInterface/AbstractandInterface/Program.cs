using System;
using System.Reflection;

public abstract class abstractClass
{

    public abstract void abstractMethod();
}

interface INteface1
{
    void show();
}

public class MyClass : abstractClass, INteface1
{
    public void show()
    {
        Console.WriteLine("Hello");
    }
    public override void abstractMethod()
    {
        Console.WriteLine("This is method");
    }

    public static void Main(string[] args)
    {
        MyClass obj= new MyClass(); 
        obj.show();
        obj.abstractMethod();
    }
}