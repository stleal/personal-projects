/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/04/2023 
 * Filename: MoveWord.cs 
 * Description: Create a program called MoveWord, which prompts the user to enter a sentence 
 * on a line, and displays the sentence after moving the first word of the sentence to the end of 
 * the sentence. You can assume that the sentence is more than a single word long and ends with a period.
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
            Console.Write("Please enter a sentence: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // moves a word to the end of the sentance 
            MoveWord(input);

        }

    }

    // moves a word to the end of the sentance 
    public static void MoveWord(string sentance)
    {

        // declare local variables 
        string firstWord;

        // initialize local variables 
        firstWord = sentance.Substring(0, sentance.IndexOf(" ")); 

        // display output 
        Console.WriteLine(sentance.Substring(sentance.IndexOf(" ") + 1, sentance.Length - firstWord.Length - 1) + " " + firstWord); 

    }

}
