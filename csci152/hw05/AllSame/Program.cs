/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/05/2023 
 * Filename: AllSame.cs 
 * Description: Carry out Programming Exercise 3.1 of the book. Call your program IntCompZero. 
 * Write a program that reads an integer and prints whether it is negative, zero, or postive. 
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
            Console.Write("Please enter three (3) numbers sperated by a space: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // prints whether the numbers are all the same, all different, or neither 
            AllSame(input);

        }

    }

    // prints whether the numbers are all the same, all different, or neither 
    public static void AllSame(string input)
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

        // determines whether the numbers are all the same, all different, or neither 
        if (input1 == input2 && input2 == input3)
        {
            answer = "all the same";
        }
        else if (input1 != input2 && input2 != input3 && input1 != input3)
        {
            answer = "all different";
        }
        else
        {
            answer = "neither";
        }

        // print answer 
        Console.WriteLine("Your answer is: " + answer); 

    }

}