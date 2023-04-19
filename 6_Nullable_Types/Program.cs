namespace _6_Nullable_Types
{
    public class Program
    {
        public static void main()
        {
            bool? AreYouWinner = null;

            if (AreYouWinner == true)
            {
                Console.WriteLine("You Are Winner");
            }
            else if(AreYouWinner == false)
            {
                Console.WriteLine("You Are Looser");
            }
            else
            {
                Console.WriteLine("Keep Working Hard, Have Faith");
            }
        }
    }
}