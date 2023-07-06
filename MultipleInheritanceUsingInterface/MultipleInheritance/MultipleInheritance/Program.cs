using System;
using System.Reflection;

interface IPrey
{
    void Prey();
}
interface IHunt
{
    void Hunt();
}

public class AnimalCharacteristic : IPrey, IHunt
{

    public void Prey()
    {
        Console.WriteLine("This animal get hunted by hunters");
    }
    public void Hunt()
    {
        Console.WriteLine("This animals are hunters");
    }

}

public class Executingclass
{
    public static void Main(string[] args)
    {
        AnimalCharacteristic lion = new AnimalCharacteristic();
        AnimalCharacteristic rabbit = new AnimalCharacteristic();

        lion.Hunt();
        rabbit.Prey();
    }
}
