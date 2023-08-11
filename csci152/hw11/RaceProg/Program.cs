/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/06/2023 
 * Filename: RaceProg.cs 
 * Description: A run is a seqeunce of adjacent repeated values. Write a program that generates a 
 * sequence of 20 random die tosses in an array and that prints the die values, marking the runs by 
 * including them in parentheses, like this: 1 2 (5 5) 3 1 2 4 3 (2 2 2 2) 3 6 (5 5) 6 3 1
*********************************************************************************************/
public class Program
{
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] dieValues; 
        Random random = new Random();

        // initialize local variables 
        dieValues = new int[20]; 

        // prints 10 sequences of 20 random die tosses 
        for (int i = 0; i < 10; i++)
        {
            // generate a sequence of 20 random die tosses 
            for (int j = 0; j < dieValues.Length; j++)
            {
                dieValues[j] = random.Next(0, 10);
            }

            // prints the die values 
            Console.WriteLine(RaceProg(dieValues)); 

            // print a blank line 
            Console.WriteLine(); 
        }

        // keep the application running 
        Console.ReadLine(); 

    }

    // returns a string with the die values 
    public static string RaceProg(int[] dieValues)
    {

        // declare local variables 
        bool inRun;
        string message; 

        // initialize local variables 
        inRun = false;
        message = string.Empty; 

        // loop through the array 
        for (int i = 0; i < dieValues.Length; i++)
        {
            if (inRun)
            {
                if ((i > 0) && (dieValues[i] != dieValues[i-1]))
                {
                    message += ") "; 
                    inRun = false;
                }
            }
            if (!inRun)
            {
                if ((i < dieValues.Length - 1) && (dieValues[i] == dieValues[i+1]))
                {
                    message += "("; 
                    inRun = true; 
                }
            }
            message += (dieValues[i] + " "); 
        }

        // print a final closing parentheses 
        if (inRun)
            message += (")");

        // replace the string " )" with ")" 
        message = message.Replace(" )", ")");

        // returns the message 
        return message; 

    }

}
