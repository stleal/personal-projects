/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/06/2023 
 * Filename: CountWords.cs 
 * Description: Write a method that returns a count of all words in the string str. Words are 
 * separated by spaces. For example, countwords("Mary had a little lamb") should return 5. 
*********************************************************************************************/
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
        while (input != "exit" && input != "stop" && input == "")
        {

            // get input from the user 
            Console.Write("Please enter a string of text: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop" || input == "")
                break;

            // displays the number of words in a string   
            Console.WriteLine("The number of words in the given string is: " + CountWords(input)); 

        }

    }

    // returns the number of words in a string 
    public static int CountWords(string str)
    {

        // declare local variables 
        int count;

        // splits the string into an array and returns the count of words 
        count = str.Split(" ").Length;

        // returns the count 
        return count; 

    }

}
