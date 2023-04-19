//TO store same type of data in one format we have to use Array


namespace _8_Array
{
    public class Program
    {
        public static void Main()
        {
            int[] Collection = new int [3]; // int[] Collection = new int[] { 1,2,3,4}

            Collection[0] = 1;
            Collection[1] = 2;
            Collection[2] = 3;

            foreach(int a in Collection)
            {
                Console.WriteLine(a);
            }

            for(int i = 0; i <Collection.Length; i++)
            {
                Console.WriteLine(Collection[i]);
            }
        }
    }
}