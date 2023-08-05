/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/04/2023 
 * Filename: IntCompZero.cs 
 * Description: Carry out Programming Exercise 3.1 of the book. Call your program IntCompZero. 
 * Write a program that reads an integer and prints whether it is negative, zero, or postive. 
********************************************************************************************/
public class Program
{

    // global constants 
    public const string TYPE_NEGATIVE = "negative";
    public const string TYPE_ZERO = "zero";
    public const string TYPE_POSITIVE = "positive";

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string input;

        // initialize variables 
        input = string.Empty;

        // infinite loop  
        while (input != "exit" && input != "stop")
        {

            // get input from the user 
            Console.Write("Please enter an integer type number: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // prints whether a given number is negative, zero, or positive 
            IntCompZero(int.Parse(input));

        }

    }

    // prints whether a given number is negative, zero, or positive 
    public static void IntCompZero(int n)
    {

        // declare local variables 
        string answer;

        // initialize local variables 
        answer = string.Empty; 

        // determines whether the integer is negative, zero, or positive 
        if (n < 0)
        {
            answer = TYPE_NEGATIVE; 
        }
        else if (n == 0)
        {
            answer = TYPE_ZERO; 
        }
        else if (n > 0)
        {
            answer = TYPE_POSITIVE; 
        }

        // prints the answer 
        Console.WriteLine(answer);

    }

}
