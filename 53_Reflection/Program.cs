/*
 * Reflection 
 * 
 * Reflection is the ability of inspectiong an assemblies metadata at runtime. it is used to find all types in an assembly and/or dynamically
 * invoke method in assembly
 * 
 * Uses of Reflection
 * 
 * When you drag and drop button on a win forms or asp.net application. the property window uses reflection to show all the properties of button class
 * .so reflectin is extensively used by IDE or a UI designers
 * 
 * Late binding can be achieved by using reflection. you can use reflection to dynamically create instance of type, 
 * about which we don't have any information at compile time
 * 
 * Consider an example where we have two alternate implementations of an interface. you want to allow user to pick one or other using a config file
 * with reflection you can simpli read the name of the class whose implementation you wanrt to use from config file, and instaniate an instance of the 
 * class.This is another example of late binding
 * 
 * 
 * 
 * 
 * 
*/

using System.Reflection;

namespace Devendra
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-------- Name Print Start ---------------- ");
            //Type type = Type.GetType("Devendra.Customer");
            Customer customer = new Customer();
            Type type = customer.GetType();
            Console.WriteLine($"Full Name - {type.FullName}");
            Console.WriteLine($"Just Name - {type.Name}");
            Console.WriteLine($"Namespace Name - {type.Namespace}");
            Console.WriteLine("-------- Name Print End ----------------\n ");

            Console.WriteLine("-------- Properties Start ---------------- ");
            PropertyInfo[] propertyInfo = type.GetProperties();
            foreach (PropertyInfo property in propertyInfo)
            {
                Console.WriteLine($"{property.Name} - {property.PropertyType}");
            }
            Console.WriteLine("-------- Properties End ----------------\n ");

            Console.WriteLine("-------- Method Start ---------------- ");
            MethodInfo[] methodInfo = type.GetMethods();
            foreach (var method in methodInfo)
            {
                Console.WriteLine($"{method.Name} - {method.ReturnType}");
                ParameterInfo[] parameterInfos = method.GetParameters();
            }
            Console.WriteLine("-------- Method End ----------------\n ");


            Console.WriteLine("-------- Constructor Start ---------------- ");
            ConstructorInfo[] constructorInfo= type.GetConstructors();
            foreach (var constructor in constructorInfo)
            {
                Console.WriteLine($"{constructor.ToString()} - Is static ? - {constructor.IsStatic}");
            }
            Console.WriteLine("-------- Constructor End ----------------\n ");
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = "Down Town";
        }

        public void PrintId()
        {
            Console.WriteLine($"Id of user is {this.Id}");
        }

        public void PrintName()
        {
            Console.WriteLine($"Name of user is {this.Name}");
        }
    }
}