// C# only support single class inheritance
// C# support multi level inheritance 
// Parent class constructor called before child class constructor
// if we have more than one constructor and want to call our choice of constructor we can do it
//  using base keyword
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public void PrintName(string employeeType)
    {
        Console.WriteLine($"Name of {employeeType} employee is {Name}");
    }
}

public class FullTimeEmployee : Employee
{
    public int MonthlySalary { get; set; }
}

public class PartTimeEmployee : Employee
{
    public int HourlySalary { get; set; }
}


public class Program
{
    public static void Main()
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        fullTimeEmployee.Id = 1;
        fullTimeEmployee.Name = "Devendra";
        fullTimeEmployee.Description = "Nothing";
        fullTimeEmployee.MonthlySalary = 200000;
        fullTimeEmployee.PrintName("Full Time");

        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        partTimeEmployee.Id = 1;
        partTimeEmployee.Name = "Sanjay";
        partTimeEmployee.Description = "Nothing";
        partTimeEmployee.HourlySalary = 19;
        partTimeEmployee.PrintName("Part Time");
    }
}