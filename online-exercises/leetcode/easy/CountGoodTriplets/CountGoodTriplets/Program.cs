/*******************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 09/10/2023 
 * Filename: CountGoodTriplets.cs 
 * Description: Given an array of integers arr, and three integers a, b and c. You need to find the number of good triplets. 
 * 
 * A triplet (arr[i], arr[j], arr[k]) is good if the following conditions are true: 
 *   
 *   0 <= i < j < k < arr.length 
 *   |arr[i] - arr[j]| <= a 
 *   |arr[j] - arr[k]| <= b 
 *   |arr[i] - arr[k]| <= c 
 *   Where |x| denotes the absolute value of x. 
 * 
 * Return the number of good triplets. 
 * 
 * Example 1: 
 * Input: arr = [3,0,1,1,9,7], a = 7, b = 2, c = 3 
 * Output: 4 
 * Explanation: There are 4 good triplets: [(3,0,1), (3,0,1), (3,1,1), (0,1,1)].
*******************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] data;
        int a, b, c;
        int triplets;

        // initialize local variables 
        a = 4;
        b = 2;
        c = 6;
        triplets = 0;
        data = new int[] { 8, 10, 12, 16, 21, 23, 24, 25, 26, 28, 30, 32, 64, 128 };

        // loop through the array 
        for (int i = 0; i < data.Length - 2; i++)
        {
            if (Math.Abs(data[i] - data[(i+1)]) <= a)
            {
                if (Math.Abs(data[(i+1)] - data[(i + 2)]) <= b)
                {
                    if (Math.Abs(data[i] - data[(i + 2)]) <= c)
                    {
                        triplets++; 
                    }
                }
            }
        }

        // prints the number of triplets 
        Console.WriteLine("Triplets: " + triplets); 

    }

}
