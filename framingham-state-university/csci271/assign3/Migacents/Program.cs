/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/20/2023 
 * Filename: Migacents.cs 
 * Description: 
 * 
 * Write a C# program “Running a lottery for migacents”, with a price of $4000.00: 
 * 
 *  Start with an empty bag. 
 *  Each ticket is represented by an integer, with its range being determined by the programmer. 
 *  One ticket number may be purchased multiple times. 
 *  For each ticket purchased, put an item in the bag. 
 *  Don't grab if not tickets purchased. 
 *  The odds should be determined before the sale. 
 *  The winning number should be randomly picked up in the number range announced before the sale. 
 *  Use a special number (e.g. –1) as the indication of the end of the sales. 
 *  The winner’s number should be announced, as well as the number of winners, and the price for each winner. If there is no winner, an announcement, which include the 
 *  message “the price will be roll over to next round”, should also be made. 
 *  
 * Please test your program to make sure that there are winners in some cases. Remember also to print the range of numbers and other information for the purchasers. 
********************************************************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        IntArrayBag bag;
        List<int> winners;
        Random r = new Random();
        int minNumber, maxNumber, rounds;
        int ticket, sales, winningNumber, ticketPrice; 

        // initialize local variables 
        sales = ticket = rounds = 0;
        winners = new List<int>();
        bag = new IntArrayBag();

        // display welcome message 
        Console.WriteLine("Migacents Lottery");
        Console.WriteLine(); 

        // prompt the user to enter the ticket price 
        Console.Write("Please enter the price per ticket: "); 
        ticketPrice = int.Parse(Console.ReadLine());

        // prompt the user to enter the minimum ticket number 
        Console.Write("Please enter the minimum ticket number: ");
        minNumber = int.Parse(Console.ReadLine());

        // prompt the user to enter the maximum ticket number 
        Console.Write("Please enter the maximum ticket number: ");
        maxNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(); 

        // begin Migacents 
        while (winners.Count == 0)
        {

            // begin sales 
            while (ticket != -1)
            {
                Console.Write("Please enter a ticket number between " + minNumber + "-" + maxNumber + " (-1 to end sales): ");
                ticket = int.Parse(Console.ReadLine());
                if ((ticket >= minNumber) && (ticket <= maxNumber))
                {
                    sales += ticketPrice;
                    bag.Add(ticket);
                }
                else if (((ticket < minNumber) && (ticket != -1)) || (ticket > maxNumber))
                {
                    Console.WriteLine();
                    Console.Write("Sorry, but you've enterd an invalid ticket number that is not within the valid range of tickets.");
                    Console.WriteLine();
                }
            }

            // generate the winning number 
            winningNumber = r.Next(minNumber, maxNumber + 1);

            // search the Bag for the winners 
            winners = bag.FindTarget(winningNumber);

            // display "there are no winners" message 
            if (winners.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, but there are no winners! Please try again.");
                Console.WriteLine("The sales will be roll over to next round.");
                Console.WriteLine("The winning number was: " + winningNumber);
                Console.WriteLine("Total number of sales rolling over onto the next round: " + sales);
                Console.WriteLine();
            }

            // empty the Bag of tickets for the next round 
            bag.EmptyBag();

            // increment the round 
            rounds++;

            // reset ticket number 
            ticket = 0; 

        }

        // display the number of winners 
        Console.WriteLine(); 
        Console.WriteLine("The number of winners: " + winners.Count);

        // display the total number of rounds taken 
        Console.WriteLine("Total number of rounds: " + rounds);

        // display the total winnings 
        Console.WriteLine("Total winnings: " + sales); 

        // display the total earnings per winner 
        Console.WriteLine("Earnings per winner: " + (sales/winners.Count)); 
        Console.ReadLine(); 

    }

}
