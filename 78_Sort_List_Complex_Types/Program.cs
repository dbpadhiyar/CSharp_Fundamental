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

        Console.WriteLine("Before Sorting Customer");
        foreach (var item in listRetailCustomers)
        {
            Console.WriteLine($"Id {item.Id} Name => {item.Name} Salary => {item.Salary} Type => {item.Type}");
        }
        Console.WriteLine("\n");

        Console.WriteLine("After Sorting Customer and reverse it");
        listRetailCustomers.Sort();
        listRetailCustomers.Reverse();
        foreach (var item in listRetailCustomers)
        {
            Console.WriteLine($"Id {item.Id} Name => {item.Name} Salary => {item.Salary} Type => {item.Type}");
        }
        Console.WriteLine("\n");

        Console.WriteLine("After Sorting Customer by name");
        SortByName sortByName = new SortByName();
        listRetailCustomers.Sort(sortByName);
        foreach (var item in listRetailCustomers)
        {
            Console.WriteLine($"Id {item.Id} Name => {item.Name} Salary => {item.Salary} Type => {item.Type}");
        }
        Console.WriteLine("\n");
    }
}

class SortByName : IComparer<Customer>
{
    public int Compare(Customer x,Customer y)
    {
        return x.Name.CompareTo(y.Name);
    }
}

class Customer : IComparable<Customer>
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Salary { get; set; }

    public int Type { get; set; }

    public int CompareTo(Customer other)
    {
        /*
         if (this.Salary > other.Salary)
            return 1;
        else if (this.Salary < other.Salary)
            return -1;
        else
            return 0;
        */
        return this.Salary.CompareTo(other.Salary);
    }
}