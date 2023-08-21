/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/20/2023 
 * Filename: SeparateDigits.cs 
 * Description: Given an array of positive integers nums, return an array answer that consists of the digits of each integer in nums after 
 * separating them in the same order they appear in nums. 
 * 
 * Example 1:
 * 
 * Input: nums = [13,25,83,77]
 * Output: [1,3,2,5,8,3,7,7]
 * Explanation: 
 *   The separation of 13 is [1,3].
 *   The separation of 25 is [2,5].
 *   The separation of 83 is [8,3].
 *   The separation of 77 is [7,7].
 * answer = [1,3,2,5,8,3,7,7]. Note that answer contains the separations in the same order.
 * Example 2:
 * 
 * Input: nums = [7,1,3,9]
 * Output: [7,1,3,9]
 * Explanation: The separation of each integer in nums is itself.
 * answer = [7,1,3,9].
********************************************************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] nums, digits; 

        // initialize local variables 
        nums = new int[] { 123, 456, 789, 1024, 2056, 9999 }; 

        // separates the digits from nums 
        digits = SeparateDigits(nums);

        // print the array 
        PrintArray(digits); 

    }

    // separates the digits from the int array 
    public static int[] SeparateDigits(int[] nums)
    {

        // declare local variables 
        string s;
        int[] answer;
        int size, counter;

        // initialize local variables 
        size = 0;
        counter = 0; 

        // counts the number of digits in each number in the int array 
        for (int i = 0; i < nums.Length; i++)
        {
            s = nums[i].ToString(); 
            size += s.Length; 
        }

        // initialize our answer array 
        answer = new int[size]; 

        // loop through each number in the integer array and extract the digits 
        for (int i = 0; i < nums.Length; i++)
        {
            s = nums[i].ToString(); 
            for (int j = 0; j < s.Length; j++)
            {
                answer[counter] = (int)Char.GetNumericValue(s.ElementAt(j)); 
                counter++; 
            }
        }

        // return answer 
        return answer; 

    }

    // prints the array 
    public static void PrintArray(int[] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine("data[" + i + "] = " + data[i]);
        }
    }

}
