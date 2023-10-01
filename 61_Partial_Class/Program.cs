using _61_Partial_Class;

class Program
{
    public static void Main()
    {
        CustomerOne customer = new CustomerOne();   
        customer.FirstName = "Devendra";
        customer.LastName = "Padhiyar";
        customer.Id = 1;
        Console.WriteLine(customer.GetCustomerInfo());
    }
}