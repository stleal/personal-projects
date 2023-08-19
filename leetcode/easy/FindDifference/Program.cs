/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/18/2023 
 * Filename: FindDifference.cs 
 * Description: Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where: 
 * answer[0] is a list of all distinct integers in nums1 which are not present in nums2. 
 * answer[1] is a list of all distinct integers in nums2 which are not present in nums1. 
 * Note that the integers in the lists may be returned in any order. 
 * 
 * Example 1:
 * Input: nums1 = [1,2,3], nums2 = [2,4,6]
 * Output: [[1,3],[4,6]]
 * Explanation:
 * For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1,3].
 * For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4,6].
 * 
 * Example 2:
 * Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
 * Output: [[3],[]] 
 * Explanation:
 * For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
 * Every integer in nums2 is present in nums1. Therefore, answer[1] = [].
********************************************************************************************************************************************************************/
using System;

public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] nums1, nums2;
        List<List<int>> difference; 

        // initialize local variables
        nums1 = new int[] { 1, 2, 2, 3 };
        nums2 = new int[] { 1, 1, 2, 2 }; 

        // find the difference in the two arrays 
        difference = FindDifference(nums1, nums2);

        // print nums1 
        PrintArrayList(difference, 0);

        // print nums2 
        PrintArrayList(difference, 1);

        // keep the application running 
        Console.ReadLine();

    } 

    // finds the difference in two arrays 
    public static List<List<int>> FindDifference(int[] nums1, int[] nums2)
    {

        // declare local variables 
        List<List<int>> answer;

        // initialize local variables 
        answer = new List<List<int>>();
        
        // add the distinct1 array into the list 
        answer.Add(GetDistinct(nums1, nums2));

        // add the distinct2 array into the list 
        answer.Add(GetDistinct(nums2, nums1));

        // returns the result 
        return answer; 

    } 

    public static List<int> GetDistinct(int[] nums1, int[] nums2)
    {

        // declare local variables 
        bool found;
        List<int> distinct;

        // initialize local variables 
        distinct = new List<int>();

        // loop through nums1 and nums2 to get the distinct ints 
        for (int i = 0; i < nums1.Length; i++)
        {
            found = false;
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                distinct.Add(nums1[i]);
            }
        }

        // return distinct ints 
        return distinct; 

    } 

    // prints the array 
    public static void PrintArrayList(List<List<int>> difference, int index)
    {
        if (difference[index].Count > 0)
        {
            for (int i = 0; i < difference[index].Count; i++)
            {
                Console.WriteLine("nums" + (index+1) + "[" + i + "] = " + difference[index][i]);
            }
        }
        else
        {
            Console.WriteLine("nums" + (index+1) + "[]"); 
        }
    }

}
