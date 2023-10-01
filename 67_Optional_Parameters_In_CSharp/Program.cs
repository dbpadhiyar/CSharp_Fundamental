/*
 * There are four different ways that can be used to make parameter optional
 * 1. Parameter arrays
 * 2. Method overloading
 * 3. specify parameter default
 * 4. Use OPtional attribute 
 */

class Program
{
    public static void Main()
    {
        int[] ints = { 1024, 2048, 4096, 8192, 16384 };
        AddNums(256, 512, ints);
    }

    /*
     * 1. Parameter arrays
     *  => parameter array must be last parameter
    */

    public static void AddNums(int firstNumber, int secondNumber, params int[] optionalNumbers)
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