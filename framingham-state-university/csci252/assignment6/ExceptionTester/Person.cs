public class Person : Object
{

    // global variables 
    private string _name;
    private int _age;

    // Person constructor 
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetAge()
    {
        return _age; 
    }

    // overrides the Equals method 
    public override bool Equals(object? o)
    {

        // declare local variables 
        bool result;

        // initialize local variables 
        result = false; 

        // determines if the Object o is Equal to Person p 
        if (o.GetType() == typeof(Person))
        {
            Person p = (Person)o; 
            if ((_name == p.GetName()) && (_age == p.GetAge()))
            {
                result = true;
            }
        }

        // return the result 
        return result;
    }

    public override string ToString()
    {
        return ("Name: " + _name + ", Age: " + _age); 
    }

}
