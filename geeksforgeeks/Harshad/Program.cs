/***********************************************************************************
 * Name: Sam Leal 
 * Date: 07/29/2023 
 * Filename: Harshad.cs 
 * Description: A harshad number (or Niven number), is an integer that is divisible 
 * by the sum of its digits.
 **********************************************************************************/
public class Harshad
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
            Console.Write("Please enter a number: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // check whether the number is Moran or not 
            Console.WriteLine("Number " + input + " is Harshad: " + IsHarshad(int.Parse(input)));

        }

    }

    // returns whether a given number is Harshad or not 
    public static bool IsHarshad(int n)
    {
        return (n % SumOfDigits(n) == 0) ? true : false;
    }

    // returns the sum of the digits in any given number 
    public static int SumOfDigits(int n)
    {

        // declare variables 
        int answer;

        // initialize variables 
        answer = 0;

        // adds each digit to the sum of digits 
        while (n >= 1)
        {
            answer += (n % 10);
            n /= 10;
        }

        // returns the sum of the digits of n
        return answer;

    }

}
