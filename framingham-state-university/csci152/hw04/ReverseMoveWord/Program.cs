/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/04/2023 
 * Filename: ReverseMoveWord.cs 
 * Description: This exercise is exactly the same as exercise 8 except that the program you create 
 * called ReverseMoveWord and it moves the last word of a sentence to the beginning of the sentence. 
 * Hint: it will probably save time to start with the MoveWord program; also, notice there’s a lastIndexOf() 
 * method supplied with the String. 
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

            // moves a word from the end of a sentance to the front 
            ReverseMoveWord(input);

        }

    }

    // moves a word from the end of a sentance to the front 
    public static void ReverseMoveWord(string sentance)
    {

        // declare local variables 
        string lastWord;

        // initialize local variables 
        lastWord = sentance.Substring(sentance.LastIndexOf(" ") + 1, (sentance.Length - sentance.LastIndexOf(" ")) - 1);

        // display output 
        Console.WriteLine(lastWord + " " + sentance.Substring(0, sentance.LastIndexOf(" ")));

    }

}
