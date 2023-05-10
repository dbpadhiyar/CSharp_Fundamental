using System;

class Program
{
    public static void Main(string[] args)
    {
        string WantToContinue = String.Empty;
        do
        {
            int TargetValue = 0;
            Console.WriteLine("Please enter your target");
            TargetValue = int.Parse(Console.ReadLine());

            int CurrentValue = 1;

            while (CurrentValue <= TargetValue)
            {
                Console.WriteLine("Current Value Is => {0}", CurrentValue);
                CurrentValue++;
            }

            WantToContinue = String.Empty;
            do
            {
                Console.WriteLine("Do You Want Continue YES or NO");
                WantToContinue = Console.ReadLine().ToUpper();
                if (WantToContinue != "YES" && WantToContinue != "NO")
                    Console.WriteLine("Invalid Choice");
                else if (WantToContinue == "NO")
                    Console.WriteLine("Thanks");
            }
            while (WantToContinue != "YES" && WantToContinue != "NO");
        }
        while (WantToContinue == "YES");

    }
}