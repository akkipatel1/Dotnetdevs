//// See https://aka.ms/new-console-template for more information
using System;

//class Parent
//{
//    public int pubA = 0;
//    private int priA;
//    protected int proA;

//    public Parent()
//    {

//    }
//    public Parent(int pubA, int priA, int proA)
//    {
//        this.pubA = pubA;
//        this.priA = priA;
//        this.proA = proA;
//    }   
//}

//class Child: Parent
//{
//    public int pubB;

//    public void test()
//    {
//        pubA++;
//        proA++;
//       // priA++; not accessible
//    }

//    public Child()
//    {

//    }

//    public Child(int PubB)
//    {
//        proA = PubB;
//        pubA++;
//        //priA = 2; though memory is allocated when constructor is called , it is not directly accessible
//        Console.WriteLine(proA);
//        Console.WriteLine(pubA);
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Parent p = new Child();
//        Child c = new Child(); // I cannot do this

//        //c = p; i cannot do this
//        p =c;

//        c = (Child)p; // I can do this because 
//    }
//}

abstract class AbsClass
{
    // nothing here for now
}

class NormalClass
{
    // nothing here for now
}

class Program
{
    public static void Main(string[] args)
    {
        Type classType = typeof(NormalClass);
        Console.WriteLine($"Normal is abstract ?? {classType.IsAbstract}");

        Type absType = typeof(AbsClass);
        Console.WriteLine($"Abs is abstract ?? {absType.IsAbstract}");
    }
}

