/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/06/2023 
 * Filename: ArrayExercises.cs 
 * Description: Write a program called ArrayEquals to test your equals() method: this program repeatedly 
 * asks the user to enter (a) a positive integer between 1 and 10 (inclusive) which is the length of the 
 * two arrays you’ll be comparing, (b) a series of integers which are the contents of the first array, and 
 * then (c) a series of integers which are the contents of the second array. Your program creates the two 
 * arrays, calls your equals() method to see if the two arrays have the same elements in the same order, 
 * and then displays “The arrays are the same” if they do and “The arrays are different” if they don’t. 
*********************************************************************************************/
public class Program
{
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] a, b; 
        string input; 
        string[] nums;

        // initialize local variables 
        input = string.Empty; 

        // infinite loop  
        while (input != "exit" && input != "stop")
        {

            // get input from the user 
            Console.Write("Please enter the length of the two arrays (an integer number between 1-10): ");
            input = Console.ReadLine();

            // initialize the two arrays 
            a = new int[int.Parse(input)]; 
            b = new int[int.Parse(input)];

            // get input from the user 
            Console.Write("Please enter " + a.Length + " integers for the first array (separated by a space): ");
            input = Console.ReadLine();
            nums = input.Split(" "); 
            for (int i = 0; i < nums.Length; i++)
            {
                a[i] = int.Parse(nums[i]); 
            }

            // get input from the user 
            Console.Write("Please enter " + b.Length + " integers for the second array (separated by a space): ");
            input = Console.ReadLine();
            nums = input.Split(" ");
            for (int i = 0; i < nums.Length; i++)
            {
                b[i] = int.Parse(nums[i]);
            }

            // prints whether the two arrays are equal or not 
            Console.WriteLine(Equals(a, b)); 

        }

    }

    // returns whether the two arrays are equal or not 
    public static string Equals(int[] a, int[] b)
    {

        // declare local variables 
        string message;

        // initialize local variables 
        message = "The arrays are the same"; 

        // compares the two arrays 
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                message = "The arrays are different";
                break;
            }
        }

        // returns the message 
        return message; 

    }

}
