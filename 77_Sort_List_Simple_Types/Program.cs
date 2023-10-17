// Dot net provide method to sort data buth those data should be simple data like string,int
// Dot net by default not allow use to sort complex data like list

class Program
{
    public static void Main()
    {
        List<int> listNumbers = new List<int>() { 1, 8, 7, 4, 3, 14, 40, 2, 9, 18 };

        Console.WriteLine("Before sorting number");
        foreach (int number in listNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("After sorting number\n");
        listNumbers.Sort();
        foreach (int number in listNumbers)
        {
            Console.WriteLine(number);
        }


        Console.WriteLine("After reversing number\n");
        listNumbers.Reverse();
        foreach (int number in listNumbers)
        {
            Console.WriteLine(number);
        }

    }
}