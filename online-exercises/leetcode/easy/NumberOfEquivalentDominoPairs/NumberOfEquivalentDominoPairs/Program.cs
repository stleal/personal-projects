/*******************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 09/09/2023 
 * Filename: NumberOfEquivalentDominoPairs.cs 
 * Description: Given a list of dominoes, dominoes[i] = [a, b] is equivalent to dominoes[j] = [c, d] if and only if 
 * either (a == c and b == d), or (a == d and b == c) - that is, one domino can be rotated to be equal to another domino. 
 * Return the number of pairs (i, j) for which 0 <= i < j < dominoes.length, and dominoes[i] is equivalent to dominoes[j].
 * 
 * Example 1: 
 * Input: dominoes = [[1,2],[2,1],[3,4],[5,6]] 
 * Output: 1 
 * 
 * Example 2: 
 * Input: dominoes = [[1,2],[1,2],[1,1],[1,2],[2,2]] 
 * Output: 3
*******************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        Random r; 
        int[,] dominos;

        // initialize local variables 
        r = new Random();
        dominos = new int[0, 0]; 

        // example 1
        dominos = new int[4, 2]; 
        dominos[0,0] = 1;
        dominos[0,1] = 2;
        dominos[1,0] = 1;
        dominos[1,1] = 2;
        dominos[2,0] = 3;
        dominos[2,1] = 4;
        dominos[3,0] = 5;
        dominos[3,1] = 6;

        // print array 
        PrintArray(dominos); 

        // count pairs 
        Console.WriteLine("Number of pairs: " + CountPairs(dominos) + "\n"); 

        // example 2
        dominos = new int[8, 2];
        for (int i = 0; i < dominos.GetLength(0); i++)
        {
            dominos[i, 0] = r.Next(0, 7);
            dominos[i, 1] = r.Next(0, 7);
        }

        // print array 
        PrintArray(dominos);

        // count pairs 
        Console.WriteLine("Number of pairs: " + CountPairs(dominos) + "\n");

        // example 3
        dominos = new int[16, 2];
        for (int i = 0; i < dominos.GetLength(0); i++)
        {
            dominos[i, 0] = r.Next(0, 7);
            dominos[i, 1] = r.Next(0, 7);
        }

        // print array 
        PrintArray(dominos);

        // count pairs 
        Console.WriteLine("Number of pairs: " + CountPairs(dominos) + "\n");

    }

    // count pairs 
    public static int CountPairs(int[,] dominos)
    {

        // declare local variables 
        int pairs;
        string msg; 
        bool pair, match;

        // initialize local variables 
        pairs = 0;
        msg = string.Empty; 
        pair = match = false; 

        // counts the number of pairs in domnios 
        for (int i = 0; i < dominos.GetLength(0) - 1; i++)
        {

            for (int j = 0; j < dominos.GetLength(1) - 1; j++)
            {

                // a == c? 
                match = (dominos[i, j] == dominos[i + 1, j]) ? true : false;
                msg = (match) ? "dominos[" + i + ", " + j + "] = dominos[" + (i + 1) + ", " + j + "], " : string.Empty;
                msg += (match) ? dominos[i, j] + " = " + dominos[(i + 1), j] : string.Empty; 

                // b == d? 
                pair = (match && (dominos[i, j + 1] == dominos[i + 1, j + 1])) ? true : false;
                msg += (pair) ? "\n" + "dominos[" + i + ", " + (j + 1) + "] = dominos[" + (i + 1) + ", " + (j + 1) + "], " : string.Empty;
                msg += (pair) ? dominos[i, (j + 1)] + " = " + dominos[(i + 1), (j + 1)] : string.Empty;

                if (!pair)
                {

                    // a == d? 
                    match = (dominos[i, j] == dominos[i + 1, j + 1]) ? true : false;
                    msg = (match) ? "dominos[" + i + ", " + j + "] = dominos[" + (i + 1) + ", " + (j + 1) + "], " : string.Empty;
                    msg += (match) ? dominos[i, j] + " = " + dominos[(i + 1), (j + 1)] : string.Empty;

                    // b == c? 
                    pair = (match && (dominos[i, j + 1] == dominos[i + 1, j])) ? true : false;
                    msg += (pair) ? "\n" + "dominos[" + i + ", " + (j + 1) + "] = dominos[" + (i + 1) + ", " + j + "]. " : string.Empty;
                    msg += (pair) ? dominos[i, (j + 1)] + " = " + dominos[(i + 1), (j)] : string.Empty;

                }

                if (pair)
                {

                    // increment pairs 
                    pairs++; 

                    // print the message 
                    Console.WriteLine(msg);

                }

            }

            // reset match 
            match = false;

            // reset pair 
            pair = false; 

        }

        // return pairs 
        return pairs; 

    }

    // prints the array 
    public static void PrintArray(int[,] dominos)
    {
        for (int i = 0; i < dominos.GetLength(0); i++)
        {
            for (int j = 0; j < dominos.GetLength(1); j++)
            {
                Console.WriteLine("dominos[" + i + ", " + j + "] = " + dominos[i, j]); 
            }
        }
    }

}
