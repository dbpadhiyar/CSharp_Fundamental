using System;

class Circle
{
    static float _PI ; //will be only one copy of _PI no matter how much instance is create
    int _radius ;

    static Circle()
    {
        _PI = 3.14f; //this keyword doesn't work with static keyword, Method, Initializer
        Console.WriteLine("Static Constructor Called!");
    }

    public Circle(int radius)
    {
        Console.WriteLine("Instance Constructor Called!");
        this._radius = radius;
    }

    public float CalculatedArea()
    {
        return _PI * this._radius * this._radius;
    }

}

class Program
{
    public static void Main()
    {
        Circle c1 = new Circle(5);
        Console.WriteLine("Circle of 5 is => {0}",c1.CalculatedArea());

        Circle c2 = new Circle(6);
        Console.WriteLine("Circle of 6 is => {0}", c2.CalculatedArea());
    }
}