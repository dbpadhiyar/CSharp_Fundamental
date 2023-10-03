/*
 * list class is strongly type it means if list is type of customer you can only add object of customer type
 * we can add object of class which inherit customer class in list
 *
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


        List<Customer> listCustomer = new List<Customer>(2); // even if we give initial size of list it grow automatically
        listCustomer.Add(customer);
        listCustomer.Add(customer2);
        listCustomer.Add(customer3);


        //Adding inherited class of customer inside list<customer> list

        /*
           SavingCustomer savingCustomer = new SavingCustomer();
            listCustomer.Add(savingCustomer);
        */

        //Access particular customer
        Console.WriteLine("------- Particular customer from list-------");
        Customer particularCustomer = listCustomer[0];
        Console.WriteLine($"Id of particular customer is {particularCustomer.Id} & name is {particularCustomer.Name}");
        Console.WriteLine("------- Particular customer from End-------\n");

        //Accessing all customer through using foreach loop
        Console.WriteLine("------- Accessing all customer using foreach loop-------");
        foreach (var item in listCustomer)
        {
            Console.WriteLine($"Id of particular customer is {item.Id} & name is {item.Name}");
        }
        Console.WriteLine("------- Accessing all customer using foreach loop end-------\n");


        // Adding new customer object inside list at index value of  1
        Customer customer4 = new Customer()
        {
            Id = 4,
            Name = "Keyur",
            Salary = 400
        };
        listCustomer.Insert(1, customer4);

        // Accessing all customer through using for loop
        Console.WriteLine("------- Accessing all customer using for loop-------");
        for (int i = 0; i <listCustomer.Count; i++)
        {
            Console.WriteLine($"Id of particular customer is {listCustomer[i].Id} & name is {listCustomer[i].Name}");
        }
        Console.WriteLine("------- Accessing all customer using for loop end-------\n");

        //finding index of object inside list
        // if object found at more than one place first occurance index will be returned
        // we can pass index value inside IndexOf consgtructor
        // we can also pass range from from which position to which position we want to search indexof customer object, return -1 if not found        
        Console.WriteLine("------- finding index of customer inside of list customer using customer object-------");
        Console.WriteLine($"Index of Customer 2 is => {listCustomer.IndexOf(customer)}"); 
        Console.WriteLine("------- finding index of customer inside of list customer using customer object end -------\n");

    }
}

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Salary { get; set; }
}

public class SavingCustomer : Customer
{

}