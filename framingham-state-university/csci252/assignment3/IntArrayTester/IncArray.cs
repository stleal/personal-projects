/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/07/2023 
 * Filename: IntArrayTester.cs 
 * Description: Write a Java program extending a class IntArray, to an extended class IncArray. 
 * You should write an extended class IncArray in which the increasing order is the right order; 
 * i.e. outOfOrder(3, 5) is false; outOfOrder(5, 3) is true. Also override the toString method so 
 * you can convert the array on terminal. You must write an application part to test your program as 
 * explained in class.
*********************************************************************************************/
public class IncArray
{

    // returns whether or not the two numbers are out of order 
    public bool OutOfOrder(int a, int b)
    {
        return (a > b) ? true : false; 
    }

}
