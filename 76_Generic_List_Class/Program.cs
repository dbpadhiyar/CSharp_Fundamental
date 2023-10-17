class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            Id = 1,
            Name = "Devendra",
            Salary = 10000,
            Type = 1
        };

        Customer customer2 = new Customer()
        {
            Id = 2,
            Name = "Vinit",
            Salary = 8000,
            Type = 1
        };

        Customer customer3 = new Customer()
        {
            Id = 3,
            Name = "Keyur",
            Salary = 30000,
            Type = 1
        };

        Customer customer4 = new Customer()
        {
            Id = 4,
            Name = "Avinash",
            Salary = 22000,
            Type = 2
        };

        Customer customer5 = new Customer()
        {
            Id = 5,
            Name = "Krrish",
            Salary = 50000,
            Type = 2
        };

        List<Customer> listRetailCustomers = new List<Customer>();
        listRetailCustomers.Add(customer1);
        listRetailCustomers.Add(customer2);
        listRetailCustomers.Add(customer3);

        List<Customer> listCorporateCustomers = new List<Customer>();
        listCorporateCustomers.Add(customer4);
        listCorporateCustomers.Add(customer5);

        listRetailCustomers.AddRange(listCorporateCustomers);

        //AddRange() allow use to add one list to another list
        Console.WriteLine("---------------- AddRange Start ----------------");
        foreach (var listRetailCustomer in listRetailCustomers)
        {
            Console.WriteLine($"Id => {listRetailCustomer.Id} Name => {listRetailCustomer.Name} Salary => {listRetailCustomer.Salary} Type => {listRetailCustomer.Type}");
        }
        Console.WriteLine("---------------- AddRange End ----------------\n");



        //getRange() allow use to get list of item from specific customer
        Console.WriteLine("---------------- getRange Start ----------------");
        List<Customer> getCustomerRangeList = listRetailCustomers.GetRange(3, 2);

        foreach (var getCustomerRange in getCustomerRangeList)
        {
            Console.WriteLine($"Id => {getCustomerRange.Id} Name => {getCustomerRange.Name} Salary => {getCustomerRange.Salary} Type => {getCustomerRange.Type}");
        }
        Console.WriteLine("---------------- getRange End ----------------\n");


        Customer customer6 = new Customer()
        {
            Id = 6,
            Name = "Satya",
            Salary = 50000,
            Type = 2
        };

        Customer customer7 = new Customer()
        {
            Id = 7,
            Name = "Jaimin",
            Salary = 78000,
            Type = 2
        };

        //InsertRange allow use to insert list in existing or new list and also allow use to specify index
        Console.WriteLine("---------------- InsertRange Start ----------------");
        List<Customer> newAddedCustomer = new List<Customer>();
        newAddedCustomer.Add(customer6);
        newAddedCustomer.Add(customer7);

        listRetailCustomers.InsertRange(0, newAddedCustomer);
        foreach (var listRetailCustomer in listRetailCustomers)
        {
            Console.WriteLine($"Id => {listRetailCustomer.Id} Name => {listRetailCustomer.Name} Salary => {listRetailCustomer.Salary} Type => {listRetailCustomer.Type}");
        }


        Console.WriteLine("---------------- InsertRange End ----------------\n");

        //RemoveRange allow use to remove multiple item from list by specifying index
        Console.WriteLine("---------------- RemoveRange Start ----------------");
        listRetailCustomers.RemoveRange(0, 2);
        foreach (var listRetailCustomer in listRetailCustomers)
        {
            Console.WriteLine($"Id => {listRetailCustomer.Id} Name => {listRetailCustomer.Name} Salary => {listRetailCustomer.Salary} Type => {listRetailCustomer.Type}");
        }
        Console.WriteLine("---------------- RemoveRange End ----------------\n");

    }
}

        

class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Salary { get; set; }

    public int Type { get; set; }
}