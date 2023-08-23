/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/20/2023 
 * Filename: SumOfUniqueElements.cs 
 * Description: You are given an integer array nums. The unique elements of an array are the elements that appear exactly once in the array. 
 * Return the sum of all the unique elements of nums. 
 * 
 * Example 1:
 * Input: nums = [1,2,3,2]
 * Output: 4
 * Explanation: The unique elements are [1,3], and the sum is 4.
 * 
 * Example 2:
 * Input: nums = [1,1,1,1,1]
 * Output: 0
 * Explanation: There are no unique elements, and the sum is 0.
 * 
 * Example 3:
 * Input: nums = [1,2,3,4,5]
 * Output: 15
 * Explanation: The unique elements are [1,2,3,4,5], and the sum is 15. 
********************************************************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int sum;
        Random r;
        int[] nums;

        // initialize local variables 
        r = new Random(); 
        nums = new int[] { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 9, 10 };
        
        // gets the sum of all the unique elements in nums 
        sum = SumOfUniqueElements(nums);

        // prints the sum 
        Console.WriteLine("Sum: " + sum); 

        // unit test case scenario using a Random number generator 
        nums = new int[100];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = r.Next(0, 101); 
        }
        sum = SumOfUniqueElements(nums);

        // prints the sum 
        Console.WriteLine("Sum: " + sum);

    }

    // returns the sum of all unique elements in the integer array 
    public static int SumOfUniqueElements(int[] nums)
    {

        // declare local variables 
        int answer;
        bool found; 
        List<int> duplicateElements;

        // initialize local variabels 
        answer = 0; 
        found = false; 
        duplicateElements = new List<int>(); 

        // adds the duplicate elements into a List<int> 
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if ((nums[i] == nums[j]) && (i != j))
                {
                    duplicateElements.Add(nums[i]);
                    break; 
                }
            }
        }

        // gets the sum of all the unique elements 
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < duplicateElements.Count; j++)
            {
                if (nums[i] == duplicateElements[j])
                {
                    found = true;
                    break; 
                }
            }
            if (!found)
            {
                answer += nums[i]; 
            }
            found = false; 
        }

        // returns the answer 
        return answer; 

    }

} 
