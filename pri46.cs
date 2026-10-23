using System;

abstract class Test
{
    public abstract void A();
}

class Example1 : Test
{
    public override void A()
    {
        Console.WriteLine("Example1.A");
    }
}

class Example2 : Test
{
    public override void A()
    {
        Console.WriteLine("Example2.A");
    }
}

class pri46
{
    static void Main()
    {
        // Reference Example1 through Test type
        Test test1 = new Example1();
        test1.A();

        // Reference Example2 through Test type
        Test test2 = new Example2();
        test2.A();

        Console.Read();
    }
}