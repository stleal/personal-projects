/************************************************************************
*
*	Carry out Programming Exercise 3.2 of the book.
*	Call your program FloatCompZero.
*
*	Write a program that reads a floating-point number and
*	prints "zero" if the number is zero. Otherwise, print "positive"
*	or "nevative". Add "small" if the absolute value of the number
*	is less than 1, or "large" if it exceeds 1,000,000.
*	it is negative, zero, or postive.
*
*	NAME: SAMIR LEAL
*	DATE: 3/11/2013
*	PROFESSOR: BOB CHEN @ 8:30AM M W
*
************************************************************************/
public class FloatCompZero
{

    // global constants 
    private const string TYPE_NEGATIVE = "negative";
    private const string TYPE_SMALL = "small";
    private const string TYPE_ZERO = "zero";
    private const string TYPE_POSITIVE = "positive";
    private const string TYPE_LARGE = "large";

    public static void Main(String[] args)
    {
        Solution();
    }

    public static void Solution()
    {

        // local variables  
        string type = string.Empty;

        // prompt the user 
        Console.Write("Please enter a floating type number: ");

        // parse the input from user 
        float number = float.Parse(Console.ReadLine());

        // determine the type of the number 
        if (number < 0)
        {
            type = TYPE_NEGATIVE;
        }
        else if (number == 0)
        {
            type = TYPE_ZERO;
        }
        else if (number > 0)
        {
            type = TYPE_POSITIVE;
        }

        // determine the size of the number 
        if (number < 1 && number > 0 || number > -1 && number < 0)
        {
            type = type + " and " + TYPE_SMALL;
        }
        else if (number >= 1000000 || number <= -1000000)
        {
            type = type + " and " + TYPE_LARGE;
        }

        // print the result 
        Console.WriteLine(type);

    }

}