/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/06/2023 
 * Filename: ArrayExercises.cs 
 * Description: Write a program that initializes an array with ten random integers and then 
 * prints four lines of output, containing: 
 *      1) Every element at an even index 
 *      2) Every even element 
 *      3) All elements in reverse order 
 *      4) Only the first and last element
*********************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] data; 
        Random random = new Random();

        // initialize variables 
        data = new int[10]; 
        for (int i = 0; i < 10; i++)
        {
            data[i] = random.Next();
        }

        // prints all of the elements at an even index 
        Console.WriteLine("Elements at an even index: "); 
        PrintEvenIndices(data);

        // prints every even element 
        Console.WriteLine("Every even element: ");
        PrintEvenElements(data);

        // prints all elements in reverse order  
        Console.WriteLine("All elements in reverse order: ");
        PrintArrayInReverse(data);

        // prints the first and last element 
        Console.WriteLine("First and last elements: ");
        PrintFirstAndLastElement(data); 

    }

    // prints all of the elements at an even index 
    public static void PrintEvenIndices(int[] data)
    {

        // declare local variables 
        string message;

        // initialize local variables 
        message = string.Empty;

        // appends only the elements at an even index to the message 
        for (int i = 0; i < data.Length; i+=2)
        {
            message += "data[" + i + "]: " + data[i] + ", "; 
        }

        // removes the trailing white space character and comma 
        message = message.Substring(0, message.Length - 2);

        // prints the message 
        Console.WriteLine(message + "\n"); 

    }

    // prints every even element 
    public static void PrintEvenElements(int[] data)
    {

        // declare local variables 
        string message;

        // initialize local variables 
        message = string.Empty;

        // appends only the even elements to the message 
        for (int i = 0; i < data.Length; i++)
        {
            message = (data[i] % 2 == 0) ? message + "data[" + i + "]: " + data[i] + ", " : message; 
        }

        // removes the trailing white space character and comma 
        message = message.Substring(0, message.Length - 2);

        // prints the message 
        Console.WriteLine(message + "\n");

    }

    // prints all elements in reverse order  
    public static void PrintArrayInReverse(int[] data)
    {

        // declare local variables 
        string message;

        // initialize local variables 
        message = string.Empty;

        // appends the elements in reverse order to the message 
        for (int i = data.Length - 1; i >= 0; i--)
        {
            message += "data[" + i + "]: " + data[i] + ", "; 
        }

        // removes the trailing white space character and comma 
        message = message.Substring(0, message.Length - 2);

        // prints the message 
        Console.WriteLine(message + "\n");

    }

    // prints the first and last element 
    public static void PrintFirstAndLastElement(int[] data)
    {
        // prints the message 
        Console.WriteLine("data[0]: " + data[0] + ", data[" + (data.Length - 1) + "]: " + data[data.Length - 1] + "\n");
    }

}
