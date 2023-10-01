using _65_Indexers_In_CSharp;

class Program
{
    public static void Main()
    {
        Company company = new Company();
        Console.WriteLine($"Name of Employee whose id 1 is " + company[1]);
        Console.WriteLine($"Name of Employee whose id 3 is " + company[3]);
        Console.WriteLine($"Name of Employee whose id 5 is " + company[5]);

        Console.WriteLine("\n");
        Console.WriteLine("Changing value of user 3 & 5");
        Console.WriteLine("\n");


        company[3] = "Vishal";
        company[5] = "Vishal";

        Console.WriteLine("After changing name of 3 & 5");
        Console.WriteLine("\n");

        Console.WriteLine($"Name of Employee whose id 1 is " + company[1]);
        Console.WriteLine($"Name of Employee whose id 3 is " + company[3]);
        Console.WriteLine($"Name of Employee whose id 5 is " + company[5]);
        Console.WriteLine("\n");

        Console.WriteLine("Before Update");
        Console.WriteLine($"Total number of Male employee in company is => {company["Male"]}");
        Console.WriteLine($"Total number of Female employee in company is => {company["Female"]}");

        Console.WriteLine("\n");
        company["Male"] = "Female";

        Console.WriteLine("After Update");
        Console.WriteLine($"Total number of Male employee in company is => {company["Male"]}");
        Console.WriteLine($"Total number of Female employee in company is => {company["Female"]}");

    }
}