/*
 * In C# There are two types of values 1 Value Type & 2 Reference Type 
 * Value type default value is some what 0
 * and reference type default value id null
 * to make value type null we have to add ? after data type
*/

namespace _6_Nullable_Type
{
    public class Program
    {
        public static void Main()
        {
            bool? AreYouWinner = null;

            if (AreYouWinner == true)
            {
                Console.WriteLine("You Are Winner");
            }
            else if (AreYouWinner == false)
            {
                Console.WriteLine("You Are Looser");
            }
            else
            {
                Console.WriteLine("Keep Working Hard, Have Faith");
            }

            int? TicketOnSale = null;

            int AvailableTicket = TicketOnSale ?? 1;

            Console.WriteLine("Available Ticket Is => {0}",AvailableTicket);
        }
    }
}