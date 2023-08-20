/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/07/2023 
 * Filename: IntArrayTester.cs 
 * Description: Write a program extending a class IntArray, to an extended class IncArray. 
 * You should write an extended class IncArray in which the increasing order is the right order; 
 * i.e. outOfOrder(3, 5) is false; outOfOrder(5, 3) is true. Also override the toString method so 
 * you can convert the array on terminal. You must write an application part to test your program as 
 * explained in class.
*********************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // unsorted array 
        int[] data = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        IntArray tester = new IntArray(data);
        tester = new IntArray(data);
        tester.Sort();
        Console.WriteLine(tester.ToString());

        // sorted array 
        data = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
        tester = new IntArray(data);
        tester.Sort();
        Console.WriteLine(tester.ToString()); 

        // keep the application running 
        Console.ReadLine(); 

    }

}