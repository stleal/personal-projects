/********************************************************
 * Name: Sam Leal 
 * Date: 07/29/2023
 * Filename: FourSum.cs 
 * Description: Using a Calculator.cs class, 
 * get the sum of 4 numbers entered from the user. 
 ********************************************************/
public class FourSum
{

    // global variables 
    private static Calculator calculator = new Calculator(); 

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] nums;
        int answer; 

        // initialize variables 
        nums = new int[4];

        // prompt user for input 
        Console.WriteLine("Enter four whole numbers, one on each line, please."); 

        // get input from the user 
        for (int i = 0; i < nums.Length; i++) 
        {
            // gets a number from the user 
            nums[i] = int.Parse(Console.ReadLine()); 
        }

        // gets the answer 
        answer = Solution(nums);

        // prints the answer 
        Console.WriteLine("The answer is: " + answer);
        Console.ReadLine(); 

    }

    // returns the sum of 4 numbers 
    public static int Solution(int[] nums)
    {

        // gets the sum of the array 
        return calculator.Sum(nums);

    }

}
