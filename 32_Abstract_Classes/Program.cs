/*
 *  Abstract class
 *  
 *  TO use abstract class we use abstract keyword
 *  
 *  Class which inherit abstract class need to provide it's implementation
 *  
 *  but if derived class is also abstract class we don't need to provide it's implementation
 *  
 *  abstract class can only be used as base class 
 *  
 *  abstract class cannot be sealed
 *  
 *  abstract class may contain abstract member(methods,properties,indexers,events) but not mandatory
 *  
 *  in order to provide of implementation of abstract class we need to use override keyword
 */


abstract class Customer
{
    public abstract void Print();
}

class Program : Customer
{
    public static void Main()
    {
        Program program = new Program();
        program.Print();

        Customer c = new Program(); // Parent class reference variable can point derived class object (inheritance concept )
        c.Print();
    }

    public override void Print()
    {
        Console.WriteLine("Print method of Customer Abstract class");
    }
}