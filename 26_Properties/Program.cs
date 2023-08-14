// This program so what procedure we have to do if we don't use property
public class Student
{
    private int _id;
    private string _name;
    private int _number = 78;

    public void SetID(int id)
    {
        if(id <= 0)
        {
            throw new Exception("Student Id must be greater than 0");
        }
        this._id = id;
    }

    public int GetID()
    {
        return this._id;
    }

    public void SetName(string name) 
    {
        if(string.IsNullOrWhiteSpace(name)) 
        {
            throw new Exception("Student name cannot be null or empty");
        }
        this._name = name;
    }
    public string GetName()
    {       
         return  string.IsNullOrWhiteSpace(this._name) ? "Undefined" : this._name;
    }

    public int GetNumber()
    {
        return this._number;
    }

}

public class Program
{
    public static void Main()
    {
        Student s = new Student();
        s.SetID(55);
        s.SetName("Devendra");


        string message = $"{s.GetName()} ID's is {s.GetID()} and he got {s.GetNumber()} Marks";
        Console.WriteLine(message);
    }
}