/*****************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 11/04/2013  
 * Filename: Program.cs 
 * Description: Binary representation is a number system that uses only two digits, 0 and 1, to 
 * represent all its values.
 *
 * Class: CSCI 252 
 * Semester: Fall 2013 
 * Assignment #5: In this assignment, you will write a program to print the binary representation of a positive 
 * integer inserted from command line.
 * Due: 12:30pm, 11/04/2013 
 * Professor: Zhenguang Gao 
 *
 * You must finish your assignment in 2 different ways: 
 *   Using a recursive method
 *   Using an iterative method 
 *
 * Program.cs: 
 *
 * This class provides two main functionalities: 
 *
 *   1. Number to Binary Conversion: It takes a decimal number as input and converts it into its binary equivalent.
 *   2. Binary to Number Conversion: It takes a binary number as input and converts it back into its decimal equivalent. 
 *
*****************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string binaryRepresentation; 

        // prints the Binary Representation of all numbers from 0 to 2024 inclusive 
        for (int i = 0; i <= 2024; i++) 
        {

            // get the Binary Representation of the number 
            binaryRepresentation = BinaryRepresentation(i);

            // print the answer 
            Console.WriteLine("The binary representation of " + i + " is (using iteration): " + binaryRepresentation);

        }

        // get input from the user 
        Console.Write("Please enter a Binary Representation to convert into Integer: "); 
        binaryRepresentation = Console.ReadLine();
        Console.WriteLine("The Integer Representation of " + binaryRepresentation + ": " + ConvertBinaryToInteger(binaryRepresentation)); 
        Console.WriteLine("The Integer Representation of " + binaryRepresentation + ": " + ConvertBinaryToIntegerCiscoCCNADiscoveryCourse(binaryRepresentation)); 

        // stop  
        Console.ReadLine(); 

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

    // returns the Integer representation of a Binary number 
    public static int ConvertBinaryToInteger(string binaryRepresentation) 
    {

        // declare local variables 
        int result;

        // initialize local variables 
        result = 0;

        // we also learned to do this another way from the Book in CSI or CSII at FSU: Framingham State University 
        for (int i = 0; i < binaryRepresentation.Length; i++)
        {
            result += (Convert.ToString(binaryRepresentation[i]).Equals("1")) 
                ? (int)Math.Pow(2, binaryRepresentation.Length - 1 - i) : 0; 
        }

        // return result 
        return result; 

    } 

    // returns the Integer representation of a Binary number 
    public static int ConvertBinaryToIntegerCiscoCCNADiscoveryCourse(string binaryRepresentation) 
    {

        // declare local variables 
        int result;

        // initialize local variables 
        result = -1; 

        // for example, given the Binary Representation of 1996, 11111001100 
        // we can convert it into it's Integer representation using the following algorithm 
        // note: we learned this during our Senior year at Assabet Valley while taking Networking -
        // Medium Business or ISP, a college level course for credits towards NHTI: New Hampshire Technical Institute 
        // the college credits transfered into my major concentration at FSU and counts as 1-elective course (required) 
        // the assabet valley way/method goes here: 
        result = Convert.ToInt16(Convert.ToString(binaryRepresentation[0])); 
        for (int i = 1; i < binaryRepresentation.Length; i++) 
        {
            result += (Convert.ToString(binaryRepresentation[i]).Equals("1")) ? (result + 1) : result; 
        }

        // return result 
        return result; 

    }

} 
