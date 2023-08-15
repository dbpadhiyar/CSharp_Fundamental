/*
 * 
 * 
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

        Employee employee = new Employee();
        employee.PromoteEmployee(employees);
    }
}

class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int salary { get; set; }

    public int Experience { get; set; }

    /*
     * Currently we have hard corded Promote employee method based on their experience, if someone has different criteria
     * to promote employee they have to change their class structure
     * 
     * if we want to reuse this class we cannot do that without schanging their structure
     * 
     * but using delegate we can achieve that
     */

    public void PromoteEmployee(List<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            if(employee.Experience >= 5)
            {
                Console.WriteLine($"{employee.Name} is Promoted");
            }
        }
    }

}