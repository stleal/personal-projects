/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/05/2023 
 * Filename: OysterBar.cs 
 * Description: You need to control the number of people who can be in an oyster bar at the same time. 
 * Groups of people can always leave the bar, but a group cannot enter the bar if they would make the 
 * number of people in the bar exceed the maximum of 100 occupants. Write a program that reads the sizes
 * of the groups that arrive or depart. Use negative numbers for depatures. After each input, display the 
 * current number of occupants. As soon as the bar holds the maximum number of people, report that the bar 
 * is full and exit the program. 
********************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int numberOfOccupants;

        // initialize local variables 
        numberOfOccupants = 0;

        // infinite loop  
        while (numberOfOccupants < 100)
        {

            // get input from the user 
            Console.Write("Please enter the size of a group that is arriving or departing (use negative numbers for departure): ");
            numberOfOccupants += int.Parse(Console.ReadLine());
            
            // displays the current number of occupants
            Console.WriteLine("Number of occupants: " + numberOfOccupants);

            // stop the application 
            if (numberOfOccupants >= 100)
                break;

        }

    }

}
