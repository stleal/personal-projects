/*******************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/07/2023 
 * Filename: PayCheckTester.cs 
 * Description: In this program assignment, you will construct a class PayCheck. Your program will be used to print paychecks 
 * for a group of student assistants. 
 * 
 * Your class should contain at least the following: 
 * 
 *      a) Three variables to represent the name, the hourly wage and hours worked. 
 *      b) A method to deduct the federal and social security taxes. ( find about social security tax on the Internet.) 
 *         For simplicity, you may assume that both the federal and social security taxes use fixed rates. 
 *      c) A method to print a paycheck in certain format. 
 *      d) Static variables contain information like school name, tax rate, and/or other object-independent values. 
 *      
 * You should supply a main method (in the same OR different class) to test your program.  
 * 
 * The name, hourly wages and hours worked should be input to the program (standard input or command line argument), 
 * and the tax rates might be built-in values. 
********************************************************************************************************************************/
public class Program
{

    public static void Main(string[] args)
    {

        // declare local variables 
        PayCheck p; 
        string input; 
        bool running; 
        int hoursWorked;
        double hourlyWages;
        string name, schoolName;

        // initialize local variables 
        running = true;

        // display a welcome message 
        Console.WriteLine("PayCheck Tester for Student Assistants\n");

        // infinite loop 
        while (running)
        {

            // prompt the user for the student assistant's name 
            Console.Write("Please enter the student assistant's name: ");

            // get input from the user 
            input = Console.ReadLine();

            // check input 
            if (input == "exit" || input == "stop" || input == "")
                break;

            // save the name 
            name = input;

            // prompt the user for the student assistant's school name  
            Console.Write("Please enter the student assistant's school name: ");

            // get input from the user 
            input = Console.ReadLine();

            // check input 
            if (input == "exit" || input == "stop" || input == "")
                break;

            // save the name 
            schoolName = input;

            // prompt the user for the student assistant's hourly wages 
            Console.Write("Please enter the student assistant's hourly wages: ");

            // get input from the user 
            input = Console.ReadLine();

            // check input 
            if (input == "exit" || input == "stop" || input == "")
                break;

            // save the hourly wages 
            hourlyWages = Double.Parse(input);

            // prompt the user for the student assistant's hours worked  
            Console.Write("Please enter the student assistant's hours worked: ");

            // get input from the user 
            input = Console.ReadLine();

            // check input 
            if (input == "exit" || input == "stop" || input == "")
                break;

            // save the hours worked 
            hoursWorked = int.Parse(input);

            // print the paycheck 
            p = new PayCheck(name, schoolName, hourlyWages, hoursWorked); 
            p.PrintPayCheck();

        }

    }

}
