/*
 * Exception Handling Abuse 
 * 
 * Following program is example of exception handling abuse
 * 
 * 
*/


class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Please enter numerator");
            int Numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Denominator");
            int Denomirator = Convert.ToInt32(Console.ReadLine());

            int result = Numerator / Denomirator;

            Console.WriteLine($"Result is => {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid number");
        }
        catch(OverflowException) 
        {
            Console.WriteLine($"Please Enter number between {Int32.MinValue} to {Int32.MaxValue}");
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Denominator cannot be zero");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}