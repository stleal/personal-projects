using Packages;
using Sandbox.CS1;

public class Program
{

    // global variables 
    private static Calculator calculator = new Calculator();
    private static TwoSum twoSum = new TwoSum();
    private static FloatCompZero floatCompZero = new FloatCompZero();

    public static void Main(String[] args)
    {

        // declare variables 
        string userInput = string.Empty;

        // loop forever until exit 
        while (userInput.ToLower() != "exit")
        {

            // prompt user for input 
            Console.WriteLine("Please enter a package name to run: ");
            Console.WriteLine("For example, some of the available options are: TwoSum.cs, and Calculator.cs");

            // get input from the user 
            userInput = Console.ReadLine().ToLower();
            string[] arguments = userInput.Split(" ");

            // executes a selected program 
            switch (arguments[0])
            {
                case "twosum":
                    twoSum.Run();
                    break;
                case "calculator":
                    calculator.Run(arguments);
                    break;
                case "floatcompzero":
                    floatCompZero.Run(arguments);
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
            }

        }

        //int x = 23; int y = 94;
        //Console.WriteLine(calculator.Add(x, y));
        //Console.WriteLine(calculator.Subtract(x, y));

    }

}
