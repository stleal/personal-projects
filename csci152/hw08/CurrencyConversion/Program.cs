/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/05/2023 
 * Filename: CurrencyConversion.cs 
 * Description: Write a program that first asks the user to type today's price for one dollar in 
 * Brazilian reals, then reads U.S. dollar values and converts each to real. Use 0 as sentinel. 
********************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string input;
        double exchangeRate; 

        // initialize variables 
        input = string.Empty;

        // prompts the user to enter today's price for one dollar in BRL 
        Console.Write("Please enter today's exchange rate for one dollar in Brazilian reals: "); 
        exchangeRate = Convert.ToDouble(Console.ReadLine());

        // infinite loop  
        while (input != "exit" && input != "stop")
        {

            // get input from the user 
            Console.Write("Please enter a U.S. dollar value: ");
            input = Console.ReadLine();

            // stop the application 
            if (input == "exit" || input == "stop")
                break;

            try
            {

                // converts a U.S. dollar value into BRL 
                ConvertFromUSDToBRL(Convert.ToDouble(input), exchangeRate);

            }
            catch(Exception ex)
            {
                
                // displays the error message in the console 
                Console.WriteLine(ex.ToString()); 

            }
                
        }

    }

    // converts a U.S. dollar value into BRL 
    public static void ConvertFromUSDToBRL(double usdValue, double exchangeRate)
    {

        // declare local variables 
        double answer;

        // converts the USD value into BRL 
        answer = usdValue * exchangeRate;

        // returns the answer 
        Console.WriteLine(usdValue + " U.S. dollars = " + answer + " Brazilian reals (BRL)"); 

    }

} 
