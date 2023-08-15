/*
 * Delegate is reference types 
 * 
 * Delegate is type safe function ponter
 * 
 * to point a function through delegate we need to create instance of delegate
 *
 * The signature of delegate must match the signature of the function, the delegates point to. otherwise
 * you get a compiler error. this is the reason delegate are called as type safe function pointers
 * 
 * Delegate is similar to class, you can create instance of delegate and when you do so , you have to pass
 * in the function name as a parameter to delegate constructor, and it is to this function the delegate points to 
 * 
 * Delegate syntax is same as method but contain delegate keyword before return type
*/

/*
 * Following delegate can point any method which has void return type and takes a string parameter
*/

public delegate void HelloFnDelegate(string message); 


class Program
{
    public static void Main()
    {
        HelloFnDelegate helloFn = new HelloFnDelegate(Hello);
        helloFn("Hello, Welcome DP Solutions");
    }

    public static void Hello(string message)
    {
        Console.WriteLine(message);
    }
}