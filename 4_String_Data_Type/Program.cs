using System;

class Program
{
    public static void Main()
    {
        /* in c# is escape sequence character is \(BackSlash) */

        string DefaultName = "Get Value As Double Quated Mark \"Devendra\""; //Escape Sequence TO Add Double Quatation Mark is \" (Backslash and DOuble Coma)
        Console.WriteLine($"{DefaultName} \n");

        string MulitpleValues = "\\One\n\\Two\n\\Three"; //Escape Sequence To Use Backslash is \\(Double Backslash) 

        string Path = @"D:\\Tutorial\\3_MSFT_Stack\\1 C# Kudvenkat"; //Verbatim Literal (@) //make escape sequence character as normal readable character
        Console.WriteLine($"Video is available at => {Path}");
    }
}
