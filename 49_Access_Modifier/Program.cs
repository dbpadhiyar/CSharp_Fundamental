/*
 *  Privare            ->  Private member accessible to only class in which it defined
 *  Public             ->  Public member can be accessible from anywhere
 *  Protected          ->  Protected can be accessible in class where it defined or in a class where we inherited class
*/

public class Customer
{
    private int _id;

    private string _name;

    protected int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}

public class Program
{
    private static void Main()
    {
        Customer customer = new Customer();
        Console.WriteLine(customer.Name);
    }
}

public class CorporateCustomer : Customer 
{
    public void printId()
    {
        CorporateCustomer cc = new CorporateCustomer();
        cc.Id = 1;
        base.Id = 100;
        this.Id = 1000;
    }
}