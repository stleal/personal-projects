public class Stack
{

    // global variables 
    private int _top;
    private int _capacity;
    private int[] _data; 

    // default constructor 
    public Stack()
    {
        _top = 0;
        _capacity = 1;
        _data = new int[_capacity]; 
    }

    // gets the top-most item from the stack 
    public int Peek()
    {
        return _data[_capacity-1]; 
    }

    // removes an item from the stack 
    public int Pop()
    {
        return _data[--_top];
    }

    // pushes an element onto the stack 
    public void Push(int target)
    {
        /******************************************************
        * If top is equal to capacity
        *   1. Make new array that is bigger
        *   2. Copy data from data array to temp array
        *   3. Change data reference to new location
        * Else add target into data array then increment top
        ******************************************************/
        if (_top == _capacity)
        {
            _capacity *= 2;
            int[] local = new int[_capacity]; 
            for (int i = 0; i < _top; i++)
            {
                local[i] = _data[i]; 
            }
            local[_top++] = target;
            _data = local; 
        }
        else
        {
            _data[_top++] = target;
        }
    }

    // returns the capacity of the Stack 
    public int GetCapacity()
    {
        return _capacity; 
    }

    // gets the size of the stack 
    public int GetSize()
    {
        return _top; 
    }

    // returns whether the stack is empty or not 
    public bool IsEmpty()
    {
        return _top == 0; 
    }

    // prints the stack 
    public void Print()
    {
        for (int i = 0; i < GetCapacity(); i++)
        {
            Console.WriteLine(Pop()); 
        }
    }

}
