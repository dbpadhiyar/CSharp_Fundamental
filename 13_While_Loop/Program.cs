using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Write down your target");
        int UserTarget = int.Parse(Console.ReadLine());

        int CurrentValue = 1;
        while(CurrentValue <= UserTarget)
        {            
            Console.WriteLine("CurrentValue is => {0}", CurrentValue);
            CurrentValue++;
        }
    }
}