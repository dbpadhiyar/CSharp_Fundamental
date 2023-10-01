/*
 * Attribute allow you to add declarative information to your program. this information can then be quwried at runtime using reflection  
 * 
 * there are several pre-defined attribute provided by .NET. it is also possible to create your own custom attribute
 * 
 * Pre-defined attrinute like (obsolete, WebMethood, Serialzable)
 * 
 * it's possible to customize the attribute using parameters
 * 
 * An attribute is class that is inherits from System.attribute base class.
 *
 * When we are developing remoting apllication or WCF application where object will be crossing application domain boundary and those objects need
 * to serialize at that time we can use [Serializable] attribute
 *
 * [Obsolete] attribute can take 2 arguments 1st is message(string) and second is error(boolean) if error is true it will throw compile time error
 * by default both parameter is optional
 *
*/


public class Program
{
    public static void Main()
    {
        Calculator.Add(10,12);
        Calculator.Add(new List<int>() {1,2,3,4,5,6,7,8,9,10});
    }
}

public class Calculator
{
    [Obsolete("Use This method => Add(List<int> num)",false)]
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Add(List<int> num)
    {
        int total = 0;
        foreach (var item in num)
        {
            total += item;
        }
        return total;
    }

}

