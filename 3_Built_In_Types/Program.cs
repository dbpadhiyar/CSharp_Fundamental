using System;

class Program
{
    public static void Main()
    {
        /*
             boolean hod either true or false
        */
        bool AreYouFootballer = false;
        Console.WriteLine("{0}",AreYouFootballer.ToString());
        /*
            -------------------------------------- Integral DataType --------------------------------------
            sbyte  => -128 to 127                                                   (1 Byte) (2^08  *1 - 1)
            byte   =>  0 to 255                                                     (1 Byte) (2^08  *1 - 1)
            char   =>  U+0000 to U+ffff                                             (2 Byte) (2^16  *1 - 1)
            short  => -32768 to 32767                                               (2 Byte) (2^16  *1 - 1)
            ushort =>  0 to 65535                                                   (2 Byte) (2^16  *1 - 1)
            int    => -2,147,483,648 to 2,147,483,647                               (4 Byte) (2^32  *1 - 1)
            uint   =>  4,294,967,295                                                (4 Byte) (2^32  *1 - 1)
            long   => -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807       (8 Byte) (2^64  *1 - 1)
            ulong  =>  0 to 18,446,774,073,709,551,615                              (8 Byte) (2^64  *1 - 1)
    */

        byte a;
        Console.WriteLine("Enter Your Age");
        a = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Your Age Is {0}", a);

     /*
            -------------------------------------- Floating DataType --------------------------------------
            float     => (4 Byte) (2^32  *1 - 1) (7 Precesion)
            diuble   =>  (8 Byte) (2^08  *1 - 1) (15 - 16 Precesion)
    */

    /*
        -------------------------------------- Floating DataType --------------------------------------
        decimal     => (8 Byte) (2^64  *1 - 1) (28-29 Precesion)
    */


    }
}
