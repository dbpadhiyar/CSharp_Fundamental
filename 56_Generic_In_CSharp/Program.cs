class Program
{
    public static void Main()
    {
        bool isEqualInt = Calculator.AreEqual<int>(10, 10);
        Console.WriteLine($"Is int value are equal? => {isEqualInt}");

        bool isEqualString = Calculator.AreEqual<string>("Devendra", "Devendra");
        Console.WriteLine($"Is string value are equal? => {isEqualString}");

    }
}

class Calculator
{
    // public static bool AreEqual(object value1, object value2)  
    // if we make object to pass any datatype it's increase performance issue due to boxing & unBoxing
    // AreEqual() method is not type safe
    public static bool AreEqual<T>(T value1, T value2) // improve performance
    {
        return value1.Equals(value2);
    }
}