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
public class IntArray : IncArray
{

    // global variables 
    private int[] _data;

    // additional constructor 
    public IntArray(int[] data)
    {
        _data = data;
    }

    // override ToString method here
    public override string ToString()
    {

        // declare local variables 
        string message;

        // initialize local variables 
        message = string.Empty; 

        // appends the array to the message 
        for (int i = 0; i < _data.Length; i++)
        {
            message += "data[" + i + "]: " + _data[i] + "\n"; 
        }

        // return message 
        return message; 

    }

    // sorts the array 
    public void Sort()
    {

        // declare local variables 
        int i, j, temp;

        // Bubble sort 
        for (i = 0; i < _data.Length - 1; i++)
        {
            for (j = i + 1; j < _data.Length; j++)
            {
                if (OutOfOrder(_data[i], _data[j]))
                {
                    temp = _data[i];
                    _data[i] = _data[j];
                    _data[j] = temp;
                }
            }
        }

    }

}
