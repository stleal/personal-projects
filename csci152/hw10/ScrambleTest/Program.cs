/**********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/06/2023 
 * Filename: ScrambleTest.cs 
 * Description: Write a method string Scramble(string word) that constructs a scrambled version 
 * of a given word, randomly flipping two characters other than the first and last one. Then write 
 * a program that reads words and prints the scrambled words. 
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
        while (input != "exit" && input != "stop")
        {

            // get input from the user 
            Console.Write("Please enter a word or a string of text: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop" || input == "")
                break;

            // prints the Scrambled version of the word or string of text 
            Console.WriteLine("Scrambled: " + Scramble(input));

        }

    }

    // returns the number of words in a string 
    public static string Scramble(string str)
    {

        // declare local variables 
        string[] words; 
        string scrambledStr, word; 
        Random rand = new Random(); 
        int firstRandomNumber, secondRandomNumber;
        int smallerIndex, largerIndex; 

        // initialize variables 
        words = str.Split(" ");
        scrambledStr = string.Empty;

        // scrambles the string word by word 
        for (int i = 0; i < words.Length; i++)
        {
            // reset the second random number 
            secondRandomNumber = -1;

            // only if the length is greater than 3 
            if (words[i].Length > 3)
            {
                // append the first character  
                scrambledStr += words[i].ElementAt(0);

                // generate two random numbers other than the first and last index of the word 
                firstRandomNumber = rand.Next(1, words[i].Length - 1);
                while (secondRandomNumber == firstRandomNumber || secondRandomNumber == -1)
                {
                    secondRandomNumber = rand.Next(1, words[i].Length - 1);
                }

                // gets the smaller index of the two random numbers 
                smallerIndex = (firstRandomNumber > secondRandomNumber) ? secondRandomNumber : firstRandomNumber;
                largerIndex = (firstRandomNumber > secondRandomNumber) ? firstRandomNumber : secondRandomNumber;

                // appends the remaining characters 
                for (int j = 1; j < smallerIndex; j++)
                {
                    scrambledStr += words[i].ElementAt(j); 
                }
                scrambledStr += words[i].ElementAt(largerIndex); 

                // appends the remaining characters 
                for (int j = smallerIndex+1; j < largerIndex; j++)
                {
                    scrambledStr += words[i].ElementAt(j); 
                }
                scrambledStr += words[i].ElementAt(smallerIndex);

                // appends the remaining characters 
                for (int j = largerIndex+1; j < words[i].Length; j++)
                {
                    scrambledStr += words[i].ElementAt(j); 
                }

                // appends a blank space after the word 
                scrambledStr += " "; 
            }
            else
            {
                // the length of the word is less than 3, 
                // so, append that word without scrambling 
                scrambledStr += words[i] + " "; 
            }
        }

        // returns the scrambled version of the string 
        return scrambledStr; 

    }

}
