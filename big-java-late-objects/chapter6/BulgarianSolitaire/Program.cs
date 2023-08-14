/********************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/13/2023 
 * Filename: BulgarianSolitaire.cs 
 * Description: In this assignment, you will model the game of Bulgarian Solitaire. The game starts with 45 cards. (They need 
 * not be playing cards. Unmarked index cards work just as well.) Randomly divide them into some number of piles of random size. 
 * For example, you might start with piles of size 20, 5, 1, 9, and 10. In each round, you take one card from each pile, forming a 
 * new pile with these cards. For example, the sample starting configuration would be transformed into piles of size 19, 4, 8, 9, and 5. 
 * The solitaire is over when the piles have size 1, 2, 3, 4, 5, 6, 7, 8, and 9, in some order. (It can be shown that you always end up 
 * with such a configuration.) 
 * 
 * In your program, produce a random starting configuration and print it. Then keep applying the solitaire step and print the result. Stop 
 * when the solitaire final configuration is reached. 
********************************************************************************************************************************************/
using System.Collections;

public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        ArrayList piles;
        int counter = 0; 

        // initialize local variables 
        piles = new ArrayList();
        counter = 0;

        // get the starting configuration 
        piles = UnitTest(); 

        // prints the starting configuration 
        Console.WriteLine("Starting configuration: ");
        PrintPiles(piles);
        Console.WriteLine();

        // divide piles until the game is over 
        while(!GameOver(piles))
        {
            DividePile(piles);
            counter++; 
            Console.WriteLine("After " + counter + " configurations: ");
            PrintPiles(piles);
        }

        // total number of re-configurations 
        Console.WriteLine("The game is over after: " + counter + " re-configurations."); 

        // keep the application running 
        Console.ReadLine(); 

    } 

    // divides the pile into separate stacks 
    public static void DividePile(ArrayList piles)
    {
        piles.Add(0);
        for (int i = 0; i < piles.Count - 1; i++)
        {
            piles[i] = (int)piles[i] - 1;
            piles[piles.Count - 1] = (int)piles[piles.Count - 1] + 1;
            if ((int)piles[i] == 0)
            {
                piles.RemoveAt(i);
                i--;
            }
        }
    }

    // prints the piles 
    public static void PrintPiles(ArrayList piles)
    {
        for (int i = 0; i < piles.Count; i++)
        {
            Console.WriteLine("piles[" + i + "] = " + piles[i] + ", ");
        }
    }

    // checks whether the game is over or not 
    public static bool GameOver(ArrayList piles)
    {

        // declare local variables 
        int[] nums;
        bool gameOver; 
        
        // initialize local variables 
        nums = new int[9];
        gameOver = true;

        // sets nums[i] = 1, where (i+1) is found in piles[j]  
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < piles.Count; j++)
            {
                if ((int)piles[j] == (i + 1))
                {
                    nums[i] = 1;
                    break; 
                }
            }
        }

        // check to make sure all nums[i] = 1 
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 1)
            {
                gameOver = false;
                break; 
            }
        }
    
        // return whether the game is over or not 
        return gameOver; 

    }

    public static ArrayList UnitTest()
    {

        // declare local variables 
        ArrayList piles; 
        
        // initialize local variables
        piles = new ArrayList(); 
        piles.Add(20);
        piles.Add(5);
        piles.Add(1);
        piles.Add(9);
        piles.Add(10);
        
        // returns the starting configuration 
        return piles; 

    }

    public static ArrayList UnitTest02()
    {

        // declare local variables 
        ArrayList piles;

        // initialize local variables
        piles = new ArrayList();
        piles.Add(10);
        piles.Add(10);
        piles.Add(10);
        piles.Add(10);
        piles.Add(5);

        // returns the starting configuration 
        return piles;

    }

    public static ArrayList UnitTest03()
    {

        // declare local variables 
        ArrayList piles;

        // initialize local variables
        piles = new ArrayList();
        piles.Add(4);
        piles.Add(8);
        piles.Add(12);
        piles.Add(21);

        // returns the starting configuration 
        return piles;

    }

}
