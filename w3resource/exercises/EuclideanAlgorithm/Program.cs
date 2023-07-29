/*************************************************************************
 * Name: Sam Leal 
 * Date: 07/29/2023 
 * Filename: EuclideanAlgorithm.cs 
 * Description: Uses Euclid's Algorithm to calculate the greatest common 
 * denomintor between two numbers, a, and b 
 ************************************************************************/
public class EuclideanAlgorithm
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string[] input; 
        
        // prompt the user 
        Console.Write("Please enter two numbers, separated by a space: ");

        // gets input from the user 
        input = Console.ReadLine().Split();

        // prints the answer 
        Console.WriteLine("GCD: " + gcd(int.Parse(input[0]), int.Parse(input[1]))); 

    }
    
    // returns the greatest common denominator 
    public static int gcd(int a, int b)
    {

        // declare local variables 
        int result;

        // if a equals 0, then result = b 
        result = (a == 0) ? b : 0;

        // if b equals 0, then result = a 
        result = (b == 0) ? a : 0; 

        // return result 
        return result != 0 ? result : gcd(b, a % b); 

    }

}
