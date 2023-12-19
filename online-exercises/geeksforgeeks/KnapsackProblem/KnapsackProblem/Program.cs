/***********************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 12/08/2023 
 * Filename: KnapsackProblem.cs 
 * Description: Given N items where each item has some weight and profit associated with it and also 
 * given a bag with capacity W, [i.e., the bag can hold at most W weight in it]. The task is to put the 
 * items into the bag such that the sum of profits associated with them is the maximum possible. Note: The constraint 
 * here is we can either put an item completely into the bag or cannot put it at all [It is not possible to put a part of an 
 * item into the bag]. 
 * 
 * Examples: 
 * 
 * Example 1: 
 * Input: N = 3, W = 4, profit[] = {1, 2, 3}, weight[] = {4, 5, 1} 
 * Output: 3 
 * Explanation: There are two items which have weight less than or equal to 4. If we select the item with weight 4, 
 * the possible profit is 1. And if we select the item with weight 1, the possible profit is 3. So the maximum possible profit is 3. 
 * Note that we cannot put both the items with weight 4 and 1 together as the capacity of the bag is 4.
***********************************************************************************************************************************************/
public class Program
{   

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int maxProfit;  
        int count, capacity;
        int[] weights, profits;

        // initialize local variables 
        count = 8;
        weights = new int[count];
        profits = new int[count];
        capacity = 64;

        // Unit Test Case 01 
        weights = new int[] { 8, 6, 5, 32, 16, 256, 128, 2 };
        profits = new int[] { 10, 10, 10, 10, 8, 16, 24, 32 }; 
        maxProfit = KnapsackProblem(weights, profits, capacity, count);

        // print 
        Console.WriteLine("Maximum Profit: " + maxProfit); 

        // stop 
        Console.ReadLine(); 

    } 

    // Knapsack Problem 
    public static int KnapsackProblem(int[] weights, int[] profits, int capacity, int count)
    {

        // declare local variables 
        int i, maxProfit; 

        // initialize local variables 
        i = count-1;
        maxProfit = 0;

        // sort the weights, and profits 
        BubbleSort(weights, profits, count);

        // Knapsack 
        while (capacity > 0)
        {
            if (weights[i] <= capacity)
            {
                maxProfit += profits[i]; 
                capacity -= weights[i]; 
            }
            i--; 
        }

        // return the maximum Profit 
        return maxProfit; 

    }

    // BubbleSort with two (2) arrays, not just one! 
    public static void BubbleSort(int[] weights, int[] profits, int count)
    {
        for (int i = 0; i < count; i++)
        {
            for (int j = i; j <= count - 1; j++)
            {
                if (weights[i] > weights[j])
                {
                    int swap;
                    swap = weights[i];
                    weights[i] = weights[j];
                    weights[j] = swap;
                    swap = profits[i];
                    profits[i] = profits[j];
                    profits[j] = swap;
                }
            }
        }
    }

}
