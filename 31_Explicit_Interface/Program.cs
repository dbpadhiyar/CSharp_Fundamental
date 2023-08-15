/* When we try to implement explicit interface member,interface member can no longer be accessed through class reference
 variable,but only through interface reference variable */

/* Access modifiers are not allowed on explicitely implemented interface members.
 */

interface IPlay
{
    void Start();
}

interface IEat
{
    void Start();
}

class Program : IPlay, IEat
{
    public static void Main()
    {
        Program program= new Program(); // this is type cast
        program.Start(); // using default interface
        ((IEat)program).Start();

        IPlay play = new Program();
        IEat eat = new Program();
        play.Start();
        eat.Start();
    }

    public void Start() 
    {
        Console.WriteLine("Start method of IPlay Interface");
    }

    void IEat.Start() // not allowed use access modifier in explicit interface implementations
    {
        Console.WriteLine("Start method of IEat Interface");
    }
}