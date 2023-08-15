/*
 * 
 * 
 * 
 * 
 * 
*/


interface IPlay
{
    void PlayStart();
}

class Play : IPlay
{
    public void PlayStart()
    {
        Console.WriteLine("Implemented Start method of IPlay Interface");
    }
}

interface IEat
{
    void EatStart();
}

class Eat : IEat
{
    public void EatStart()
    {
        Console.WriteLine("Implemented Start method of IEat Interface");
    }
}

class Common : IPlay, IEat
{
    Play play = new Play();
    Eat eat = new Eat();

    public void PlayStart()
    {
        play.PlayStart(); // don't need to provide implementation because inherited class already provided implementation
    }

    public void EatStart()
    {
        eat.EatStart();
    }
}

class Program
{
    public static void Main()
    {
            Common common= new Common();
            common.PlayStart();
            common.EatStart();
    }
}