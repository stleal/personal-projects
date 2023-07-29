/*************************************************************************
 * Name: Sam Leal 
 * Date: 07/29/2023 
 * Filename: EuclideanAlgorithm.cs 
 * Description: Uses Euclid's Algorithm to calculate the greatest common 
 * denomintor between two numbers, a, and b 
 ************************************************************************/
public class EuclideanAlgorithm
{

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
        int result = 0;

        // if a equals 0, then result = b 
        if (a == 0)
            result = b;

        // if b equals 0, then result = a 
        if (b == 0)
            result = a;

        // return result 
        return result != 0 ? result : gcd(b, a % b); 

    }

}
