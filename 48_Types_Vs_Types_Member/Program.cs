/*
 *  Types vs Type members
 *  
 *  in this example customer is Type and field and properties and method are type members
 *  
 *  so in general classes,struct,enums,interfaces,delegates are called as types 
 * 
 *  fields,properties,constructors,methods,etc that noramlly reside in a type are called as type members
 *  
 *  in c# there are 5 access modifiers
 *  
 *  private,protected,internal,internal protected,public
 *  
 *  Type members can have all the access modifiers, where types can have only (internal,public)
 * 
*/
public class Customer
{
    #region fields    
    public int _id { get; set; }
    public string _firstName { get; set; }
    public string _lastName { get; set; }
    #endregion

    #region Public Property
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string FirstName
    { 
        get { return _firstName; } 
        set { _firstName= value; } 
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName= value; }
    }
    #endregion


    #region Method
    public string GetName()
    {
        return $"{this._firstName} {this._lastName}";
    }

    #endregion
}