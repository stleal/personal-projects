/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/20/2023 
 * Filename: Migacents.cs 
 * Description: 
 * 
 * Write a C# program “Running a lottery for migacents”, with a price of $4000.00: 
 * 
 *  Start with an empty bag. 
 *  Each ticket is represented by an integer, with its range being determined by the programmer. 
 *  One ticket number may be purchased multiple times. 
 *  For each ticket purchased, put an item in the bag. 
 *  Don't grab if not tickets purchased. 
 *  The odds should be determined before the sale. 
 *  The winning number should be randomly picked up in the number range announced before the sale. 
 *  Use a special number (e.g. –1) as the indication of the end of the sales. 
 *  The winner’s number should be announced, as well as the number of winners, and the price for each winner. If there is no winner, an announcement, which include the 
 *  message “the price will be roll over to next round”, should also be made. 
 *  
 * Please test your program to make sure that there are winners in some cases. Remember also to print the range of numbers and other information for the purchasers. 
********************************************************************************************************************************************************************/
public class IntArrayBag
{

    // global variables 
    private int[] _data;
    private int _count;
    private int _size;

    // default constructor 
    public IntArrayBag()
    {
        _size = 1; 
        _data = new int[_size];
        _count = 0;
    }

    // constructor 
    public IntArrayBag(int initialCapacity)
    {
        _size = initialCapacity; 
        _data = new int[initialCapacity]; 
        _count = 0;
    }

    // inserts an integer into the Bag 
    public void Add(int n)
    {
        if (_count >= _size)
        {
            EnsureCapacity(); 
        }
        _data[_count] = n; 
        _count++;
    }

    // ensures the capacity of the Bag 
    public void EnsureCapacity()
    {
        int[] local;
        local = new int[(_size * 2)+1]; 
        for (int i = 0; i < _size; i++)
        {
            local[i] = _data[i];
        }
        _data = local;
        _size = local.Length;
    }

    // finds the target element in the Bag 
    public List<int> FindTarget(int target)
    {
        List<int> matches;
        matches = new List<int>(); 
        for (int i = 0; i < _size; i++)
        {
            if (_data[i] == target)
            {
                matches.Add(i); 
            }
        }
        return matches;
    } 

    // empties the Bag
    public void EmptyBag()
    {
        _size = 1; 
        _data = new int[_size]; 
        _count = 0;
    }

}
