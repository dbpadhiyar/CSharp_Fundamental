/*
 * String  => immutable (it cannot change)
 *         => when we modify string everytime it will refer new string object (means we cannot change string object which already in memory)
 *         => so old object still remain in memory and new object use extra space in memory
 *         => means over reference variable will no longer pointing at old object
 *         => until garbase collector run all the old object(orphan object(which means no longer referencing to it)) stay in memory
 *         => system (namespace)
 * 
 * stringBuilder 
 *         => mutable
 *         => in string builder same object will be used every time
 *         => system.text (namespace)
 */

using System.Text;

class Program
{
    public static void Main()
    {
        string message = "Hello";
        message += " Everyone";
        message += " My name";
        message += " is";
        message += " Devendra";
        Console.WriteLine(message);

        StringBuilder stringBuilder = new StringBuilder("Hello");
        stringBuilder.Append(" Everyone");
        stringBuilder.Append(" My Name");
        stringBuilder.Append(" is");
        stringBuilder.Append(" Devendra");
        Console.WriteLine(stringBuilder.ToString());
    }
}