/*******************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 09/10/2023 
 * Filename: MergeSimilarItems.cs 
 * Description: You are given two 2D integer arrays, items1 and items2, representing two sets of items. 
 * Each array items has the following properties: 
 * 
 *   items[i] = [valuei, weighti] where valuei represents the value and weighti represents the weight of the ith item. 
 *   The value of each item in items is unique. 
 *   
 * Return a 2D integer array ret where ret[i] = [valuei, weighti], with weighti being the sum of weights of all items with value valuei. 
 * Note: ret should be returned in ascending order by value.
 *  
 * Example 1: 
 * Input: items1 = [[1,1],[4,5],[3,8]], items2 = [[3,1],[1,5]] 
 * Output: [[1,6],[3,9],[4,5]] 
 * 
 * Explanation:  
 * The item with value = 1 occurs in items1 with weight = 1 and in items2 with weight = 5, total weight = 1 + 5 = 6. 
 * The item with value = 3 occurs in items1 with weight = 8 and in items2 with weight = 1, total weight = 8 + 1 = 9. 
 * The item with value = 4 occurs in items1 with weight = 5, total weight = 5.   
 * Therefore, we return [[1,6],[3,9],[4,5]]. 
*******************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[,] items1, items2;
        Random r = new Random();

        // initialize local variables 
        r = new Random();

        // example 1
        items1 = new int[,] { { 1, 1 }, { 4, 5 }, { 3, 8 } };
        items2 = new int[,] { { 3, 1 }, { 1, 5 } };
        MergeSimilarItems(items1 , items2);

        // example 2 
        items1 = new int[,] { { 1, 2 }, { 3, 3 }, { 5, 1 }, { 7, 3 } };
        items2 = new int[,] { { 2, 1 }, { 4, 4 }, { 6, 2 }, { 8, 4 } };
        MergeSimilarItems(items1, items2);

        // example 3
        items1 = new int[,] { { 1, 2 }, { 2, 3 }, { 3, 1 }, { 4, 3 } };
        items2 = new int[,] { { 1, 1 }, { 2, 4 }, { 3, 2 }, { 4, 6 } };
        MergeSimilarItems(items1, items2);

        // example 4 
        // create two 2D integer arrays with a random size between 1-8 
        items1 = new int[r.Next(1, 9), 2];
        items2 = new int[r.Next(1, 9), 2];

        // fill the first 2D integer array 
        Fill2DIntArray(items1, 0, 16);

        // fill the second 2D integer array 
        Fill2DIntArray(items2, 0, 16); 

        // merge items1 and items2 into ret 
        MergeSimilarItems(items1, items2);

        // example 5 
        // create two 2D integer arrays with a random size between 1-8 
        items1 = new int[r.Next(1, 9), 2];
        items2 = new int[r.Next(1, 9), 2];

        // fill the first 2D integer array 
        Fill2DIntArray(items1, 0, 16);

        // fill the second 2D integer array 
        Fill2DIntArray(items2, 0, 32);

        // merge items1 and items2 into ret 
        MergeSimilarItems(items1, items2);

    }

    // merge similar items 
    public static void MergeSimilarItems(int[,] items1, int[,] items2)
    {

        // declare local variables 
        int size;
        int[,] ret;
        List<int> uniqueElements;

        // initialize local variables 
        uniqueElements = new List<int>();

        // determines the size of ret 
        size = GetNumberOfUniqueElements(items1, items2); 

        // initialize ret 
        ret = new int[size, 2];

        // merge two 2D integer arrays into ret 
        Merge(items1, items2, ret); 

        // Sort ret 
        Sort2DIntArray(ret);

        // Print array 
        Console.WriteLine("Items 1: "); 
        Print2DIntArray(items1, "items1");
        Console.WriteLine(); 

        // Print array 
        Console.WriteLine("Items 2: "); 
        Print2DIntArray(items2, "items2");
        Console.WriteLine();

        // Print array 
        Console.WriteLine("Ret: ");
        Print2DIntArray(ret, "ret");
        Console.WriteLine();

    }

    // merges two 2D integer arrays into ret 
    public static void Merge(int[,] items1, int[,] items2, int[,] ret)
    {

        // declare local variables 
        int sum, count; 
        List<int> uniqueElements;

        // initialize local variables  
        sum = count = 0; 
        uniqueElements = new List<int>(); 

        // loop through both arrays and get the sum 
        for (int i = 0; i < items1.GetLength(0); i++)
        {

            // only if the uniqueElements List<int> does not already contain the current value 
            if (!uniqueElements.Contains(items1[i, 0]))
            {

                // add the current value to the List<int>, so that we don't repeat it again 
                uniqueElements.Add(items1[i, 0]);

                // get the value from the first items 2d array 
                sum += items1[i, 1];

                // search for the same value in the second item array 
                for (int j = 0; j < items2.GetLength(0); j++)
                {

                    // if it is a matching value 
                    if (items1[i, 0] == items2[j, 0])
                    {

                        // add the weight to the sum 
                        sum += items2[j, 1];
                        break;

                    }

                }

                // adds the sum to the new array 
                ret[count, 0] = items1[i, 0];
                ret[count, 1] = sum;

                // increase count by 1 
                count++;

                // reset sum 
                sum = 0;

            }

        }

        // get the weights of the remaining elements by looping through the second 2d array
        for (int i = 0; i < items2.GetLength(0); i++)
        {

            // only if the uniqueElements List<int> does not already contain the current value 
            if (!uniqueElements.Contains(items2[i, 0]))
            {

                // add the current value to the List<int>, so that we don't repeat it again 
                uniqueElements.Add(items2[i, 0]);

                // get the value from the first items 2d array 
                sum += items2[i, 1];

                // adds the sum to the new array 
                ret[count, 0] = items2[i, 0];
                ret[count, 1] = sum;

                // increase count by 1 
                count++;

                // reset sum 
                sum = 0;

            }

        }

    }

    // returns the number of unique elements in the two 2D integer arrays  
    public static int GetNumberOfUniqueElements(int[,] items1, int[,] items2)
    {

        // declare local variables 
        List<int> uniqueElements;

        // initialize local variables 
        uniqueElements = new List<int>();

        // adds only the unique elements into a List<int> 
        for (int i = 0; i < items1.GetLength(0); i++)
        {
            if (!uniqueElements.Contains(items1[i, 0]))
            {
                uniqueElements.Add(items1[i, 0]);
            }
        }

        // adds only the unique elements into a List<int> 
        for (int i = 0; i < items2.GetLength(0); i++)
        {
            if (!uniqueElements.Contains(items2[i, 0]))
            {
                uniqueElements.Add(items2[i, 0]);
            }
        }

        // returns the count of unique elements 
        return uniqueElements.Count;

    }

    // sorts the 2D integer array 
    public static void Sort2DIntArray(int[,] arr)
    {
        int[,] swap;
        swap = new int[1, 2];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(0) - 1; j++)
            {
                if (arr[i, 0] < arr[j, 0])
                {
                    swap[0, 0] = arr[i, 0];
                    swap[0, 1] = arr[i, 1];
                    arr[i, 0] = arr[j, 0];
                    arr[i, 1] = arr[j, 1];
                    arr[j, 0] = swap[0, 0];
                    arr[j, 1] = swap[0, 1];
                }
            }
        }
    }

    // prints a 2D integer array 
    public static void Print2DIntArray(int[,] arr, string arrName)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine(arrName + "[" + i + ", " + j + "] = " + arr[i, j]);
            }
        }
    }

    // fills a 2D integer array with random numbers 
    public static void Fill2DIntArray(int[,] arr, int minValue, int maxValue)
    {

        // declare local variables 
        bool flag;
        Random r = new Random();
        List<int> duplicateElements;

        // initialize local variables 
        flag = false;
        r = new Random();
        duplicateElements = new List<int>();

        // ensure no duplicates 
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                while (!flag)
                {
                    arr[i, j] = r.Next(minValue, maxValue + 1);
                    if (!duplicateElements.Contains(arr[i, j]))
                    {
                        duplicateElements.Add(arr[i, j]);
                        flag = true;
                    }
                }
                flag = false;
            }
        }

    }

}
