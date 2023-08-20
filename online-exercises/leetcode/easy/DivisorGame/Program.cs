/********************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/15/2023 
 * Filename: DivisorGame.cs 
 * Description: Alice and Bob take turns playing a game, with Alice starting first. Initially, there is a number n on the chalkboard. On each 
 * player's turn, that player makes a move consisting of: 
 *      Choosing any x with 0 < x < n and n % x == 0. 
 *      Replacing the number n on the chalkboard with n - x. 
 * Also, if a player cannot make a move, they lose the game. 
 * Return true if and only if Alice wins the game, assuming both players play optimally.
 * Constraints: 
 * 1 <= n <= 1000
********************************************************************************************************************************************/ 
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int n, x; 
        Random r = new Random();
        int playerTurn, gameWinner;

        // initialize local variables 
        x = -1;
        playerTurn = 0; 
        n = r.Next(1, 1001);

        // print the initial value for n 
        Console.WriteLine("Starting value for n: " + n); 

        // loop until n == 0
        while (n > 1)
        {
            switch (playerTurn)
            {
                case 0:

                    // computer's turn (Alice) 
                    while (x <= 0 || n % x != 0 || x >= n)
                    {
                        x = r.Next(0, n);
                    }
                    playerTurn = 1; 
                    break;

                case 1:

                    // player's turn 
                    Console.Write("Please enter a value for x: ");
                    x = int.Parse(Console.ReadLine());
                    while (x <= 0 || n % x != 0 || x >= n)
                    {
                        Console.Write("Sorry, but you entered an invalid value.\nPlease enter a value for x (between 1-(n-1) and n % x == 0): ");
                        x = int.Parse(Console.ReadLine());
                    }
                    playerTurn = 0; 
                    break;

                default:
                    break;
            }
            Console.WriteLine("The value chosen for x: " + x);
            n -= x;
            Console.WriteLine("New value for n: " + n);
            x = -1;
        }

        // if it's the computer's turn, then the player is the winner 
        gameWinner = (playerTurn == 0) ? 1 : 0; 

        // print the game winner 
        if (gameWinner == 0)
        {
            Console.WriteLine("Computer wins!"); 
        }
        else
        {
            Console.WriteLine("Player wins!"); 
        }

        // keep the application running 
        Console.ReadLine(); 

    }

}
