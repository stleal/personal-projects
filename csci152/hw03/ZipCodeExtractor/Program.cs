/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 07/29/2023 
 * Filename: ZipCodeExtractor.cs 
 * Description: Write a program called Extract that prompts the user for a 5-digit zip code and 
 * displays the digits of the zip code, one digit to a line. For instance, if the user types in 
 * 01701 (the Framingham State zip code), the program displays (on separate lines) 0, 1, 7, 0, 
 * and 1. Hint: use integer divide and modulo operations.
 ********************************************************************************************/
public class ZipCodeExtractor
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
            Console.Write("Please enter a zip code: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // extract the zip code and print 
            Extract(int.Parse(input)); 

        }

    }

    // extracts the zip code and prints it displays it on separate lines 
    public static void Extract(int zipCode)
    {

        int digit = zipCode / 10000;
        Console.WriteLine(digit);

        digit = zipCode / 1000;
        digit %= 10;
        Console.WriteLine(digit);

        digit = zipCode / 100;
        digit %= 10;
        Console.WriteLine(digit);

        digit = zipCode / 10;
        digit %= 10;
        Console.WriteLine(digit);

        digit = zipCode % 10;
        Console.WriteLine(digit);

    }

}
