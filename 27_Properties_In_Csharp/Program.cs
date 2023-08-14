public class Student
{
    private int _id;
    private string _name;
    private int _mark = 78;
    private string _city;
    private string Email { get; set; } // Auto implement property introduce in c# 3.0

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Id Must be greater than 0");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }        
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("name cannot be null or empty");
            }
            this._name = value;
        }
        get 
        { 
            return string.IsNullOrWhiteSpace(this._name) ? "Undefined" : this._name; 
        }
    }

    public int Mark
    {
        get
        {
            return this._mark;
        }
    }

    public string City
    {
        get
        {
            return this._city;
        }
        set
        {
            this._city = value;
        }
    }
}

class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.Id = 100;


        Console.WriteLine($"Student Id is {student.Id}");
        Console.WriteLine($"Student Name is {student.Name}");
        Console.WriteLine($"Student Mark is {student.Mark}");
    }
}