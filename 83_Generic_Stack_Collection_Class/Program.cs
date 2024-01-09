// Last added item will be added top of the stack using Push().
// Last added item will be removed first in stack using POP().
// LIFO
class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            Id = 1,
            Name = "Devendra",
            Gender = "Male"
        };

        Customer customer2 = new Customer()
        {
            Id = 2,
            Name = "Keyur",
            Gender = "Male"
        };

        Customer customer3 = new Customer()
        {
            Id = 3,
            Name = "Deep",
            Gender = "Male"
        };

        Customer customer4 = new Customer()
        {
            Id = 4,
            Name = "Avi",
            Gender = "Male"
        };

        Customer customer5 = new Customer()
        {
            Id = 5,
            Name = "Krrish",
            Gender = "Male"
        };

        Stack<Customer> customerStack = new Stack<Customer>();
        customerStack.Push(customer1); // push() will add item top of the stack
        customerStack.Push(customer2);
        customerStack.Push(customer3);
        customerStack.Push(customer4);
        customerStack.Push(customer5);

        Customer popCustomer = customerStack.Pop(); // remove last added (at end of stack) and return it.

        Customer customerPeek = customerStack.Peek(); // return the object which present at top of stack without removing it.

        Console.WriteLine($"name of removed customer is => {popCustomer.Name}");
        Console.WriteLine($"Total number of customer after pop operation is => {customerStack.Count}");

        foreach (var customer in customerStack)
        {
            Console.WriteLine($"Id is {customer.Id}. Name is {customer.Name} and gender is => {customer.Gender}");
        }
    }
}
public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Gender { get; set; }
}