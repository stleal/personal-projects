/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/07/2023 
 * Filename: Bug.cs 
 * Description: Write a class Bug that models a bug moving along a horizontal line. The bug 
 * moves either to the right or left. Initially, the bug moves to the right, but it can turn 
 * to change its direction. In each move, its position changes by one unit in the current 
 * direction. Provide a constructor: 
 *      public Bug(int initialPosition)
 * and methods:      
 *      public void turn() 
 *      public void move() 
 *      public int getPosition() 
 *  Sample usage: 
 *      Bug bugsy = new Bug(10); 
 *      bugsy.move(); // Now the position is 11 
 *      bugsy.turn(); 
 *      bugsy.move() // Now the position is 10 
 *  Your main method should construct a bug, make it move and turn a few times, and print the 
 *  actual and expected positions. 
*********************************************************************************************/
public class Program
{

    public static void Main(string[] args)
    {

        // declare local variables 
        int i;
        char cmd;
        Bug[] bugs;
        string input;

        // initialize local variables 
        i = -1; 
        bugs = new Bug[5];
        input = string.Empty;
        
        // infinite loop 
        while (input != "x")
        {

            // prompt the user 
            Console.WriteLine("Please enter a command: ci, ti, mi, or gi, where i is a number 1-5. X to exit."); 

            // get input from the user 
            input = Console.ReadLine().ToLower(); 

            // parse the cmd 
            cmd = input.ElementAt(0);

            // parse the Bug Id 
            if (input.Length > 1)
                i = int.Parse(input.ElementAt(1).ToString()); 

            // execute the command 
            switch(cmd)
            {
                case 'x': 
                    Environment.Exit(0);
                    break;
                case 'c':
                    bugs[i] = new Bug();
                    Console.WriteLine("Successfully created Bug[" + i + "]"); 
                    break;
                case 't':
                    bugs[i].Turn();
                    Console.WriteLine("Successfully turned Bug[" + i + "]"); 
                    break;
                case 'm':
                    bugs[i].Move();
                    Console.WriteLine("Successfully moved Bug[" + i + "]"); 
                    break;
                case 'g':
                    Console.WriteLine("Position of Bug[" + i + "]: " + bugs[i].GetPosition()); 
                    break;
                default:
                    break; 
            }

        }

    }

}
