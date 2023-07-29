/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 07/29/2023 
 * Filename: Moran.cs 
 * Description: Given an integer N, check whether the given number is a Moran Number or not. 
 * Moran numbers are a subset of Harshad numbers. A number N is a Moran number if N divided by 
 * the sum of its digits gives a prime number. For example some Moran numbers are 18, 21, 27, 42, 45 and so on.
 ********************************************************************************************/
using System;

public class Moran
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string input;

        // initialize variables 
        input = string.Empty;

        // infinite loop  
        while (input != "exit" && input != "stop")
        {
            
            // get input from the user 
            Console.Write("Please enter a number: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break; 

            // check whether the number is Moran or not 
            Console.WriteLine("Number " + input + " is Moran: " + IsMoran(int.Parse(input)));

        }

    }

    public static bool IsMoran(int n)
    {

        // declare variables 
        int sum;

        // gets the sum of the digits
        sum = SumOfDigits(n);

        // returns whether the number is Moran or not 
        return (n % sum) == 0 ? IsPrime(n / sum) : false; 

    }

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

    // returns whether a number is prime or not 
    public static bool IsPrime(int r)
    {

        // declare variables 
        bool flag;

        // initialize variables 
        flag = false;

        // returns r is not prime, if r = 1
        if (r == 1)
        {
            flag = true;
        }
        else
        {
            // checks whether the number is prime or not
            for (int i = 2; i <= r/2; i++)
            {
                if (r % i == 0)
                {
                    flag = true;
                    break;
                }
            }
        }

        // returns true/false
        return !flag;

    }

}
