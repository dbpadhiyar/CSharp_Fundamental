/*
 * Dictionary is one type of datatype which store value in key value pair
 * Dictionary contail 2 form of day 1st is key and 2nd is value
 * Key must be unique inside Dictionary
 * Dictionary provides fast lookups for value using keys
 */
class Program
{
    public static void Main()
    {
        Customer customer = new Customer()
        {
            Id = 1,
            Name = "Devendra",
            Salary = 100
        };

        Customer customer2 = new Customer()
        {
            Id = 2,
            Name = "Vinit",
            Salary = 200
        };

        Customer customer3 = new Customer()
        {
            Id = 3,
            Name = "Krrish",
            Salary = 300
        };


        Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
        customerDictionary.Add(customer.Id, customer);
        customerDictionary.Add(customer2.Id, customer2);
        customerDictionary.Add(customer3.Id, customer3);

        if (!customerDictionary.ContainsKey(customer.Id)) // to check whether key is already exist in dictionary or not
        {
            customerDictionary.Add(customer.Id, customer);
        }

        Customer cust = new Customer();
        if (customerDictionary.TryGetValue(1, out cust)) // trygetvalue return true if value found for given key
            Console.WriteLine($"Id => {cust.Id} Name =>{cust.Name},Id => {cust.Salary}");
        else
            Console.WriteLine("Key is not found");

        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine($"total items in dictionary is {customerDictionary.Count}");
        Console.WriteLine("---------------------------------------------------");

        Customer findCustomer = customerDictionary[3];
        Console.WriteLine($"Name of customer is {findCustomer.Name} and salary is {findCustomer.Salary}");
        Console.WriteLine("---------------------------------------------------");

        foreach (KeyValuePair<int, Customer> customers in customerDictionary)
        {
            Console.WriteLine($"ID of customer is {customers.Key}");
            Customer individualCustomer = customers.Value;
            Console.WriteLine($"ID is {individualCustomer.Id} Name is {individualCustomer.Name} and salary is {individualCustomer.Salary}");
        }
        Console.WriteLine("---------------------------------------------------");

    }
}

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Salary { get; set; }
}