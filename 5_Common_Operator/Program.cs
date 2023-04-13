using System;

class Program
{
    public static void Main()
    {

        /* 1 => Assignment Operator (=)  */  
        
        
        int a = 80,b = 19,c = 67;        
        string variable = @"int a = 80; int b = 19;";
        Console.WriteLine("{0} \n ",variable);

        /* 2 => Arithmatic Operator (=,+,/,%,*)  */  

        Console.WriteLine("Addition Of A And B Is => {0} ",a + b);
        Console.WriteLine("Subtraction Of A And B Is => {0} ", a - b);
        Console.WriteLine("Multiplication Of A And B Is => {0} ", a * b);
        Console.WriteLine("Divison Of A And B Is => {0} ", a / b);
        Console.WriteLine("Modulo Of A And B Is => {0} \n", a % b);

        /* 3 => Comparision Operator (==,!=,>,>=,<, <=)  */

        Console.WriteLine("Is A Is Equal To Be B => {0} ", a == b);
        Console.WriteLine("Is A Is Not Equal To Be B => {0} ", a != b);
        Console.WriteLine("Is A Is Greater Than B => {0} ", a == b);
        Console.WriteLine("Is A Is Greater Than Or Equal To  B => {0} ", a == b);
        Console.WriteLine("Is A Is Less Than B => {0} ", a == b);
        Console.WriteLine("Is A Is Less Than Or Equal To  B => {0} \n", a == b);

        /* 4 => Conditional Operator (&&,||)  */
        Console.WriteLine("Is A Bigger Than B And C => {0}", a > b && a > c);    
        Console.WriteLine("Is A Or B Bigger Than C => {0} \n", a > c || b > c);    
    
        /* 5 => Ternary Operator (?:)  */
        string isLeapYer = DateTime.IsLeapYear(DateTime.Now.Year) ? "Yes" : "No";
        Console.WriteLine("Is This Year Is Leap Year ? => {0}",isLeapYer);

        /* 6 => null Coalascing Operator (?:)  */
        int max;

        int latestValue = max ?? 10;



    }
}
