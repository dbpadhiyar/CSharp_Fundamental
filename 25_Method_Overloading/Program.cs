// The signature of method consists of name of method,type of parameter and number of parameter
// It's not possible to overload method  just based on return type or params modifier
class Program
{
    public static void Main()
    {
        Add(10, 20, out int a);
        Console.WriteLine($"Called methhod two integer and one out keyword and output is ${a}");
    }

    public static void Add(float a, float b, float c)
    {
        Console.WriteLine($"Sum of a and b and c is {a + b + c} - Float");

    }
    public static void Add(int a, int b, int c)
    {
        Console.WriteLine($"Sum of a and b and c is {a + b + c} - Integer");
    }

    public static void Add(int a, int b,out int c)
    {
        c = a + b;
        Console.WriteLine($"Sum of a and b and c is {a + b } - Integer");
    }
}