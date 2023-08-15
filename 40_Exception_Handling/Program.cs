/*
 * Exception Handling 
 * 
 * An Exception is an unforeseen error that occurs when a program is running
 * 
 * General exception must be at borrom and specialized exception must be at top
 * 
 * Finally block will be executed whether exception is generated or not
 * 
 * and finnaly block is not mandatory
 * 
 * 
 * 
 */


using System.IO;

class Program
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"D:\Ekxtraa\HelloMessage.txt");
            string fileContent = streamReader.ReadToEnd();
            Console.WriteLine(fileContent);            
        }        
        catch (FileNotFoundException fex)
        {
            //Console.WriteLine(ex.Message.ToString());
            Console.WriteLine($"Following file {fex.FileName} not found");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        finally
        {
            if (streamReader != null)
            streamReader.Close();
        }

    }
}