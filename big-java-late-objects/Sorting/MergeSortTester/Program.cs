/*************************************************************************
 * Name: Sam Leal 
 * Date: 09/01/2023 
 * Filename: MergeSortTester.cs 
 * Description: Sorts an array of integers from smallest to largest 
*************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        Random r; 
        int[] data;

        // initialize local variables 
        r = new Random(); 
        data = new int[8];     

        // inserts random numbers into the data array 
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = r.Next(0, 128); 
        }

        // prints the unsorted array 
        PrintArray(data); 

        // sorts the array 
        MergeSort(data, 0, data.Length);

        // prints the sorted array 
        PrintArray(data);
        Console.ReadLine(); 

    }

    // sorts an array from smallest to largest 
    public static void MergeSort(int[] data, int first, int n)
    {

        // declare local variables 
        int n1, n2;

        if (n > 1)
        {

            // compute sizes of the two halves 
            n1 = n / 2;
            n2 = n - n1;

            // recursive call to the MergeSort algorithm 
            MergeSort(data, first, n1);
            MergeSort(data, first + n1, n2);

            // merge the two sorted halves 
            Merge(data, first, n1, n2); 

        }

    }

    // merges two halves from smallest to largest 
    public static void Merge(int[] data, int first, int n1, int n2)
    {

        // declare local variables 
        int[] local; 
        int counter, leftCounter, rightCounter;

        // initialize local variables 
        local = new int[n1 + n2];
        counter = leftCounter = rightCounter = 0; 

        // merge elements 
        while ((leftCounter < n1) && (rightCounter < n2))
        {
            if (data[first + leftCounter] < data[first + n1 + rightCounter])
            {
                local[counter++] = data[first + (leftCounter++)]; 
            } 
            else
            {
                local[counter++] = data[first + n1 + (rightCounter++)]; 
            }
        }

        // copy all the remaining elements 
        while (leftCounter < n1)
        {
            local[counter++] = data[first + (leftCounter++)]; 
        }

        // copy the sorted array back into data 
        for (int i = 0; i < counter; i++)
        {
            data[first + i] = local[i]; 
        }

    }

    // prints the array 
    public static void PrintArray(int[] data)
    {

        // declare local variables 
        string msg;

        // intialize local variables 
        msg = string.Empty; 

        // appends each element to the msg
        for (int i = 0; i < data.Length; i++)
        {
            msg += data[i] + ", "; 
        }

        // removes the trailing ", " 
        msg = msg.Substring(0, msg.Length - 2); 

        // prints the array 
        Console.WriteLine(msg + "\n"); 

    }

}
