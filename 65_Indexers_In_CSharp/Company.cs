namespace _65_Indexers_In_CSharp
{
    public class Company
    {
        private List<Employee> listEmployee;

        public Company()
        {
            listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { EmployeeId = 1, Name="Devendra",Gender="Male"});
            listEmployee.Add(new Employee() { EmployeeId = 2, Name="Vinit",Gender="Male"});
            listEmployee.Add(new Employee() { EmployeeId = 3, Name="Krish",Gender="Male"});
            listEmployee.Add(new Employee() { EmployeeId = 4, Name="Keyur",Gender="Male"});
            listEmployee.Add(new Employee() { EmployeeId = 5, Name="Avinash",Gender="Male"});
            listEmployee.Add(new Employee() { EmployeeId = 6, Name="Satya",Gender="Male"});
            listEmployee.Add(new Employee() { EmployeeId = 7, Name="Priya",Gender="Female"});
            listEmployee.Add(new Employee() { EmployeeId = 8, Name="Anjali",Gender="Female"});
        }


        public string this[int EmployeeId]
        {
            get 
            { 
                return listEmployee.FirstOrDefault(emp => emp.EmployeeId == EmployeeId).Name;
            }
            set
            {
                listEmployee.FirstOrDefault(emp => emp.EmployeeId == EmployeeId).Name = value;
            }
        }

        public string this[string Gender]
        {
            get
            {
                return listEmployee.Count(emp => emp.Gender == Gender).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployee)
                {
                    if(employee.Gender == Gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}
