/*
 *  4th way if making parameter optional
 *  Making paramter optional by using optional attribute
 * 
 */

using System.Runtime.InteropServices;
class Program
{
    public static void Main()
    {
        AddNums(1, 2);
        AddNums(1,2,new int[] {3,4,5,6,7,8,9,10});
    }

    public static void AddNums(int firstNumber, int secondNumber, [Optional] int[] optionalNumbers)
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