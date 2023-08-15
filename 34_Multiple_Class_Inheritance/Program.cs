/*
 * 
 * 
 * 
 * 
 */


class A
{
    public virtual void Print()
    {
        Console.WriteLine("Print method of a class");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("Print method of B class");
    }
}

class C : A
{
    public override void Print()
    {
        Console.WriteLine("Print method of C class");
    }
}

//class D : B,C // this called Diamond problem
class D : C
{
    public override void Print()
    {
        Console.WriteLine("Print method of D class");
    }
}

class Program
{
    public static void Main()
    {

    }
}