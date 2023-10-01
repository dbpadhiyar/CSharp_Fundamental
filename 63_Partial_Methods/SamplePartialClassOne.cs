namespace _63_Partial_Methods
{
    public partial class SamplePartialClass
    {
        partial void PartialMethod();

        public void PublicMethod()
        {
            Console.WriteLine("Public method called");
            PartialMethod();
        }
    }
}
