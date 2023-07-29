/********************
 * Name: Sam Leal 
 * Date: 07/28/2023 
 * Filename: TwoSum.cs 
 * Description: Given an array of integers nums and an integer target, 
 * return indices of the two numbers such that they add up to target.
 *******************/
public class TwoSum
{

    // main 
    public static void Main(String[] args)
    {

        // get input from the user 
        Console.Write("Please enter any number of integers seperated by a space: ");
        string[] input = Console.ReadLine().Split(" ");

        // get the target number from the user 
        Console.Write("Please enter your target number: ");
        int target = int.Parse(Console.ReadLine()); 
        
        // finds the solution 
        int[] answer = Solution(input, target);

        if (answer != null)
        {
            // outputs the answer 
            Console.WriteLine("The indices of the two numbers in the data array, such that the two numbers add up to target are: " + answer[0] + ", and " + answer[1]);
            Console.WriteLine("Those two numbers are: " + input[answer[0]] + ", and " + input[answer[1]]);
        }
        else
        {
            // outputs an error message 
            Console.WriteLine("We're sorry, but none of the numbers in the data array add up to target. Please try again with another number and/or set of data."); 
        }

        // prevent the Console from closing 
        Console.ReadLine(); 

    }
    
    // solution 
    public static int[] Solution(string[] data, int target)
    {

        // declare variables 
        int sum;
        int[] answer;
        bool found; 

        // initialize variables 
        sum = 0;
        answer = new int[2];
        found = false; 

        // finds the two indices that add up to target 
        for (int i = 0; i < data.Length; i++)
        {
            sum = int.Parse(data[i]);
            for (int j = 0; j < data.Length; j++)
            {
                if (j != i)
                {
                    sum += int.Parse(data[j]);
                    if (sum == target)
                    {
                        answer[0] = i;
                        answer[1] = j;
                        found = true; 
                        return answer;
                    }
                    else
                    {
                        sum = int.Parse(data[i]);
                    }
                }
            }
        }

        // returns the indices that add up to target or null if none 
        return ((sum == target) && (found == true)) ? answer : null;

    }

}
