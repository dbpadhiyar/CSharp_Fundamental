//in method overriding a base class reference variable pointing to a child child class object, will invoke the
// overridden method in child class

//in method overhiding a base class reference variable pointing to a child class object , will invoke the hidden 
// method in base class

public class BaseClass
{
    public virtual void print()
    {
        Console.WriteLine("Called from base class");
    }
}
public class DerivedClass : BaseClass
{
    public override void print()
    {
        Console.WriteLine("Called from derived class");
    }
}

class Program
{
    public static void Main()
    {
        BaseClass baseClass = new DerivedClass();
        baseClass.print();
    }
}

