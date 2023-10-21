/*******************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 09/10/2023 
 * Filename: FairCandySwap.cs 
 * Description: Alice and Bob have a different total number of candies. You are given two integer arrays aliceSizes and bobSizes 
 * where aliceSizes[i] is the number of candies of the ith box of candy that Alice has and bobSizes[j] is the number of candies of 
 * the jth box of candy that Bob has. 
 * 
 * Since they are friends, they would like to exchange one candy box each so that after the exchange, they both have the same total 
 * amount of candy. The total amount of candy a person has is the sum of the number of candies in each box they have. 
 * 
 * Return an integer array answer where answer[0] is the number of candies in the box that Alice must exchange, and answer[1] is the 
 * number of candies in the box that Bob must exchange. If there are multiple answers, you may return any one of them. It is guaranteed 
 * that at least one answer exists. 
 * 
 * Example 1: 
 * Input: aliceSizes = [1,1], bobSizes = [2,2] 
 * Output: [1,2] 
 * 
 * Example 2: 
 * Input: aliceSizes = [1,2], bobSizes = [2,3] 
 * Output: [1,2] 
 * 
 * Example 3: 
 * Input: aliceSizes = [2], bobSizes = [1,3] 
 * Output: [2,3]
*******************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] aliceSizes, bobSizes;

        // example 1 
        aliceSizes = new int[] { 1, 1 };
        bobSizes = new int[] { 2, 2 }; 
        FairCandySwap(aliceSizes, bobSizes);

        // example 2 
        aliceSizes = new int[] { 1, 2 };
        bobSizes = new int[] { 2, 3 };
        FairCandySwap(aliceSizes, bobSizes);

        // example 3
        aliceSizes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bobSizes = new int[] { 2, 3, 6, 12, 24 };
        FairCandySwap(aliceSizes, bobSizes);

        // example 4 
        // not a "fair" trade 
        // unable to distribute an equal number of
        // candy packages to each person
        aliceSizes = new int[] { 2, 3, 5}; // 2+3+5 = 10 
        bobSizes = new int[] { 6, 8, 12}; // 6+8+12 = 26
        FairCandySwap(aliceSizes, bobSizes);

        // example 5 
        // 8+2 = 10 => 10/2 = 5 => 8-5 = 3 => 1, 1, 3 => 5 => 1+1+3 = 5 = 5;
        // but she / "Alice" needs to give at least one pack of candies to Bob
        // not a fair trade 
        aliceSizes = new int[] { 1, 1 }; // 1+1 = 2 
        bobSizes = new int[] { 3, 5 }; // 3+5 = 8 
        FairCandySwap(aliceSizes, bobSizes); 

    } 

    // fair candy swap 
    public static void FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {

        // declare local variables 
        bool fairTrade; 
        int aliceNumberOfCandies, bobNumberOfCandies;

        // initialize local variables 
        fairTrade = false; 
        aliceNumberOfCandies = bobNumberOfCandies = 0;

        // how many candies does Alice have? 
        for (int i = 0; i < aliceSizes.Length; i++)
        {
            aliceNumberOfCandies += aliceSizes[i];
        }

        // how many candies does bob have? 
        for (int i = 0; i < bobSizes.Length; i++)
        {
            bobNumberOfCandies += bobSizes[i];
        }

        // who has more candies? 
        if (aliceNumberOfCandies > bobNumberOfCandies)
        {
            fairTrade = ExchangeCandies(bobSizes, aliceSizes, bobNumberOfCandies, aliceNumberOfCandies);
        }
        else if (bobNumberOfCandies > aliceNumberOfCandies)
        {
            fairTrade = ExchangeCandies(aliceSizes, bobSizes, aliceNumberOfCandies, bobNumberOfCandies);
        }
        else if (aliceNumberOfCandies == bobNumberOfCandies)
        {

        }

        // print the result 
        if (fairTrade)
        {
            Console.WriteLine("Fair trade"); 
        }
        else
        {
            Console.WriteLine("Not a fair trade"); 
        }

    }

    // exchanges packages of candies between two individuals 
    // creates two new int[] arrays with equal number of candies 
    public static bool ExchangeCandies(int[] smallerSize, int[] biggerSize, int smallerNumberOfCandies, int biggerNumberOfCandies)
    {

        // declare local variables 
        bool equal; 
        int counter;
        int[] smaller, bigger;
        int smallerIndex, biggerIndex;
        int[] smallerSizesFinal, biggerSizesFinal;
        int expectedNumberOfCandies, totalNumberOfCandies;
        int smallerExchangeAmount, biggerExchangeAmount, actualExchange;

        // initialize local variables 
        equal = false; 
        counter = 0; 
        bigger = biggerSize;
        smaller = smallerSize;  
        smallerIndex = biggerIndex = -1;

        // total number of candies 
        totalNumberOfCandies = smallerNumberOfCandies + biggerNumberOfCandies;

        // expected number of candies for each person 
        expectedNumberOfCandies = totalNumberOfCandies / 2;

        // calculates the bigger exchange amount 
        biggerExchangeAmount = biggerNumberOfCandies - expectedNumberOfCandies;

        // does bob have a package of exchangeAmount number of candies? 
        for (int i = 0; i < bigger.Length; i++)
        {
            if (bigger[i] == biggerExchangeAmount)
            {
                biggerIndex = i;
            }
        }

        // if he does not 
        if (biggerIndex == -1)
        {
            // get the smallest package available 
            // assuming the array is sorted 
            biggerIndex = 0;
            biggerExchangeAmount = biggerSize[biggerIndex];
        }

        // get the package 
        biggerExchangeAmount = bigger[biggerIndex];

        // give Alice the package of candies 
        smallerNumberOfCandies += biggerExchangeAmount;

        // subtract from Bob's candies 
        biggerNumberOfCandies -= biggerExchangeAmount;

        // calculate the new exchange amount to give to bob from Alice 
        smallerExchangeAmount = smallerNumberOfCandies - expectedNumberOfCandies;

        // search for that exchangeAmount in aliceSizes 
        for (int i = 0; i < smaller.Length; i++)
        {
            if (smaller[i] == smallerExchangeAmount)
            {
                smallerIndex = i;
                break;
            }
        }

        // if she does not 
        if (smallerIndex == -1)
        {
            // get the smallest package available 
            // assuming the array is sorted 
            smallerIndex = 0;
            smallerExchangeAmount = smallerSize[smallerIndex];
        }

        // get the candy package 
        actualExchange = smaller[smallerIndex];

        // give the candy package to bob 
        biggerNumberOfCandies += smaller[smallerIndex];

        // subtract from alice's candies 
        smallerNumberOfCandies -= actualExchange;

        // copy the new package into alices new array 
        smallerSizesFinal = new int[smaller.Length];
        for (int i = 0; i < smaller.Length; i++)
        {
            if (i != smallerIndex)
            {
                smallerSizesFinal[counter++] = smaller[i];
            }
        }
        smallerSizesFinal[smallerSizesFinal.Length - 1] = biggerExchangeAmount;

        // copy the new package into bob's new array 
        counter = 0;
        biggerSizesFinal = new int[bigger.Length];
        for (int i = 0; i < bigger.Length; i++)
        {
            if (i != biggerIndex)
            {
                biggerSizesFinal[counter++] = bigger[i];
            }
        }
        biggerSizesFinal[biggerSizesFinal.Length - 1] = smallerExchangeAmount;

        // print the two new arrays 
        Console.Write("Alice: "); 
        for (int i = 0; i < smallerSizesFinal.Length; i++)
        {
            Console.Write(smallerSizesFinal[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Bob: ");
        for (int i = 0; i < biggerSizesFinal.Length; i++)
        {
            Console.Write(biggerSizesFinal[i] + " ");
        }
        Console.WriteLine();

        // is it a fair trade? 
        equal = (smallerNumberOfCandies == biggerNumberOfCandies) ? true : false;

        // return equal or not 
        return equal; 

    }

}
