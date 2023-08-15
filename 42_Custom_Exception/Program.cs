/*
 * Custom Exception 
 * 
 * if we want our exception work across domain we have to mark as serializable
 * 
 * 
 * 
 * 
*/


using System.Runtime.Serialization;


public class CustomExceptionDemo
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User already logged in!");
        }
        catch (UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {

    }
    public UserAlreadyLoggedInException(string Message) : base(Message)
    {

    }

    public UserAlreadyLoggedInException(string Message, Exception InnerException) : base(Message, InnerException) 
    {

    }

    public UserAlreadyLoggedInException(SerializationInfo serializationinfo, StreamingContext streamingContext) : base(serializationinfo, streamingContext)
    {

    }
}

