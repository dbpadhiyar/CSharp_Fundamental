/*
 * Abstract class can have implementations of some of it's members (methods), but the interface can't have 
 * implementation for any of it's member 
 * 
 * interface cannot have fields
 * 
 * An interface can only be inherited by interface while abstarct class can inherit from 
 * another abstract class or another interface
 *
 * A Class can inherit from multiple interface at same time but cannot inherited from multiple abstract class
 * at a same time
 * 
 * Abstract class members can have access modifiers where an interface member cannot have access modofier
*/

public abstract class Customer
{
    public void Print()
    {
        Console.WriteLine("Print method of Customer abstract class");
    }
}

class Program : Customer
{
    public static void Main()
    {
        Customer c = new Program();
        c.Print();
    }
}
