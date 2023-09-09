/********************************************************************************************
 * Name: Sam Leal 
 * Date: 09/04/2023 
 * Filename: CountPairs.cs 
 * Description: Given a 0-indexed integer array nums of length n and an integer target, 
 * return the number of pairs (i, j) where 0 <= i < j < n and nums[i] + nums[j] < target.
 * 
 * Example 1: 
 * Input: nums = [-1,1,2,3,1], target = 2 
 * Output: 3 
 * Explanation: There are 3 pairs of indices that satisfy the conditions in the statement: 
 * - (0, 1) since 0 < 1 and nums[0] + nums[1] = 0 < target 
 * - (0, 2) since 0 < 2 and nums[0] + nums[2] = 1 < target  
 * - (0, 4) since 0 < 4 and nums[0] + nums[4] = 0 < target 
 * Note that (0, 3) is not counted since nums[0] + nums[3] is not strictly less than the target.
 * 
 * For the purpose of this exercise, I've provided a CountPairs() method, which randomly generates 
 * an array of data, given the size of the array and range of the minimum and maximum value.  
 * 
 *  CountPairs(min, max, size, target, "output.txt"); 
 * 
 * If target is null, then it will also randomly generate a target value between 0, and max value. 
 * 
 *  CountPairs(min, max, size, null, "output.txt"); 
 * 
********************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // unit test case 01 
        CountPairs(-256, 256, 128, 87, "Test.txt");

        // unit test case 02 
        CountPairs(-256, 256, 128, 94, "Text02.txt");

        // unit test case 02 
        CountPairs(-256, 256, 128, 103, "Text03.txt");

    }

    // counts the number of pairs in the array 
    public static void CountPairs(int minValue, int maxValue, int size, int? target, string filename)
    {

        // declare local variables 
        Random r;
        int sum, count;
        int[] nums, pair;
        List<int[]> pairs;
        bool result; 

        // initialize local variables 
        count = 0;
        r = new Random();
        nums = new int[size];
        target = (target == null) ? r.Next(0, maxValue+1) : target;
        pairs = new List<int[]>();
        result = false;

        // generate some random numbers between minValue, and maxValue 
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = r.Next(minValue, maxValue+1);
        }

        // loop through the nums array 
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (i != j)
                {
                    sum = nums[i] + nums[j];
                    if (sum < target)
                    {
                        count++;
                        pair = new int[2];
                        pair[0] = i;
                        pair[1] = j;
                        pairs.Add(pair);
                    }
                }
            }
        }

        try
        {

            // write to file 
            using (StreamWriter sw = new StreamWriter("../../../Output/" + filename))
            {

                // writes a message 
                sw.WriteLine("Randomly generated array: ");

                // writes the randomly generated array into the file 
                for (int i = 0; i < nums.Length; i++)
                {
                    sw.WriteLine("nums[" + i + "] = " + nums[i]);
                }

                // writes a blank line 
                sw.WriteLine();

                // writes a message 
                sw.WriteLine("Pairs array: ");

                // writes the pairs array into the file 
                for (int i = 0; i < pairs.Count; i++)
                {
                    sw.WriteLine("(" + pairs[i][0] + ", " + pairs[i][1] + ") => " + (nums[pairs[i][0]] + nums[pairs[i][1]]));
                }

                // writes a blank line 
                sw.WriteLine();

                // writes the target 
                sw.WriteLine("Target: " + target);

                // writes the total number of pairs found 
                sw.WriteLine("Total number of pairs: " + count);

                // set result = true 
                result = true; 

            }

        } 
        catch (IOException ex)
        {
            Console.WriteLine("We're sorry, but there was an error writing or saving to the file: ");
            Console.WriteLine(ex.Message);
        }

        // display a message 
        if (result)
        {
            Console.WriteLine("Successfully wrote Pairs to Output file: " + filename); 
        }
        else
        {
            Console.WriteLine("Failed to write Pairs to Output file: " + filename); 
        }

    }

}
