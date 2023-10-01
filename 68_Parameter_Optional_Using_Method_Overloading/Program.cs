/*
 *  2nd way if making parameter optional
 *  Making paramter optional using method overloading
 * 
 */ 

class Program
{
    public static void Main()
    {
        int[] ints = { 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384 };
        AddNums(1, 2);
        AddNums(1,2,ints);

    }
    public static void AddNums(int firstNumber, int secondNumber)
    {
        int total = firstNumber + secondNumber;
        Console.WriteLine($"Total number of given numbers is {total}");
    }

    public static void AddNums(int firstNumber, int secondNumber, int[] optionalNumbers)
    {
        int total = firstNumber + secondNumber;
        if (optionalNumbers != null)
        {
            foreach (int i in optionalNumbers)
            {
                total += i;
            }
        }
        Console.WriteLine($"Total number of given numbers is {total}");
    }
}