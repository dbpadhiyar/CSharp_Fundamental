using System;


public class Customer
{
    string _firstName = string.Empty;
    string _lastName = string.Empty;

    public Customer() : this("Empty First","Empty Second") // this constructor will be not called if we have parameter construcor and passed value inside it
    {                                                      // Static constructor will be called only once, no matter how many instance you create
                                                           // even when we try to access proprty of class static constructor will because it need to initialize static value
                                                           // Must be parameter less
        Console.WriteLine("Parameter Less Constructor Called");
    }

    static Customer()  //Access Modifier not available with static constructor & it will call first
    {
        Console.WriteLine("Static Constructor Called");
    }
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Parameter Constructor Called \nFull Name is => {0} {1}", this._firstName, this._lastName);
    }
}
class Program
{  
    public static void Main()
    {
        Customer customer = new Customer("Devendra", "Padhiyar");
        customer.PrintFullName();
    }
}