/************************************************************************
 * Name: Sam Leal 
 * Date: 07/29/2023 
 * Filename: Calculator.cs 
 * Description: Performs mathematical operations on numbers. 
 ************************************************************************/
public class Calculator
{
        
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }

    // gets the sum of all the elements in an array 
    public int Sum(int[] nums)
    {

        // declare local variables 
        int sum = 0;

        // gets the sum of the array 
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        // returns the answer 
        return sum;

    }

}