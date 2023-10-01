using System.Reflection;

namespace Devendra
{
    public class Program
    {
        public static void Main()
        {
            //Early Binding
            //this is early binding at compile time because we get method and access it at compile time
            //Most of error like spelling issue, parameter passing issue in early binding can be detected at compile time

            Customer customer = new Customer();
            string fullName = customer.GetFullName("Devendra", "Early Binding");
            Console.WriteLine(fullName);

            // Late Binding
            // Performance issue while creating instance
            // slower compare to early binding
            // only use when working with object which are not avilable at compile time
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type customerType = assembly.GetType("Devendra.Customer");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");
            string[] parameters = new string[2];
            parameters[0] = "Devendra";
            parameters[1] = "Late Binding";
            string fullNameLate = (string)getFullNameMethod.Invoke(customerInstance,parameters);
            Console.WriteLine(fullNameLate);
        }
    }

    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
