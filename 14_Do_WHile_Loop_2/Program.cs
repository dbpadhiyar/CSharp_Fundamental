using System;

class Program
{
    public static void Main()
    {
        string UserChoice = string.Empty;
        int TotalAmount = 0;
        Console.WriteLine("Welcome to DP Cafe");
        do
        {            
            do
            {
                Console.WriteLine("What would you like order");
                Console.WriteLine("1. Coffee \n2.Tea \n3.Lemon Tea");
                int UserItem = int.Parse(Console.ReadLine());
                if (UserItem >= 1 && UserItem <= 3)
                {
                    switch (UserItem)
                    {
                        case 1:
                            TotalAmount = TotalAmount + 10;
                            break;
                        case 2:
                            TotalAmount = TotalAmount + 20;
                            break;
                        case 3:
                            TotalAmount = TotalAmount + 30;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invlaid Choice");
                }
                Console.WriteLine("Do you Want to Add More Item");
                UserChoice = Console.ReadLine().ToUpper();
                if (UserChoice == "NO")
                {
                    Console.WriteLine("Thank For Shopping");
                    Console.WriteLine("Total Bill is => {0}", TotalAmount);
                }
            }
            while (UserChoice != "YES" && UserChoice != "NO");
            
        }
        while(UserChoice == "YES");
    }
}