/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/05/2023 
 * Filename: ReverseWord.cs 
 * Description: Write a program that reads a word and prints the word in reverse. For example, 
 * if the user provides the input "Sam", the program prints: maS
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
            Console.Write("Please enter a word to be reversed: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // prints whether the numbers are all the same, all different, or neither 
            ReverseWord(input);

        }

    }

    // reverses a word 
    public static void ReverseWord(string word)
    {

        // declare local variables 
        string wordReversed;

        // initialize local variables 
        wordReversed = string.Empty; 

        // reverses the word 
        for (int i = word.Length - 1; i >= 0; i--)
        {
            wordReversed += word.ElementAt(i); 
        }

        // prints the reversed word 
        Console.WriteLine(wordReversed);

    }

}
