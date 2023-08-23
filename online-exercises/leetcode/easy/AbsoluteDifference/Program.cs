/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/21/2023 
 * Filename: AbsoluteDifference.cs 
 * Description: You are given a positive integer array nums. 
 * The element sum is the sum of all the elements in nums. 
 * The digit sum is the sum of all the digits (not necessarily distinct) that appear in nums. 
 * Return the absolute difference between the element sum and digit sum of nums. 
 * Note that the absolute difference between two integers x and y is defined as |x - y|.
 * 
 * Example 1: 
 * Input: nums = [1,15,6,3]
 * Output: 9
 * Explanation: 
 * The element sum of nums is 1 + 15 + 6 + 3 = 25.
 * The digit sum of nums is 1 + 1 + 5 + 6 + 3 = 16.
 * The absolute difference between the element sum and digit sum is |25 - 16| = 9.
 * 
 * Example 2:
 * Input: nums = [1,2,3,4]
 * Output: 0
 * Explanation:
 * The element sum of nums is 1 + 2 + 3 + 4 = 10.
 * The digit sum of nums is 1 + 2 + 3 + 4 = 10.
 * The absolute difference between the element sum and digit sum is |10 - 10| = 0.
********************************************************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] nums;
        int absoluteDifference; 

        // initialize local variables 
        nums = new int[] { 123, 456, 789, 1024, 2048, 9999 }; 

        // gets the absolute difference in the array 
        absoluteDifference = AbsoluteDifference(nums);

        // prints the absolute difference 
        Console.WriteLine("Absolute difference: " + absoluteDifference); 

        // keep the application running 
        Console.ReadLine();

    }

    public static int AbsoluteDifference(int[] nums)
    {

        // declare local variables 
        string s; 
        int answer, sum, digitSum;

        // initialize local variables 
        s = string.Empty;
        answer = sum = digitSum = 0;

        // calculates the sum of the array and the sum of the digits in the array 
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            s = nums[i].ToString(); 
            for (int j = 0; j < s.Length; j++)
            {
                digitSum += (int) Char.GetNumericValue(s[j]); 
            }
        }

        // prints the sum 
        Console.WriteLine("Sum: " + sum);

        // prints the sum of the digits 
        Console.WriteLine("Sum of the digits: " + digitSum);

        // calculates the absolute difference 
        answer = sum - digitSum;

        // returns the answer 
        return answer; 

    }

}
