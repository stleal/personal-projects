/*********************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 09/03/2023 
 * Filename: JewelsAndStones.cs 
 * Description: You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. 
 * Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels. 
 * Letters are case sensitive, so "a" is considered a different type of stone from "A".
*********************************************************************************************************************************************/
public class Program
{

    // global variables 
    private static int[] _count;

    // main 
    public static void Main(string[] args)
    {

        // unit test case 01 
        JewelsInStones(8, 256);

        // unit test case 02 
        JewelsInStones(12, 512);

        // unit test case 03 
        JewelsInStones(16, 512);

        // keep the application running  
        Console.ReadLine();

    }

    /*********************************************************************************** 
     * JewelsInStones(int numOfJewels, int numOfStones) 
     * 1) randomly generates a "jewels" string of size: numOfJewels 
     * 2) randomly generates a "stones" string of size: numOfStones 
     * 3) gets the total count of stones in Jewels by calling NumJewelsInStones
     * 4) prints the total number of stones in jewels 
     ***********************************************************************************/
    public static void JewelsInStones(int numOfJewels, int numOfStones)
    {

        // declare local variables 
        Random r;
        int answer;
        char jewel;
        string jewels, stones, alphabet;

        // initialize local variables  
        r = new Random();
        jewels = stones = string.Empty;
        alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        // randomly picks x number of jewels from the alphabet
        // saves it into the jewels string 
        // ensures no duplicates 
        for (int i = 0; i < numOfJewels; i++)
        {
            jewel = ' ';
            while (jewel == ' ' || jewels.IndexOf(jewel) > -1)
            {
                jewel = (alphabet.ElementAt(r.Next(0, alphabet.Length)));
            }
            jewels += jewel;
        }

        // randomly picks x number of stones from the alphabet
        // saves it into the stones string 
        for (int i = 0; i < numOfStones; i++)
        {
            stones += (alphabet.ElementAt(r.Next(0, alphabet.Length)));
        }

        // get the number of jewels in stones 
        answer = NumJewelsInStones(jewels, stones);

        // prints the jewels in stones count 
        PrintNumJewelsInStones(jewels, stones, answer);

    }

    /*********************************************************************************** 
     * NumJewelsInStones(string jewels, string stones) 
     * 1) counts the number of stones in jewels 
     * 2) returns the total count  
     ***********************************************************************************/
    public static int NumJewelsInStones(string jewels, string stones)
    {

        // declare local variables 
        List<char> stonesChecked;
        int currentCount, totalCount;

        // initialize local variables 
        currentCount = totalCount = 0;
        _count = new int[jewels.Length];
        stonesChecked = new List<char>();

        // counts the number of stones that are jewels 
        for (int i = 0; i < stones.Length; i++)
        {

            // check if the current stone has not already been counted 
            if (!stonesChecked.Contains(stones.ElementAt(i)))
            {

                // add the stone to the list 
                stonesChecked.Add(stones.ElementAt(i));

                // check if the current stone is a jewel or not 
                if (jewels.IndexOf(stones.ElementAt(i)) > -1)
                {

                    // count the number of occurences 
                    for (int j = 0; j < stones.Length; j++)
                    {
                        currentCount += (stones.ElementAt(j).Equals(stones.ElementAt(i))) ? 1 : 0;
                    }

                    // saves the total count 
                    _count[jewels.IndexOf(stones.ElementAt(i))] = currentCount;
                    totalCount += currentCount;
                    currentCount = 0;

                }

            }

        }

        // returns the total count 
        return totalCount;

    }

    // prints the number of jewels in stones 
    public static void PrintNumJewelsInStones(string jewels, string stones, int totalCount)
    {

        // prints the jewels, and stones strings 
        Console.WriteLine("Jewels: " + jewels);
        Console.WriteLine("Stones: " + stones);
        Console.WriteLine("Number of Jewels: " + jewels.Length);
        Console.WriteLine("Number of Stones: " + stones.Length);

        // prints the jewels array 
        for (int i = 0; i < _count.Length; i++)
        {
            Console.WriteLine("jewels[" + i + "] = " + jewels[i] + ", count[" + i + "] = " + _count[i]);
        }

        // prints the total count 
        Console.WriteLine("Total Count: " + totalCount); 

        // prints a blank line 
        Console.WriteLine();

    }

}
