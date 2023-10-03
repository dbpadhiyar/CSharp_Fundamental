/*
 * TryGetValue()    =>  TryGetValue is one of dictionary method which return true if it's find value for given key
 * Count()          =>  we can count number of values contain in dictionary and also apply filteration
 * Remove()         =>  we can remove specific key value pair by using Remove Method
 * Clear()          =>  we can remove all key value pair from dictionary using clear method
 * ToDictionary()   =>  we can convert array or list to dictionary
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
        Console.WriteLine($"total items in dictionary is where salary is > 200 {customerDictionary.Count(x => x.Value.Salary > 100)}");
        Console.WriteLine($"total items in dictionary is {customerDictionary.Count}");
        Console.WriteLine("---------------------------------------------------");

        //customerDictionary.Remove(1); // Remove particular key value pair // will not throw error if not found

        // customerDictionary.Clear(); // to remove all key value pair


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


        Console.WriteLine("--------- Array to dictionary -------------");
        Customer[] customerArray = new Customer[3];
        customerArray[0] = customer;
        customerArray[1] = customer2;
        customerArray[2] = customer3;

        Dictionary<int,Customer> convertedToDictionaryFromArray =  customerArray.ToDictionary(cust => cust.Id, customer => customer);

        foreach (KeyValuePair<int,Customer> item in convertedToDictionaryFromArray)
        {
            Console.WriteLine($"Key is {item.Key}");
            Console.WriteLine($" Id is => {item.Value.Id} Name is => {item.Value.Name} Salary is {item.Value.Salary}");
            Console.WriteLine("------------");
        }
        Console.WriteLine("--------- Array to dictionary End-------------");

        Console.WriteLine("--------- List to dictionary -------------");

        List<Customer> listCustomer = new List<Customer>();
        listCustomer.Add(customer);
        listCustomer.Add(customer2);
        listCustomer.Add(customer3);

        Dictionary<int, Customer> convertedToDictionaryFromList = customerArray.ToDictionary(cust => cust.Id, customer => customer);

        foreach (KeyValuePair<int, Customer> item in convertedToDictionaryFromList)
        {
            Console.WriteLine($"Key is {item.Key}");
            Console.WriteLine($" Id is => {item.Value.Id} Name is => {item.Value.Name} Salary is {item.Value.Salary}");
            Console.WriteLine("------------");
        }
        Console.WriteLine("--------- List to dictionary End-------------");

    }
}

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Salary { get; set; }
}