public class SortAscending
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        Stack unsortedStack, sortedStack; 

        // initialize variables 
        unsortedStack = new Stack(); 

        // prompt the user 
        Console.WriteLine("Please enter four numbers, one on each line."); 

        // get user input 
        for (int i = 0; i < 4; i++)
        {
            unsortedStack.Push(int.Parse(Console.ReadLine())); 
        }

        // sorts the Stack in ascending order 
        sortedStack = SortStackAscending(unsortedStack);
        Console.WriteLine("Sorted Ascending: "); 

        // print the stack 
        sortedStack.Print();

        // re-push onto the stack
        for (int i = 0; i < 4; i++)
        {
            unsortedStack.Push(int.Parse(Console.ReadLine()));
        }

        // sorts the Stack in descending order 
        sortedStack = SortStackDescending(unsortedStack);
        Console.WriteLine("Sorted Descending: ");

        // print the stack 
        sortedStack.Print();
        Console.ReadLine();

    }

    // sorts the stack in ascending order 
    public static Stack SortStackAscending(Stack unsortedStack)
    {

        // declare local variables 
        Stack sortedStack;
        int[] unsortedArray;
        int local; 

        // initialize local variables 
        sortedStack = new Stack();
        unsortedArray = new int[unsortedStack.GetSize()]; 

        // copy the contents of the unsorted stack into an array 
        for (int i = 0; i < unsortedStack.GetCapacity(); i++)
        {
            unsortedArray[i] = unsortedStack.Pop(); 
        }

        // Bubble sort 
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            for (int j = 0; j < unsortedArray.Length-1; j++)
            {
                if (unsortedArray[i] < unsortedArray[j])
                {
                    // swaps values 
                    local = unsortedArray[i]; 
                    unsortedArray[i] = unsortedArray[j];
                    unsortedArray[j] = local; 
                }
            }
        }

        // push the sorted array into the sorted Stack 
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            sortedStack.Push(unsortedArray[i]); 
        }

        // returns a sorted Stack 
        return sortedStack; 

    }

    // sorts the stack in ascending order 
    public static Stack SortStackDescending(Stack unsortedStack)
    {

        // declare local variables 
        Stack sortedStack;
        int[] unsortedArray;
        int local;

        // initialize local variables 
        sortedStack = new Stack();
        unsortedArray = new int[unsortedStack.GetSize()];

        // copy the contents of the unsorted stack into an array 
        for (int i = 0; i < unsortedStack.GetCapacity(); i++)
        {
            unsortedArray[i] = unsortedStack.Pop();
        }

        // Bubble sort 
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            for (int j = 0; j < unsortedArray.Length - 1; j++)
            {
                if (unsortedArray[i] > unsortedArray[j])
                {
                    // swaps values 
                    local = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[j];
                    unsortedArray[j] = local;
                }
            }
        }

        // push the sorted array into the sorted Stack 
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            sortedStack.Push(unsortedArray[i]);
        }

        // returns a sorted Stack 
        return sortedStack;

    }

}