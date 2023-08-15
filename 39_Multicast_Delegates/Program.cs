/*
 * Multicast delegate is a delegate that has references to more than one function. when you invoke a multicasrt delegate,
 * all the functions the delegate is pointing to,are invokded 
 * 
 * delegate point to more than one function is called multicast delegate
 * 
 * it will be invoked in same way as it registered
 * 
 * to register delegate in multicast delegate we use += and -= for remove delegate
 * 
 * if delegate return type is not void and it's a multicast delegate only the value of last invoked method
 * will be returned.
 * 
 * if th delegate has an out parameter, the value of the output parameter, will be assigned by the last method
 * 
 * Multicast delegate makes implementation of observer design pattern very simple. Observer pattern is also called
 * as publish/subsciber pattern
 * 
 */

/*Delegate for void return type*/
//public delegate void SampleDelegateVoid();

/*Delegate for int return type*/
//public delegate int SampleDelegateInt();

/*Delegate for out int parameter  return type*/
public delegate void SampleDelegateOutInt(out int number);


class Program
{
    public static void Main()
    {
        /*First Way to invoke multicast delegate
         * 
          SampleDelegate sampleDelegate1, sampleDelegate2, sampleDelegate3, sampleDelegate4;
          sampleDelegate1 = new SampleDelegate(SampleDelegateFunctionOne);
          sampleDelegate2 = new SampleDelegate(SampleDelegateFunctionTwo);
          sampleDelegate3 = new SampleDelegate(SampleDelegateFunctionThree);

          sampleDelegate4 = sampleDelegate1 + sampleDelegate2 + sampleDelegate3;
          sampleDelegate4();
        */

        /*Second way to invoke multicast delegate (when type is void)*/

        //SampleDelegateVoid sampleDelegateVoid = new SampleDelegateVoid(SampleDelegateFunctionOne);
        //sampleDelegateVoid += SampleDelegateFunctionTwo;
        //sampleDelegateVoid += SampleDelegateFunctionThree;
        //sampleDelegateVoid();

        /*Third way to invoke multicast delegate (when type is not void)*/

        //SampleDelegateInt sampleDelegateint = new SampleDelegateInt(SampleDelegateFunctionOneInt);
        //sampleDelegateint += SampleDelegateFunctionTwoInt;
        //sampleDelegateint += SampleDelegateFunctionThreeInt;
        //int result = sampleDelegateint();

        //Console.WriteLine(result);

        SampleDelegateOutInt sampleDelegateOutInt = new SampleDelegateOutInt(SampleDelegateFunctionOneOut);
        sampleDelegateOutInt += SampleDelegateFunctionTwoOut;
        sampleDelegateOutInt += SampleDelegateFunctionThreeOut;

        int DelegateOutParameter = -1;

        sampleDelegateOutInt(out DelegateOutParameter);
        Console.WriteLine($"Delegate Return Value = {DelegateOutParameter}");

    }
    /* void Multicast Delegate */

    //public static void SampleDelegateFunctionOne()
    //{
    //    Console.WriteLine("Sample method one invoked");
    //}

    //public static void SampleDelegateFunctionTwo()
    //{
    //    Console.WriteLine("Sample method Two invoked");
    //}

    //public static void SampleDelegateFunctionThree()
    //{
    //    Console.WriteLine("Sample method Three invoked");
    //}


    /* int Multicast Delegate */

    //public static void SampleDelegateFunctionOneInt()
    //{
    //    return 1;
    //}

    //public static int SampleDelegateFunctionTwoInt()
    //{
    //    return 2;
    //}

    //public static int SampleDelegateFunctionThreeInt()
    //{
    //    return 3;
    //}

    /* out int Multicast Delegate */
    public static void SampleDelegateFunctionOneOut(out int number)
    {
        number = 10;
    }

    public static void SampleDelegateFunctionTwoOut(out int number)
    {
        number = 20;
    }

    public static void SampleDelegateFunctionThreeOut(out int number)
    {
        number  = 30;
    }




}
