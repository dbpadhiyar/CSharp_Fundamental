// Structs

// structs is just like class structs can have
// 1. private fields
// 2. public Properties
// 3. constructor
// 4. Methods

public struct Customer
{
    private int _id;
    private string _name;
     
    public int Id { get { return _id; } set { this._id = value; } }

    public string Name { get { return _name; } set { this._name = value; } }

    public Customer(int Id , string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void PrintDetail()
    {
        Console.WriteLine($"Id is => {this._id} and name is => {this._name}");
    }

}

public class Program
{
    public static void Main()
    {
        Customer customer = new Customer(101,"Devendra"); // using Constructor we assigned value in struct
        customer.PrintDetail();

        Customer customer1 = new Customer(); // using properties of structure to initiale property
        customer1.Id = 102;
        customer1.Name = "Vinit";
        customer1.PrintDetail();

        //using object initialize syntax to initialize class or struct
        Customer customer2 = new Customer
        {
            Id = 103,
            Name = "Krish"
        };
        customer2.PrintDetail();
    }
}