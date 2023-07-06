 // See https://aka.ms/new-console-template for more information

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog: Animal
{
    public void MakeSound() { Console.WriteLine("Dog Barks"); }
}

class Cat: Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Cat meows");
        base.MakeSound();
    }
}

class Pro
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();
    }
}
