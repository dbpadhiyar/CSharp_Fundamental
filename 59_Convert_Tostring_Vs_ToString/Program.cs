/*
 * Convert.Tostring handle null and return empty string,
 * ToString() doesn't handle null and throw null reference exception
 * 
 * 
*/


class Program
{
    public static void Main()
    {
        Customer customer = null;
        string str = Convert.ToString(customer);
        //string str = customer.ToString(); // WIll throw an error (System.NullReferenceException)
        Console.WriteLine($"  =>{str}<="); // WIll handle null
    }

}

class Customer
{
    public string Name { get; set; }
}