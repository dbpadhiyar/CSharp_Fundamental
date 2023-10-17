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
        listCustomer.Insert(3, customer4);

        // Accessing all customer through using for loop
        Console.WriteLine("------- Accessing all customer using for loop-------");
        for (int i = 0; i < listCustomer.Count; i++)
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


        // contain() function retrurn true or false if the list contain object it will return true

        Console.WriteLine("------- Conatin start-------");
        if (listCustomer.Contains(customer4))
            Console.WriteLine("Customer 4 is contains in list");
        else
            Console.WriteLine("Customer 4 is not contains in list");
        Console.WriteLine("------- Conatin end \n-------");

        //Exist() return true or false same as contain but it take condition on list object as parameter
        Console.WriteLine("------- Exists start-------");
        if (listCustomer.Exists(cust => cust.Name.StartsWith("Raj")))
            Console.WriteLine("Customer name start with Dev available in listcusomer");
        else
            Console.WriteLine("Customer name start with Dev not available in listcusomer");
        Console.WriteLine("------- Exists end \n-------");

        //Find() return the first matching item from list
        Console.WriteLine("------- Find start-------");
        Customer customerFind = listCustomer.Find(cust => cust.Salary > 100);
        Console.WriteLine($"Id => {customerFind.Id} Name => {customerFind.Name} Salary => {customerFind.Salary}");
        Console.WriteLine("------- Find End --------- \n");

        //FindLast() return the last matching item from list
        Console.WriteLine("------- FindLast start-------");
        Customer customerFindLast = listCustomer.Find(cust => cust.Salary > 250);
        Console.WriteLine($"Id => {customerFindLast.Id} Name => {customerFindLast.Name} Salary => {customerFindLast.Salary}");
        Console.WriteLine("------- FindLast End --------- \n");

        //FindAll() return the list of matching item from list
        Console.WriteLine("------- FindAll start-------");
        List<Customer> customerFindAll = listCustomer.FindAll(cust => cust.Salary > 250);
        foreach(Customer cust in customerFindAll)
        {
            Console.WriteLine($"Id => {cust.Id} Name => {cust.Name} Salary => {cust.Salary}");
        }
        Console.WriteLine("------- FindAll End --------- \n");

        //FindIndex() Returns the index of the first item,that matches the condition specified by the lambda expression 
        //FindIndex() there are 2 overloads of this method which allows us to specify range of elements of search , with in the list

        Console.WriteLine("------- FindIndex start-------");
        int FirstIndex = listCustomer.FindIndex(cust => cust.Salary > 299);
        Console.WriteLine($"The first index where salary > 299 is => {FirstIndex}");
        Console.WriteLine("------- FindIndex End --------- \n");

        //FindLastIndex() Returns the index of the last item,that matches the condition specified by the lambda expression 
        //FindLastIndex() there are 2 overloads of this method which allows us to specify range of elements of search , with in the list

        Console.WriteLine("------- FindLastIndex start-------");
        int lastIndex = listCustomer.FindLastIndex(2,2,cust => cust.Salary > 299);
        Console.WriteLine($"The last index where salary > 299 is => {lastIndex}");
        Console.WriteLine("------- FindLastIndex End --------- \n");


        Console.WriteLine("Convert an array to list using => ToList() <=\n");
        Console.WriteLine("Convert list to an array using => ToArray() <=\n");
        Console.WriteLine("Convert list to dictionary => ToDictionary() <=\n");



        Console.WriteLine("------- Array to ToList() start-------");
        Customer[] customerArray = new Customer[4];
        customerArray[0] = new Customer { Id = 11,Name="John",Salary=11110};
        customerArray[1] = new Customer { Id = 22,Name="Nicolas",Salary=8800};
        customerArray[2] = new Customer { Id = 14,Name="Brad",Salary=14000};
        customerArray[3] = new Customer { Id = 23,Name="zenny",Salary=6500};

        List<Customer> customerArrayToList = customerArray.ToList();
        foreach(Customer cust  in customerArrayToList)
        {
            Console.WriteLine($"ID => {cust.Id} Name => {cust.Name} Salary => {cust.Salary}");
        }
        Console.WriteLine("------- Array to ToList() end-------\n");


        Console.WriteLine("------- List to Array Start-------");
        List<Customer> customers = new List<Customer>();
        customers.Add(customer);
        customers.Add(customer2);
        customers.Add(customer3);
        customers.Add(customer4);

        Customer[] customerArrayFromList =  customers.ToArray();
        for(int i = 0;i < customerArrayFromList.Length; i++ )
        {
            Console.WriteLine($"ID => {customerArrayFromList[i].Id} Name => {customerArrayFromList[i].Name} Salary => {customerArrayFromList[i].Salary}");
        }
        Console.WriteLine("------- List to Array End-------\n");


        Console.WriteLine("------- List to Dictionary Start-------");
        Dictionary<int, Customer> customerDictionaryFromLists = customerArrayToList.ToDictionary(x => x.Id);       
        foreach (KeyValuePair<int,Customer> customerDictionaryFromList in customerDictionaryFromLists)
        {
            Console.WriteLine($"Key is {customerDictionaryFromList.Key}");
            Customer c = customerDictionaryFromList.Value;
            Console.WriteLine($"ID => {c.Id} Name => {c.Name} Salary => {c.Salary}");
        }
        Console.WriteLine("------- List to Dictionary End-------\n");


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