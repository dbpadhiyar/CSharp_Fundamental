/*
 * First we need to craete delegate and pass parameter inside it
 * either we can pass function inside delegate or we can use lamda function(which internaly make delegate)
 * 
 * 
 * 
 */


class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { Id = 1, Name = "Devendra", salary = 60000, Experience = 4 });
        employees.Add(new Employee() { Id = 2, Name = "Vinit", salary = 100000, Experience = 2 });
        employees.Add(new Employee() { Id = 3, Name = "Keyur", salary = 120000, Experience = 4 });
        employees.Add(new Employee() { Id = 4, Name = "Avinash", salary = 140000, Experience = 6 });
        employees.Add(new Employee() { Id = 5, Name = "Krish", salary = 2000000, Experience = 2 });


        // creating instance of delegate
        // PromoteEmployeeDelegate promoteEmployeeDelegate = new PromoteEmployeeDelegate(Promote);

        Employee.PromoteEmployee(employees,employee => employee.salary >= 100000);
    }

    //public static bool Promote(Employee emp)
    //{
    //    bool isEligible = emp.salary > 100000 ? true : false;
    //    return isEligible;
    //}
}

delegate bool PromoteEmployeeDelegate(Employee employee);

class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int salary { get; set; }

    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employees, PromoteEmployeeDelegate promoteEmployeeDelegate)
    {
        foreach (Employee employee in employees)
        {
            if (promoteEmployeeDelegate(employee))
            {
                Console.WriteLine($"{employee.Name} is Promoted");
            }
        }
    }

}