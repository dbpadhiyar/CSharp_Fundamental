using System;

class Program
{
    public static void Main(string[] args)
    {       
        Console.WriteLine("Enter Day Of Week");
        int DayOfWeek = int.Parse(Console.ReadLine());                


        switch (DayOfWeek)
        {
            case 1:
                Console.WriteLine("It's Monday");
            break;
            case 2:
                Console.WriteLine("It's Tuesday");
                break;
            case 3:
                Console.WriteLine("It's Wednesday");
                break;
            case 4:
                Console.WriteLine("It's Thursday");
                break;
            case 5:
                Console.WriteLine("It's Friday");
                break;
            case 6:
                Console.WriteLine("It's Saturday");
                break;
            case 7:
                Console.WriteLine("It's Sunday");
                break;
            default:
                Console.WriteLine("It's Not Allowed");
            break;

        }

        Console.WriteLine("Enter Day of Week In Words");
        string DayOfWeekString = Console.ReadLine();

        switch(DayOfWeekString.ToUpper())
        {
            case "MONDAY":
            case "TUESDAY":
            case "WEDNESDAY":
            case "THURSDAY":
            case "FRIDAY":
                Console.WriteLine("It's Week Day FFS");
                break;
            case "SATURDAY":
            case "SUNDAY":
                Console.WriteLine("It's Weekend Thank God");
                break;
            default: Console.WriteLine("What The Hack!!!!");
                break;
        }
    }
}