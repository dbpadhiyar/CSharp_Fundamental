using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Your Name");
        string? Name = Console.ReadLine();

        if (Name != null && Name!=string.Empty)
        {
            if (Name.Length > 5)
                Console.WriteLine("{0} is a big name", Name);
            else
                Console.WriteLine("{0} is small name", Name);
        }
        else
            Console.WriteLine("\nYou Are Confused");

        Console.ReadKey();
    }
}