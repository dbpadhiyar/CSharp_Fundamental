// interface is default have public access modifier and we cannot change it

// interface cannot declare logic inside it

// interface cannot contain property

// multiple class inheritation not possible but multiple interface possible

// we can inherit one interface to another interface

// if our class inherited interface and that interface also inherited from another interface we need to provide implementation
// in derived class

// we cannot create instance of interface

interface ICustomerNew
{
    void PrintDetail();
}

interface ICustomerOld
{
    void PrintDetail();
}
public class Customer : ICustomerNew, ICustomerOld
{
    void ICustomerOld.PrintDetail()
    {
        Console.WriteLine("Called from Printdetail in customer class Old");
    }

    void ICustomerNew.PrintDetail()
    {
        Console.WriteLine("Called from Printdetail in customer class New");
    }

}

class Program
{
    public static void Main()
    {
        Customer customer = new Customer();
        ((ICustomerNew)customer).PrintDetail();
        ((ICustomerOld)customer).PrintDetail();
    }
}
