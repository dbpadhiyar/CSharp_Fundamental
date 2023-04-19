/*
 * Datatype Conversion happen on two ways
 * Implicit & Explicit
 * Implicit conversion happen automatically i.e(int to float) because float can hold int value
 * Explicit Conversion not happen automatically because it might lose data so we have to do it i.e(float to int) we might lose some frictional value
*/

namespace _6_Nullable_Type
{
    public class Program
    {
        public static void Main()
        {
            int i = 100;
            float f = i; // will not throw exception even if could not hold value

            int j = Convert.ToInt32(f); // will throw exception if could not hold value

            string stringNumber = "100";
            
            int number = int.Parse(stringNumber);
            Console.WriteLine(number);

            string stringNumber2 = "285TY";
            int number2 = 0;
            int.TryParse(stringNumber2,out number2); //if conversion successfull return numnber assigned in string else default value assigned in out parameter.
            Console.WriteLine(number2);


            string stringNumber3 = "181";
            int number3 = 0;
            bool isConversionSuccess = int.TryParse(stringNumber3,out number3); // store value in out parameter if conversion successfull

            if(isConversionSuccess)
            {
                Console.WriteLine(number3);
            }
            else
            {
                Console.WriteLine("Enter Valid Value");
            }
        }
    }
}