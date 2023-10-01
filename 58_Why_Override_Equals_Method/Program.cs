/*
 * What is ToEqual()
 * Why should we override it
 * every type in c# directly or indirectly inherit from system.object
*/

class Program
{
    public static void Main()
    {
        int i = 10;
        int j = 10;

        Console.WriteLine(i == j);
        Console.WriteLine(i.Equals(j));
        Console.WriteLine();

        Direction direction1 = Direction.East;
        Direction direction2 = Direction.East;

        Console.WriteLine(direction1 == direction2); // it's work good with value Type
        Console.WriteLine(direction1.Equals(direction2)); // it's work good with value Type

        Console.WriteLine();
        Customer customer = new Customer();
        customer.FirstName = "Dev";
        customer.LastName = "Padhiyar";

        Customer customer2 = new Customer();
        customer2.FirstName = "Dev";
        customer2.LastName = "Padhiyar";

        // if both instance refering to same object then reference equality will be false -  but value equality will be there
        // refernce equality guaranty value equality but not vice versa
        Console.WriteLine(customer == customer2);  // comparing refernce type
        Console.WriteLine(customer.Equals(customer2)); // comparing value type. if we want to make sure value equality we must need to do override Equals()

    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override bool Equals(object? obj)
        {
            if(obj == null) 
                return false;

            if (!(obj is Customer))
            {
                return false;
            }

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();  
        }
    }
}