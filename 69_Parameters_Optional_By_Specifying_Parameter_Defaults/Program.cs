/*
 *  3rd way if making parameter optional
 *  Making paramter optional by specifying default value
 * 
 */

class Program
{
    public static void Main()
    {
        TotalValue(10, 20,30);
    }

    public static void TotalValue(int firstNumber, int secondNumber,int thirdNumber = 0)
    {
        int total  = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine($"Total of given number is => {total}");
    }
}