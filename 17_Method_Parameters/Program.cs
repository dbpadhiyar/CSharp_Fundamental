using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n--------------------------- Pass By Value ----------------------------------------------");
        int i = 0;
        Console.WriteLine("Current Value Of I is => {0}",i);
        PassByValue(i);
        Console.WriteLine("After Passing value in PassByValue Method Value of i is => {0}", i);

        Console.WriteLine("\n--------------------------- Pass By Reference ------------------------------------------");

        int k = 0;
        Console.WriteLine("Current Value Of K is => {0}", k);
        PassByReference(ref k);
        Console.WriteLine("After Passing value in PassByReference Method Value of k is => {0}", k);

        Console.WriteLine("\n--------------------------- Pass By Out Keyword -----------------------------------------");

        int Total = 0;
        int Product = 0;
        PassByOutKeyword(10, 20, out Total, out Product);
        Console.WriteLine("Sum Of I And J is {0} And Multiplication is {1}", Total, Product);

        Console.WriteLine("\n--------------------------- Pass By Params Keyword -----------------------------------------");

        int[] Marks = new int[5];
        Marks[0] = 11;
        Marks[1] = 12;
        Marks[2] = 13;
        Marks[3] = 14;
        Marks[4] = 15;
        PassByParameterArray(10, 20,Marks); // we can pass as comma if we use parameter array
    }

    public static void PassByValue(int j)   //Value Parameter  //Pass by value // it's not necessary to assign value in ref
    {
        j = 101;
        Console.WriteLine("Value of j inside PassByValue Method  is => {0}", j);
    }

    public static void PassByReference(ref int j) //Value Parameter  //Pass by Reference using ref Keyword  
    {
        j = 101;
        Console.WriteLine("Value of j inside PassByReference Method  is => {0}", j);
    }

    public static void PassByOutKeyword(int i,int j, out int Total, out int Product) //When we want to return more than one value // must assign value when use out
    {
        Total = i + j;
        Product = i * j;
    }

    public static void PassByParameterArray(int i, int j, params int[] numbers) //When We Need to have array as optional parameter  we use params keyword & it's Last in Sequence & Only once in Methos
    {
        int Total = i + j;
        
        if(numbers.Length > 0)
        {
            for(int k = 0; k<numbers.Length;k++)
            {
                Total += numbers[k];
            }
        }
        Console.WriteLine("Total Of All Parameters is {0}", Total);
    }



}