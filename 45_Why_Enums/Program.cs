/*
 *  Why Enums is required 
 * 
 * Enum is strongly type constant
 * 
 * if we have multiple constant we need to remind all value by ourself
 * 
 * to solve this issue we need to use Enum
 * 
 * 
*/ 

/*
 * 0 - unknown
 * 1 - Male
 * 2 - Female
*/
public class Customer
{
    public string Name { get; set; }
    public int Gender { get; set; }
}



class Program
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];
        customers[0] = new Customer { Name = "Devendra", Gender = 1 };
        customers[1] = new Customer { Name = "Vinit", Gender = 1 };
        customers[2] = new Customer { Name= "Kavya", Gender= 2 };

        foreach (var customer in customers)
        {
            Console.WriteLine($"Customer name is {customer.Name} and Customer gender is {GetGender(customer.Gender)}");
        }
    }

    public static string GetGender(int Gender)
    {
        string result = Gender == 1 ? "Male" : Gender == 2 ? "Female" : Gender == 0 ? "Unknown" : "Invalid  Gender";
        return result;
    }
}