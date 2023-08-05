/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/05/2023 
 * Filename: Ordered.cs 
 * Description: Write a program called Ordered that takes three (3) numbers and displays whether 
 * they are in order, or not in order. 
********************************************************************************************/
public class Program
{

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
            Console.Write("Please enter three (3) numbers separated by a space: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // makes change and displays the result 
            Ordered(input); 

        }

    }

    // displays whether the given numbers are in order, or not in order 
    public static void Ordered(string input) 
    {

        // declare local variables 
        string[] numbers = input.Split(" ");
        int input1, input2, input3;
        string answer;

        // initialize local variables 
        input1 = int.Parse(numbers[0]);
        input2 = int.Parse(numbers[1]);
        input3 = int.Parse(numbers[2]);
        answer = string.Empty;

        // determines whether the numbers are in order, or not in order 
        if (input1 < input2 && input2 < input3)
        {
            answer = "in order ascending";
        }
        else if (input1 > input2 && input2 > input3)
        {
            answer = "in order descending";
        }
        else
        {
            answer = "not in order";
        }

        // prints the answer 
        Console.WriteLine("Your answer is: " + answer);

    }

}
