/*****************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/08/2023 
 * Filename: TheGameOfNim.cs 
 * Description: This is a well-known game with a number of variants. The following variant has an interesting winning 
 * strategy. Two players alternately take marbles from a pile. In each move, a player chooses how many marbles to take. 
 * The player must take at least one but at most half of the marbles. Then the other player takes a turn. The player who 
 * takes the last marble loses. 
 * 
 * Write a program in which the computer plays against a human opponent. Generate a random integer between 10 and 100 to denote 
 * the initial marblesRemaining of the pile. Generate a random integer between 0 and 1 to decide whether the computer or the human takes the 
 * first turn. Generate a random integer between 0 and 1 to decide whether the computer plays smart or stupid. In stupid mode the 
 * computer simply takes a random legal value (between 1 and n/2) from the pile whenever it has a turn. In smart mode the computer 
 * takes off enough marbles to make the marblesRemaining of the pile a power of two minus 1 - that is 3, 7, 15, 31, or 63. That is always a legal 
 * move, except when the marblesRemaining of the pile is currently one less than a power of two. In that case, the computer makes a random legal move. 
 * 
 * You will note that the computer cannot be beaten in smart mode when it has the first move, unless the pile marblesRemaining happens to be 15, 31, 
 * or 63. Of course, a human player who has the first turn and knows the winning strategy can win against the computer. 
*****************************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string msg;     
        Random random;
        bool nimWinner;
        int nimTurn, firstTurn; 
        int marblesRemaining, nimMove; 
        int initialmarblesRemaining, smartOrStupid;
        
        // initialize local variables 
        msg = string.Empty; 
        random = new Random();
        initialmarblesRemaining = random.Next(10, 101);
        smartOrStupid = random.Next(0, 2);
        firstTurn = random.Next(0, 2); 
        marblesRemaining = initialmarblesRemaining;
        nimTurn = firstTurn;
        nimWinner = false;
        nimMove = -1;

        // display a welcome message 
        msg += "The Game of Nim\n\n";

        // first turn coin toss 
        msg += "Results of the coin toss: " + firstTurn + "\n"; 
        msg += (firstTurn == 0) ? "The Computer is going first.\n\n" : "You are going first.\n\n";

        // smart of stupid coin toss 
        msg += "Results of the smart or stupid coin toss: " + smartOrStupid + "\n";
        msg += (smartOrStupid == 0) ? "Computer is playing smart.\n\n" : "Computer is playing stupid.\n\n";

        // display the number of remaining marbles 
        msg += "There are " + marblesRemaining + " marbles remaining.\n";
        msg += (nimTurn == 0) ? "The computer may take up to " + (marblesRemaining / 2) + " of marbles.\n" : "";
        msg += (nimTurn == 1) ? "You may take up to " + (marblesRemaining / 2) + " of marbles.\n" : "";

        // print the message 
        Console.WriteLine(msg);

        // infinite loop 
        while (marblesRemaining > 0)
        {
            switch (nimTurn)
            {
                case 0:

                    if (smartOrStupid == 0)
                    {
                        /******************************************************************************************************************
                         * Rules: (for the Computer's turn) 
                         * 
                         * 0 == smart mode 
                         * 1 == easy mode 
                         * 
                         * If computer is playing smart mode: 
                         * 
                         *  1) Check if marblesRemaining > 1
                         *    2a) If yes, then check if marblesRemaining = (2^x)-1, where x in (1, 2, 3, 4, 5, 6) 
                         *      3a) If yes, then make a random legal move, i.e.: pick a random number between 1 and marblesRemaining/2 
                         *      3b) If no, then make a smart move; the computer must take away / remove enough marbles to make marblesRemaining 
                         *          equal to (2^x)-1, i.e.: suppose there are 76 marbles remaining, therefore the computer must remove 13 marbles, 
                         *          so that the remaining number of marbles = (2^6)-1 = 63. 
                         *    2b) If no, then check if marbles remaining == 1 
                         *      3a) If yes, remove the last remaining marble and the computer loses 
                         *      
                         *      Note: The computer cannot take away more than marblesRemaining/2 number of marbles, so it can only take away at 
                         *      most 76/2 marbles = 38. 2^5 = 32, and 76-38 = 38. Therefore, the computer cannot take away enough marbles 
                         *      to reach (2^5)-1. Therefore, the computer must take away only enough to reach the PrevPowerOfTwo. 
                         *  
                         * If computer is playing in easy mode: 
                         * 
                         *  1) Make a random legal move, i.e.: pick a random number between 1 and marblesRemaining/2
                         *  
                         ******************************************************************************************************************/
                        if (marblesRemaining > 1 && isPowerOfTwoMinusOne(marblesRemaining))
                        {
                            // make a random legal move 
                            nimMove = random.Next(1, (marblesRemaining / 2) + 1);
                            marblesRemaining -= nimMove;
                        }
                        else if (marblesRemaining > 1)
                        {
                            /**************************************************
                             * prevPowerOfTwo = FindPrevPowerOfTwo(marblesRemaining);
                             * suppose marblesRemaining = 76, 
                             * FindPrevPowerOfTwo(76) will return => 64
                             * then we subtract 1, to get 63
                             * and our final answer is marblesRemaining - 63
                             * move = marblesRemaining - (prevPowerOfTwo - 1);
                             * move = 76 - (64-1) = 76 - (63) = 13
                             *************************************************/
                            int prevPowerOfTwo;
                            prevPowerOfTwo = FindPrevPowerOfTwo(marblesRemaining);
                            nimMove = marblesRemaining - (prevPowerOfTwo - 1);
                            marblesRemaining -= nimMove;
                        }
                        else if (marblesRemaining == 1)
                        {
                            nimMove = 1;
                            marblesRemaining -= nimMove;
                        }
                    }
                    else if (smartOrStupid == 1)
                    {
                        // make a random legal move 
                        nimMove = random.Next(1, (marblesRemaining / 2) + 1);
                        marblesRemaining -= nimMove;
                    }

                    // displays the number of marbles the computer took 
                    Console.WriteLine("The computer took " + nimMove + " marbles.");

                    // changes the turn 
                    nimTurn = 1;

                    break;
                case 1:

                    // the player's turn 

                    // prompt the user to enter a number 
                    Console.Write("Please enter a number of marbles to take: ");
                    nimMove = int.Parse(Console.ReadLine());

                    // ensure the user enters a number within the valid range 
                    while ((nimMove > (marblesRemaining/2) && marblesRemaining != 1) || nimMove < 1 || ((marblesRemaining == 1) && nimMove > 1))
                    {
                        Console.WriteLine("You've entered an invalid number of marbles.\n");
                        Console.Write("Please enter a number between 1 and half the amount of remaining marbles: ");
                        nimMove = int.Parse(Console.ReadLine());
                    }

                    // subtracts the marbles from the pile 
                    marblesRemaining -= nimMove; 

                    // changes the turn over to the computer 
                    nimTurn = 0; 

                    break;
                default:
                    break; 
            }

            // display a message 
            msg = "\n";
            msg += (marblesRemaining > 1 || marblesRemaining == 0) ? "There are " + marblesRemaining + " marbles remaining.\n" : "";
            msg += (marblesRemaining == 1) ? "There is only " + marblesRemaining + " marble remaining.\n" : "";
            msg += (marblesRemaining > 1 && nimTurn == 0) ? "The computer may take up to " + (marblesRemaining / 2) + " of marbles.\n" : "";
            msg += (marblesRemaining > 1 && nimTurn == 1) ? "You may take up to " + (marblesRemaining / 2) + " of marbles.\n" : "";
            msg += (marblesRemaining == 1 && nimTurn == 0) ? "The computer must take the last remaining marble.\n" : "";
            msg += (marblesRemaining == 1 && nimTurn == 1) ? "You must take the last remaining marble.\n" : "";
            Console.WriteLine(msg); 
        }

        // determine the winner 
        // human is loser if current nim Turn = 0 (computer's Turn) and marblesRemaining = 0 
        nimWinner = (marblesRemaining == 0 && nimTurn == 0) ? false : true;

        // append winning message 
        msg = (nimWinner) ? "Congratulations! You are the winner!!\n" : 
            "Sorry, but you took the last marble.\nTherefore, you lose! Please try again.\n"; 

        // print the message 
        Console.Write(msg);

        // keep the application open 
        Console.ReadLine(); 

    }

    // returns whether the marblesRemaining is a power of two minus one or not 
    public static bool isPowerOfTwoMinusOne(int marblesRemaining) 
    {

        // declare local variables 
        bool isPowerOfTwoMinusOne; 
            
        // initialize local variables
        isPowerOfTwoMinusOne = false;

        // determine if the current marblesRemaining is a power of two minus one or not 
        for (int i = 6; i >= 0; i--)
        {
            if (marblesRemaining == (Math.Pow(2, i) - 1))
            {
                isPowerOfTwoMinusOne = true;
                break; 
            }
        }

        // returns the answer 
        return isPowerOfTwoMinusOne;
    } 

    // returns the previous power of two from marblesRemaining 
    // i.e.: returns 2^6 = 64 <-- 76 marbles remaining 
    // i.e.: returns 2^5 = 32 <-- 56 marbles remaining 
    // i.e.: returns 2^4 = 16 <-- 23 marbles remaining 
    public static int FindPrevPowerOfTwo(int marblesRemaining)
    {
        
        // declare local variables 
        int prevPowerOfTwo;

        // initialize local variables 
        prevPowerOfTwo = -1; 

        // finds the previous power of two 
        for (int i = 6; i >= 0; i--)
        {
            if (Math.Pow(2, i) <= marblesRemaining)
            {
                prevPowerOfTwo = (int)Math.Pow(2, i);
                break; 
            }
        }

        // returns the previous power of two 
        return prevPowerOfTwo;
    }

}
