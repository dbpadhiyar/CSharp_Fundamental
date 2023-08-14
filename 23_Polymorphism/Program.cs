//Polymorphism
// polymorphism enable us to invoke derived class method using base class reference variable at run time
// virtual keyword indicate that method can be override in derived class
public class Employee
{
    public string FirstName = "Devendra";
    public string LastName = "Padhiyar";

    public virtual void PrintEmployee()
    {
        Console.WriteLine($"Employee full name is {FirstName} {LastName}");
    }
}


public class FullTimeEmployee : Employee
{
    public override void PrintEmployee()
    {
        Console.WriteLine($"Employee full name is {FirstName} {LastName} - Full Time");
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintEmployee()
    {
        Console.WriteLine($"Employee full name is {FirstName} {LastName} - Part Time");
    }

}

public class TemporaryTimeEmployee : Employee
{
    public override void PrintEmployee()
    {
        Console.WriteLine($"Employee full name is {FirstName} {LastName} - Temporary Time");
    }
}

class Program
{
    public static void Main()
    {
        Employee[] employee = new Employee[4];
        employee[0] = new Employee();
        employee[1] = new FullTimeEmployee();
        employee[2] = new PartTimeEmployee();
        employee[3] = new TemporaryTimeEmployee();

        foreach (Employee e in employee)        
        {
            e.PrintEmployee();
        }
    }
}