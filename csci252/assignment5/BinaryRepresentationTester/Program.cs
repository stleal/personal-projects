/********************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/14/2023 
 * Filename: BinaryRepresentationTester.cs 
 * Description: In this assignment, you will write a program to print the binary representation of a positive integer inserted from command line. 
 * You must finish your assignment in 2 different ways: 
 *   Using a recursive method
 *   Using an iterative method 
********************************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string binaryRepresentation; 

        // prints the Binary Representation of the first 100 numbers
        for (int i = 0; i < 101; i++)
        {

            // get the Binary Representation of the number 
            binaryRepresentation = BinaryRepresentation(i);

            // print the answer 
            Console.WriteLine("The binary representation of " + i + " is (using iteration): " + binaryRepresentation);

        }

    }

    // gets the Binary Representation of the integer n 
    public static string BinaryRepresentation(int n)
    {

        // declare local variables 
        string answer;
        int numberOfBits, sum, power;

        // initialize local variables 
        sum = 0;
        answer = string.Empty;
        numberOfBits = (n > 0) ? (int)Math.Log2(n) : 0; 

        // converts the integer n into its Binary Representation 
        for (int i = numberOfBits; i >= 0; i--)
        {
            power = (int)Math.Pow(2, i); 
            answer += ((sum + power) <= n) ? "1" : "0";
            sum += ((sum + power) <= n) ? power : 0;
        }

        // returns the answer 
        return answer; 

    }

} 
