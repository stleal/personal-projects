/********************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/15/2023 
 * Filename: ExceptionTester.cs 
 * Description: In this program assignment, you will construct two different exception classes: ClassNotFoundException and ObjectNotFoundException. 
 * 
 * A static method search that takes an array of objects and a target object as arguments and throws two types of exceptions must be defined. 
 * An object of ClassNotFoundException should be thrown if the array doesn’t contain an object which is from the same class as the target; if the array 
 * contains an object which is the same type of the target but an object with same values as the target can’t be found in the array, an object of 
 * ObjectNotFoundException should be generated; otherwise the method should return the index of the first occurrence of the target object. 
 * 
 * For example, let AO be the array in next paragraph, if D is a Double and I is an Integer with a value of 25, 
 *      search(AO, D) will throw a ClassNotFoundException and 
 *      search(AO, I) will throw an ObjectNotFoundException.  
 *      search(AO, “hello”) should return 2.
 *      
 * In your main method, an array of Objects AO should be created, including 6 items:
 *      Class                 Value
 *      Integer                5
 *      Integer                42
 *      String                 “hello”
 *      String                 “there”
 *      Person                “Laura”  40
 *      Person                “Peter”   35
 * 
 * Also in your main method, try to search the following:
 *      Integer      5
 *      Person      “steve”   5
 *      Double      42
 * 
 * Note: Operator instanceof can be used to check if an object is a member of certain class. Or the method getClass can be used to check the class 
 * identity of an object. You should also implement a class Person whose member variables are:
 *      String name;
 *      int age;
 *      
 *  A Person object equals another if and only if the two objects have the same name and age.  
 *  
 *  Please override equals method for user defined classes.
********************************************************************************************************************************************/
public class Program
{

    public static void Main(string[] args)
    {

        // declare local variables 
        int index;
        Person p, p2, p3;
        Object[] objects;

        // initialize local variables 
        index = -1; 
        objects = new Object[6];
        p = new Person("Alice", 22);
        p2 = new Person("Sam", 28);
        p3 = new Person("Sam", 28); 
        objects[0] = 5;
        objects[1] = 42;
        objects[2] = "hello"; 
        objects[3] = "there";
        objects[4] = p; 
        objects[5] = p2;

        // tester 
        index = Search(objects, 5);

        // display / print 
        Console.WriteLine("objects[" + index + "] = " + objects[index].ToString());

        // tester 
        index = Search(objects, "hello");

        // display / print 
        Console.WriteLine("objects[" + index + "] = " + objects[index].ToString());

        // tester 
        index = Search(objects, p3);

        // display / print 
        Console.WriteLine("objects[" + index + "] = " + objects[index].ToString());
        Console.ReadLine(); 

    }

    /***************************************************************************************************************
    * Search(Object[] objects, Object o) 
    * searches the array of Objects 
    * throws a ClassNotFoundException if that type of Object is not found in the array 
    * throws a ObjectNotFoundException if that type of Object is found in the array but not the element/value 
    * returns the element/value if found in the array with a matching type of Object 
    ***************************************************************************************************************/
    public static int Search(Object[] objects, Object o)
    {

        // declare local variables 
        bool found;
        int index; 

        // initialize local variables 
        found = false;
        index = -1; 

        // loop through the array 
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].GetType() == o.GetType())
            {
                found = true; 
                if (objects[i].Equals(o))
                {
                    index = i;
                    break;
                }
            }
        }

        // throw an exception 
        if (!found && index == -1)
        {
            throw new Exception("ClassNotFoundException"); 
        }
        else if (found && index == -1)
        {
            throw new Exception("ObjectNotFoundException");
        }

        // return the object found in the array 
        return index;

    }

}
