// When we inheritad one class to another and both that class has same method at that concept of method over hiding come
// method of child class will be called even parent class has same method
// if we really want to use child class method better to use new keyword before method return type
// if we want to call parent class method use base keyword befor method name

class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintEmployee()
    {        
        Console.WriteLine($"Employee full name is {FirstName} {LastName}");
    }
}

class PartTimeEmployee : Employee
{
    public int HourlySalary { get; set; }
    public new void PrintEmployee()
    {
        //base.PrintEmployee();
        Console.WriteLine($"Employee full name is {FirstName} {LastName} -  Contractor");
    }
}

class FullTimeEmployee : Employee
{
    public int MonthlySalary { get; set; }
    
}

class Program
{
    public static void Main()
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        fullTimeEmployee.Id = 1;
        fullTimeEmployee.FirstName= "Devendra";
        fullTimeEmployee.LastName = "Padhiyar";
        fullTimeEmployee.PrintEmployee();

        PartTimeEmployee partTimeEmployee = new PartTimeEmployee(); //Employee partTimeEmployee = new PartTimeEmployee();
        partTimeEmployee.Id = 2;
        partTimeEmployee.FirstName = "Vinit";
        partTimeEmployee.LastName = "Padhiyar";
        partTimeEmployee.PrintEmployee();
        //((Employee)partTimeEmployee).PrintEmployee(); // TO directly call base class hidden method // Class Cast

    }
}