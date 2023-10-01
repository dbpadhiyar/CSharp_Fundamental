/*
 * What is ToString()
 * Why should we override it
 * every type in c# directly or indirectly inherit from system.object
*/

class Program
{
    public static void Main()
    {
        int number = 10;
        Console.WriteLine(number.ToString()); 

        Customer customer = new Customer();
        customer.FirstName = "Dev";
        customer.LastName = "Padhiyar";
        Console.WriteLine(customer.ToString()); // will print namespace.typename(class name); if we don't override tostring() in our class 

    }
}

class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return this.FirstName + " " + this.LastName;
    }
}