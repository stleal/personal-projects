/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/04/2023 
 * Filename: MakeChange.cs 
 * Description: Write a program called MakeChange that prompts the user for the price of a purchase 
 * in cents (assume the price is always less than a dollar) the program displays the amount of the 
 * change when the user pays with a dollar bill, and then gives the number of quarters, dimes, nickels, 
 * and pennies that make up the change amount. Hint: use integer divide and modulo operations.
********************************************************************************************/
public class Program
{

    // global constants 
    public const int DOLLAR_VALUE = 100, QUARTER_VALUE = 25, NICKLE_VALUE = 10, DIME_VALUE = 5, PENNY_VALUE = 1;

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
            Console.Write("Please enter a purchase price less than 100 pennies. (88 = eighty eight pennies): ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            // makes change and displays the result 
            MakeChange(int.Parse(input));

        }

    }

    // makes change and prints the result 
    public static void MakeChange(int purchasePrice)
    {

        // declare local variables 
        int changeDue, i;
        int[] coins; 

        // initialize local variables 
        i = changeDue = 100 - purchasePrice;

        // coins[0] => dollars, coins[1] => quarters,
        // coins[2] => nickles, coins[3] => dimes, coins[4] => pennies 
        coins = new int[5]; 

        // Get dollar coins, then find remainder of change due
        if (i != 0)
        {
            coins[0]= i / DOLLAR_VALUE;
            i = i % DOLLAR_VALUE;
        }

        // Get quarters, then find remainder of change due
        if (i != 0)
        {
            coins[1] = i / QUARTER_VALUE;
            i = i % QUARTER_VALUE;
        }

        // Get nickles, then find remainder of change due
        if (i != 0)
        {
            coins[2] = i / NICKLE_VALUE;
            i = i % NICKLE_VALUE;
        }

        // Get dimes, then find remainder of change due
        if (i != 0)
        {
            coins[3] = i / DIME_VALUE;
            i = i % DIME_VALUE;
        }

        // Get pennies, then find remainder of change due
        if (i != 0)
        {
            coins[4] = i / PENNY_VALUE;
        }

        // print output 
        Console.WriteLine("Dollar coins: " + coins[0]);
        Console.WriteLine("Quarters: " + coins[1]);
        Console.WriteLine("Nicles: " + coins[2]);
        Console.WriteLine("Dimes: " + coins[3]);
        Console.WriteLine("Pennies: " + coins[4]);

    }

}
