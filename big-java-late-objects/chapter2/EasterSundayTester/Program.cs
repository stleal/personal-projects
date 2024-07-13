/*********************************************************************************************************************
 * Name: Sam Leal
 * Date: 08/12/2023
 * Filename: EasterSundayTester.cs
 * Description: Easter Sunday is the first sunday after the first full moon of spring. To compute the date, you can
 * use this algorithm, invented by the mathematician Carl Friedrich Gauss in 1800.
*********************************************************************************************************************/
public class Program
{

    // main
    public static void Main(string[] args)
    {

        // declare local variables
        int year;
        Tuple<int, int> date;

        // initialize local variables
        year = 1994;

        // display the Easter Sunday dates
        while (year <= 2024)
        {

            // compute the date
            date = ComputeEasterSundayDate(year);

            // display the date
            Console.WriteLine("Easter Sunday falls on " + date.Item2 + "/" + date.Item1 + "/" + year);

            // increment the year
            year++;

        }

        // keep the application running
        Console.ReadLine();

    }

    // computes the date and returns the day, month as a Tuple
    public static Tuple<int, int> ComputeEasterSundayDate(int year)
    {

        // declare local variables
        int a, b, c, d, e, g, h, j, k, m, r, n, p, y;

        // initialize local variables
        y = year;

        // get the remainder of y/19
        a = y % 19;

        // get a quotient b
        b = y / 100;

        // get a remainder c
        c = y % 100;

        // get a quotient d
        d = b / 4;

        // get a remainder e
        e = b % 4;

        // get a quotient g
        g = (8 * b + 13) / 25; // ignore the remainder

        // get a remainder h
        h = (19 * a + b - d - g + 15) % 30; // ignore the quotient

        // get a quotient j
        j = c / 4;

        // get a remainder k
        k = c % 4;

        // get a quotient m
        m = (a + 11 * h) / 319; // ignore the quotient

        // get a remainder r
        r = (2 * e + 2 * j - k - h + m + 32) % 7;  // ignore the quotient

        // get a quotient n
        n = (h - m + r + 90) / 25; // ignore the remainder

        // get a remainder p
        p = (h - m + r + n + 19) % 32; // ignore the quotient

        // returns a new Tuple, where p = the day, and n = the month
        return new Tuple<int, int>(p, n); // Easter Sunday falls on year y

    }

}
