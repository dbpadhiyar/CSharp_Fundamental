public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}

public enum Gender
{
    Unknown,
    Male,
    Female
}

class Program
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];
        customers[0] = new Customer { Name = "Devendra",Gender = Gender.Male };
        customers[1] = new Customer { Name = "Vinit", Gender = Gender.Male };
        customers[2] = new Customer { Name = "Kavya", Gender = Gender.Female };

        foreach (var customer in customers)
        {
            Console.WriteLine($"Customer name is {customer.Name} and Customer gender is {GetGender(customer.Gender)}");
        }
    }

    public static string GetGender(Gender gender)
    {
        switch(gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Invalid data detected";
        }
    }
}