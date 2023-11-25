﻿/*********************************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 10/21/2023 
 * Filename: PerfectNumbers.cs 
 * Description: Determine if a number is perfect, abundant, or deficient based on Nicomachus' (60 - 120 CE) classification scheme for positive integers. 
 * 
 * The Greek mathematician Nicomachus devised a classification scheme for positive integers, identifying each as belonging uniquely to the categories of perfect, abundant, or 
 * deficient based on their aliquot sum. The aliquot sum is defined as the sum of the factors of a number not including the number itself. 
 * 
 * For example, the aliquot sum of 15 is (1 + 3 + 5) = 9 
 * 
 * Perfect: aliquot sum = number 
 * 6 is a perfect number because (1 + 2 + 3) = 6 
 * 28 is a perfect number because (1 + 2 + 4 + 7 + 14) = 28 
 * 
 * Abundant: aliquot sum > number 
 * 12 is an abundant number because (1 + 2 + 3 + 4 + 6) = 16 
 * 24 is an abundant number because (1 + 2 + 3 + 4 + 6 + 8 + 12) = 36 
 * 
 * Deficient: aliquot sum < number 
 * 8 is a deficient number because (1 + 2 + 4) = 7 
 * Prime numbers are deficient 
 * 
 * Implement a way to determine whether a given number is perfect. Depending on your language track, you may also need to implement a way to determine whether a given 
 * number is abundant or deficient.
*********************************************************************************************************************************************************************************/
public class PerfectNumber
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int n, sum, i, count; 

        // example 1 
        n = 103;
        sum = GetAliquotSum(n);
        Print(sum, n); 

        // example 2
        for (i = 0; i <= 100; i++)
        {
            n = i; 
            sum = GetAliquotSum(n);
            Print(sum, n);
        }

        // example 3
        // the first 5 Perfect Numbers 
        count = i = 0; 
        while (count < 5)
        {
            n = i;
            sum = GetAliquotSum(i);
            if (IsPerfect(sum, n))
            {
                Print(sum, n);
                count++; 
            }
            i++;
        }

        // example 4
        // the first 100 Abundant Numbers 
        count = i = 0;
        while (count < 100)
        {
            n = i;
            sum = GetAliquotSum(i);
            if (IsAbundant(sum, n))
            {
                Print(sum, n);
                count++;
            }
            i++;
        }

        Console.ReadLine(); 

    }

    public static int GetAliquotSum(int n)
    {
        int sum;
        sum = (n != 1) ? 1 : 0; 
        for (int i = 2; i <= n/2; i++)
        {
            if (IsFactor(i, n))
            {
                sum += i; 
            }
        }
        return sum; 
    }

    public static bool IsFactor(int x, int n)
    {
        return (n % x == 0) ? true : false;
    }

    public static bool IsPrime(int n)
    {
        bool flag;
        flag = false; 
        for (int i = 2; i <= n/2; i++)
        { 
            if (n % i == 0)
            {
                flag = true;
                break; 
            }
        }
        return !flag; 
    }

    public static bool IsPerfect(int aliquotSum, int n)
    {
        return (aliquotSum == n) ? true : false; 
    }

    public static bool IsAbundant(int aliquotSum, int n)
    {
        return (aliquotSum > n) ? true : false; 
    }

    public static bool IsDeficient(int aliquotSum, int n)
    {
        return (aliquotSum < n) ? true : false; 
    } 

    public static void Print(int sum, int n)
    {
        Console.WriteLine("Number: " + n + "\n" + "Aliquot Sum: " + sum);
        Console.WriteLine("Is Perfect: " + IsPerfect(sum, n));
        Console.WriteLine("Is Abundant: " + IsAbundant(sum, n));
        Console.WriteLine("Is Deficient: " + IsDeficient(sum, n));
        Console.WriteLine("Is Prime: " + IsPrime(n));
        Console.WriteLine();
    }

}
