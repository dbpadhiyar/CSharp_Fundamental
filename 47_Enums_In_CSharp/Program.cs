/*
 * Enum is underline integer by default which value start with 0 
 * 
 * we can change default enum underline datatype
 * 
 * we can customize enum values
 * 
 * if we want to start enum with 1 we can do that by assigning 1 value to our first enum. following enum
 * value will be +1
 * 
 * we also can give random value to enum as well
 * 
 * enum is strongly type constant
 * 
*/


class Program
{
    public static void Main()
    {

        //Return all numeric value of Enum
        int[] valuesInt = (int[])Enum.GetValues(typeof(Gender));
        foreach (int value in valuesInt)
        {
            Console.WriteLine(value);
        }

        //Return all string value of Enum
        string[] valuesString = (string[])Enum.GetNames(typeof(Gender));
        foreach (string value in valuesString)
        {
            Console.WriteLine(value);
        }

        
    }
}

public enum Gender
{
    unknown,
    Male,
    Female
}