/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/05/2023 
 * Filename: Balance.cs 
 * Description: Write a method that computes the balance of a bank account with a given initial 
 * balance and interest rate, after a given number of years. Assume interest is compounded yearly. 
********************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        double p, r, a, t;

        // prompt the user for the starting balance 
        Console.Write("Please enter a starting balance: ");
        p = Convert.ToDouble(Console.ReadLine());

        // prompt the user for the interest rate 
        Console.Write("Please enter the interest rate: ");
        r = Convert.ToDouble(Console.ReadLine());

        // prompt the user for the number of years 
        Console.Write("Please enter the number of years: ");
        t = Convert.ToDouble(Console.ReadLine());

        // computes the ending Balance 
        a = ComputeBalance(p, r, t); 

        // prints the ending Balance 
        Console.WriteLine("The ending balance of the account after " + t + " years, is: " + a);

    }

    // computes the ending Balance of the account 
    // where p = the principal amount / starting balance 
    // where t = time in decimal years, i.e.: 6 months is calculated as 0.5 years, 12 months = 1
    public static double ComputeBalance(double p, double apr, double t)
    {

        // declare local variables 
        int n; // number of compounding periods per unit of time 
        double a; // the accrued amount (principal + interest) 
        double r; // the interest rate as a decimal (apr/100) 

        // initialize local variables 
        n = 1; // number of compounding periods per unit of time 
        r = apr/100; // the interest rate as a decimal (apr/100) 

        // compute the ending balance 
        a = p * Math.Pow((1 + (r/n)), (n*t)); 

        // returns the ending Balance  
        return a;

    }

}
