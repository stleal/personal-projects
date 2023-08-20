/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/05/2023 
 * Filename: JustLoops.cs 
 * Description: Carry out Programming Exercise P4.1 on page 188 of the book. However, instead of 
 * writing your solution as 5 separate programs, write it as a single program that carries out the 
 * five parts of this exercise one by one. Call your program JustLoops. 
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

            // displays the sum of all even numbers between 2 and 100 (inclusive) 
            SumOfAllEvenNumbers(2, 100);

            // displays the sum of all squares between 1 and 100 (inclusive) 
            SumOfAllSquares(1, 100); 

            // displays all powers of 2 from 2^0 up to 2^20 
            PowersOfTwo(0, 20);

            // get input from the user 
            Console.WriteLine("Computes the sum of all odd numbers between a and b (inclusive)."); 
            Console.Write("Please enter a starting and ending value separated by a space: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // computes the sum of all odd numbers between a and b (inclusive) 
            SumOfAllOddNumbers(input);

            // get input from the user 
            Console.WriteLine("Computes the sum of all odd digits of an input. ");
            Console.Write("Please enter an integer: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // displays the sum of all odd digits of an input 
            SumOfAllOddDigits(input);

            // hold the application 
            Console.ReadLine(); 

        }

    }

    // displays the sum of all even numbers between 2 and 100 (inclusive) 
    public static void SumOfAllEvenNumbers(int start, int end)
    {

        // declare local variables 
        int sum;

        // initialize local variables 
        sum = 0; 

        // computes the sum of all even numbers between start and end (inclusive) 
        for (int i = start; i <= end; i++)
        {
            sum = (i % 2 == 0) ? sum + i : sum; 
        } 

        // displays the answer 
        Console.WriteLine("The sum of all even numbers between " + start + " and " + end + ": " + sum);

    }

    // displays the sum of all squares between 1 and 100 (inclusive) 
    public static void SumOfAllSquares(int start, int end)
    {

        // declare local variables 
        int sum, i; 

        // initialize local variables 
        sum = 0; i = start;

        // computes the sum of all squares between start and end 
        while((i * i) <= end)
        {
            sum += (i * i);
            i++; 
        }

        // displays the answer 
        Console.WriteLine("The sum of all squares between " + start + " and " + end + ": " + sum + "\n"); 

    }

    // displays all powers of 2 from 2^0 up to 2^20 
    public static void PowersOfTwo(int start, int end)
    {

        // displays a message 
        Console.WriteLine("All powers of two from 2^" + start + " up to 2^" + end + ": ");

        // computes the powers of 2 from 2^start up to 2^end 
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine("2^" + i + " = " + Math.Pow(2, i)); 
        }

        // prints a blank line 
        Console.WriteLine(); 

    }

    // computes the sum of all odd numbers between a and b (inclusive) 
    public static void SumOfAllOddNumbers(string input)
    {

        // declare local variables 
        int sum, start, end;
        string[] args; 

        // initialize local variables 
        sum = 0;
        args = input.Split(" ");
        start = int.Parse(args[0]);
        end = int.Parse(args[1]);

        // computes the sum of all odd numbers between start and end (inclusive) 
        for (int i = start; i <= end; i++)
        {
            sum = (i % 2 == 1) ? sum + i : sum;
        }

        // displays the answer 
        Console.WriteLine("The sum of all odd numbers between " + start + " and " + end + ": " + sum);

        // prints a blank line 
        Console.WriteLine(); 

    }

    // displays the sum of all odd digits of an input 
    // for example, if the input is 32677, the sum would be 3 + 7 + 7 = 17
    public static void SumOfAllOddDigits(string input)
    {

        // declare local variables 
        int sum, n, i; 

        // initialize local variables 
        sum = 0; 
        n = int.Parse(input);
        i = n; 

        // adds each odd digit to the sum 
        while (n > 0)
        {
            i %= 10;
            sum = (i % 2 == 1) ? sum + i : sum;
            n /= 10;
            i = n; 
        }

        // prints the sum 
        Console.WriteLine("The sum of all odd digits in " + input + " = " + sum); 

    }

}
