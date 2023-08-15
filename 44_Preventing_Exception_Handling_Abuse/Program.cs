/*
 * Preventing Exception Handling Abuse 
 * 
 * in this example we prevented exception handling abuse (check 43 program what is Exception handling abuse)
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
            int Numerator; 
            bool isNumeratorConverted =  int.TryParse(Console.ReadLine(), out Numerator);    

            if(isNumeratorConverted)
            {
                Console.WriteLine("Please enter numerator");
                int Denomirator;
                bool isDenomiratorConverted = int.TryParse(Console.ReadLine(), out Denomirator);

                if(isDenomiratorConverted && Denomirator != 0)
                {
                    int result = Numerator / Denomirator;
                    Console.WriteLine($"Result is => {result}");
                }
                else
                {
                    if(Denomirator == 0)
                    {
                        Console.WriteLine("Denominator cannot be zero");
                    }
                    else
                    {
                        Console.WriteLine($"Denomirator should be valid number between {Int32.MinValue} - {Int32.MaxValue} ");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Numerator should be valid number between {Int32.MinValue} - {Int32.MaxValue} ");
            }
            
        }       
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}