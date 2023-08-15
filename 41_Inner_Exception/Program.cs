/*   Inner Exception
 * 
 *  the inner exception property return the exception instance which caused the current exception
 *  
 *  make sure we pass exception in constructor so we can use innerexception object else we will get null reference exception
 *  
 *  before using innerexception make sure is not empty
 * 
 * 
*/

class Program
{
    public static void Main()
    {
        try
        {
            try
            {
                Console.WriteLine("Enter your 1st number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your 2nd number");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = a / b;

                Console.WriteLine($"Result is =>  {result}");
            }
            catch (Exception ex)
            {
                string filePath = @"D:\Extraa\log.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter streamWriter = new StreamWriter(filePath);
                    streamWriter.Write($"{ex.GetType().Name} exception occured at - {DateTime.Now} ");
                    streamWriter.WriteLine();
                    streamWriter.Close();
                    Console.WriteLine("Try after sometime");
                }
                else
                {
                    throw new FileNotFoundException($"{filePath} not found", ex);
                }
            }
        }        
        catch (Exception ex)
        {
            Console.WriteLine($"Current Exception - {ex.GetType().Name}");
            if(ex.InnerException != null)
                Console.WriteLine($" Inner Exception {ex.InnerException.GetType().Name}");
        }
    }
}