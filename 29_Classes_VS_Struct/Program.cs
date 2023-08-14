// Struct VS Classes

// A struct is value type while class is reference type

// Struct stored on stack while classes are stored in heap

// Value types hold their value in memory where they are declared but reference types hold a reference to an object in memory

// value types are destroyed immediately after scope is lost. where as for reference types only the reference variable is
// destroyed after scope is lost. the object is later destoyed by garbase collector

// When you copy a struct into another struct, a new copy of that struct gets created and modifications on one structs
// will not affect another struct

// When you copy a class into another class, we only get a copy of that reference variable. Both the reference variable 
// point to the same object on the heap. so operations on one variable will affect  the values contained by the other
// reference variable

// structs can't have destructor, but class can have

// structs cannot have explicit parameter less constructor where as a class can

// Struct can't inherit from another class where as a class can, both structs and class can inherit from an interface

// Example of structs in .NET is int(System.Int32)

// A class or a struct cannot inherit from another struct. struct are sealed types.

// To stop inherit class we can use sealed keyword before class keyword

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Program
{
    public static void Main()
    {
        int i = 10;
        int j = i;
        j = j + i;

        Console.WriteLine($"Value of i is {i} and j is {j}");
    }
}