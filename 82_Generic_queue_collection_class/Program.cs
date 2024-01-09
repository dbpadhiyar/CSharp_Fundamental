// Last added item will be added bottom of the queue using Enqueue().
// first added item will be removed first in queue using Dequeue().
// FIFO
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

        Queue<Customer> customerQueue = new Queue<Customer>();
        customerQueue.Enqueue(customer1); //Add object in queue
        customerQueue.Enqueue(customer2);
        customerQueue.Enqueue(customer3);
        customerQueue.Enqueue(customer4);
        customerQueue.Enqueue(customer5);

        Customer deletedCustomer = customerQueue.Dequeue(); // return and remove item which avilable at beginning at queue

        Console.WriteLine($"Deleted customer name is => {deletedCustomer.Name}", deletedCustomer.Name);
        Console.WriteLine($"Total number of customer after dequeue is => {customerQueue.Count}");

        foreach (var customer in customerQueue)
        {
            Console.WriteLine($"Id is {customer.Id}. Name is {customer.Name} and gender is => {customer.Gender}");
        }

        customerQueue.Peek(); // return the object which is beginning at queue
        Console.WriteLine($" Is customer 1 exist ? {customerQueue.Contains(customer3)} "); 
        customerQueue.Clear(); // remove all objects from data

    }
}

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Gender { get; set; }
}

