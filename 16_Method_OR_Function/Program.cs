using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number to find all even number till that number");
        int number = int.Parse(Console.ReadLine());
        Program program = new Program(); 
        program.PrintEven(number);

    }
    public void PrintEven(int number)
    {
        int i = 1;
        while (i <= number)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}



