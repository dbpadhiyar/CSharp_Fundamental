namespace _61_Partial_Class
{
    public partial class CustomerOne
    {
        public string GetCustomerInfo()
        {
            string message = string.Empty;
            message = $"Full name od student is {FirstName +" "+LastName} and id is => {Id}";
            return message;
        }
    }
}
