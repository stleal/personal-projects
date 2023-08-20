/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/18/2023 
 * Filename: SubtractProductAndSum.cs 
 * Description: Given an integer number n, return the difference between the product of its digits and the sum of its digits. 
 * 
 * Example 1: 
 * Input: n = 234 
 * Output: 15  
 * Explanation: 
 * Product of digits = 2 * 3 * 4 = 24 
 * Sum of digits = 2 + 3 + 4 = 9 
 * Result = 24 - 9 = 15
 * 
 * Example 2:
 * Input: n = 4421
 * Output: 21
 * Explanation: 
 * Product of digits = 4 * 4 * 2 * 1 = 32 
 * Sum of digits = 4 + 4 + 2 + 1 = 11 
 * Result = 32 - 11 = 21
********************************************************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int difference;

        difference = ComputeDifference(234);
        Console.WriteLine("Result = " + difference); 

        difference = ComputeDifference(4421);
        Console.WriteLine("Result = " + difference);

        difference = ComputeDifference(94);
        Console.WriteLine("Result = " + difference);
        Console.ReadLine(); 

    }

    public static int ComputeDifference(int n)
    {

        // declare local variables 
        int difference, sumOfDigits, productOfDigits;

        // get the sum of the digits 
        sumOfDigits = SumOfDigits(n); 

        // get the product of the digits 
        productOfDigits = ProductOfDigits(n);

        // get the difference of the product and sum of the digits 
        difference = productOfDigits - sumOfDigits;

        // return the difference 
        return difference; 

    }

    // returns the sum of the digits in any given number 
    public static int SumOfDigits(int n)
    {

        // declare variables 
        int answer;

        // initialize variables 
        answer = 0;

        // adds each digit to the sum of digits 
        while (n >= 1)
        {
            answer += (n % 10);
            n /= 10;
        }

        // returns the sum of the digits of n
        return answer;

    }

    // returns the product of the digits in any given number 
    public static int ProductOfDigits(int n)
    {

        // declare variables 
        int answer;

        // initialize variables 
        answer = 1;

        // adds each digit to the sum of digits 
        while (n >= 1)
        {
            answer *= (n % 10);
            n /= 10;
        }

        // returns the product of the digits of n
        return answer;

    }

}
