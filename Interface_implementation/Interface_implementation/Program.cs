// See https://aka.ms/new-console-template for more information
using System;
interface Top
{
    public void Multiply(int a,int b);
}

class Multiplication: Top
{
    public int mul;
    public void Multiply(int a, int b)
    {
        mul = a * b;
    }
}

class MulAndAdd : Multiplication
{
    public int add = 0;
    public void Addition()
    {
       add =  mul + 2;
    }
}

class MulAndAddAndSub : MulAndAdd
{
    public int sub = 0;
    public void Subtraction()
    {
        sub = add - 2;
        Console.WriteLine(sub);
    }
}


class Program
{
    public static void Main(string[] args)
    {
        //public int a = Console.ReadLine();
        MulAndAddAndSub m = new MulAndAddAndSub();
        m.Multiply(2, 3);
        m.Addition();
        m.Subtraction();
    }
}
