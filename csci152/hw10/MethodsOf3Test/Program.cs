/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/06/2023 
 * Filename: MethodsOf3Test.cs 
 * Description: Write the following methods and provide a program to test them. 
 * double smallest(double x, double y, double z), returning the smallest of the arguments. 
 * double average(double x, double y, double z), returning the average of the arguments. 
********************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string input; 
        string[] numbers;
        double x, y, z; 

        // initialize variables 
        input = string.Empty;

        // infinite loop  
        while (input != "exit" && input != "stop")
        {

            // get input from the user 
            Console.Write("Please enter three (3) numbers separated by a space: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // parse the input 
            numbers = input.Split(" ");
            x = Convert.ToDouble(numbers[0]); 
            y = Convert.ToDouble(numbers[1]); 
            z = Convert.ToDouble(numbers[2]);

            // prints the smallest of the three (3) given numbers  
            Console.WriteLine("The smallest of those three (3) numbers is: " + smallest(x, y, z));

            // prints the average of the three (3) given numbers  
            Console.WriteLine("The average of those three (3) numbers is: " + average(x, y, z));

        }

    }

    public static double? smallest(double x, double y, double z)
    {

        // declare local variables 
        double? smallest;

        // determines which value is the smallest 
        smallest = (x < y && x < z) ? x : null;
        smallest = (y < x && y < z) ? y : smallest;
        smallest = (z < x && z < y) ? z : smallest;
        smallest = (x == y && x < z) ? x : smallest;
        smallest = (y == z && y < x) ? y : smallest;
        smallest = (x == z && x < y) ? z : smallest;

        // returns the smallest of the three (3) numbers 
        return smallest; 

    }

    public static double average(double x, double y, double z)
    {
        return (x + y + z) / 3; 
    }

}
