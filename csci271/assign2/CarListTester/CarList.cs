/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/19/2023 
 * Filename: CarListTester.cs 
 * Description: 
 * 
 * Car.cs: 
 * Define a Car class with two instance variables: price (in pennies) and make (for example, "Chevrolet", "Mazda", etc.)
 * Include a standard constructor, plus getPrice, getMake, setPrice and setMake methods. The set methods simply replace the existing values. 
 * The Car class must implement the Comparable interface. Cars are ordered by price, and if several Cars have the same price, then alphabetically by make. 
 * Two cars are considered equal if they have the same price and the same make.
 * 
 * CarList.cs: 
 * Is a linked list class similar to the one we discussed in lectures. Include head and tail pointers, as well as a counter for the number of nodes in the list. 
 * All methods in this class must maintain the list in ascending order according to the Car price. That is, the car with the lowest price is at the beginning of the 
 * list and the highest price is at the tail. The order is unimportant for two or more cars that happen to have the same price. 
 * 
 * Include methods to return: 
 *      (a) the size of the list, 
 *      (b) whether or not the list is empty, 
 *      (b) the first node, 
 *      (c) the last node, and 
 *      (d) the node at a given index (zero based indexing). 
 * Also include methods to 
 *      (e) insert a node in order, 
 *      (f) remove the first occurrence of a node with a given price (returning the node removed, which is null if no matching node is found), and 
 *      (g) display the price and make for all Cars in the list, one Car per line. 
 *      
 *  Make sure all insertions and deletions are performed as efficiently as possible.
 * 
 * CarNode.cs: 
 * Is a node class similar to the one we discussed in lectures, except the data in this case is a Car object, and you must include both a next and a previous 
 * pointer in each node. The previous pointer points to the previous node and is null in the first node.
 * 
 * CarListTester.cs: 
 * Includes a main method to throughly test your CarList. That is, you will create an empty list and then add and remove a variety of CarNodes to test out 
 * every method in both the CarList and CarNode classes. Test the various cases handled by each of your methods – e.g. add a node that becomes the first node in the list, 
 * one that becomes the last node in the list, one that ends up being added in the middle, one that has the same price as an existing Car. Do similar cases for removals. 
 * Produce reasonable output to show what is going on and what the results are of your tests. For example, display the list at appropriate points to confirm that the operations 
 * you tested performed properly. There is no need to read data in this test class – you can simply hard code your test values into the main method.
********************************************************************************************************************************************************************/
public class CarList
{

    // global variables 
    private CarNode _head; 
    private CarNode _tail;
    private CarNode _cursor;
    private int _counter;

    public CarList()
    {
        _head = null;
        _tail = new CarNode(); 
        _cursor = _head;
        _counter = 0;
    }

    // inserts a Car Node into the Linked List in ascending order (by Price) 
    public void InsertCarNodeInOrder(CarNode carNode)
    {

        // declare local variables 
        bool inserted;

        // initialize local variables 
        inserted = false;

        // inserts the Car Node 
        for (_cursor = _head; _cursor != null; _cursor = _cursor.GetNext())
        {
            if (carNode.GetCar().GetPrice() <= _cursor.GetCar().GetPrice())
            {
                if (_cursor == _head)
                {
                    _head = carNode;
                    carNode.SetNext(_cursor);
                    if (_cursor.GetNext() == _tail)
                    {
                        _cursor.SetNext(null);
                        _tail = _cursor;
                    }
                }
                else if (_cursor != _head)
                {
                    _cursor.GetPrevious().SetNext(carNode);
                    carNode.SetNext(_cursor);
                    carNode.SetPrevious(_cursor.GetPrevious());
                }
                _cursor.SetPrevious(carNode);
                inserted = true;
                break;
            }
        }
        if (!inserted)
        {
            if (_head == null)
            {
                _head = carNode;
                _head.SetNext(_tail);
                _tail.SetPrevious(_head);
            }
            else
            {
                _cursor = _tail;
                _cursor.SetNext(carNode);
                carNode.SetPrevious(_cursor);
                _tail = carNode; 
            }
        }
        _counter++;
        _cursor = _tail;
    }

    // inserts a Car Node into the Linked List at the end of the list in no particular order 
    public void InsertCarNode(CarNode carNode)
    {
        if (_head != null)
        {
            if (_tail.GetCar() != null)
            {
                _tail = carNode;
                _tail.SetPrevious(_cursor);
                _cursor.SetNext(_tail);
            }
            else
            {
                _tail = carNode;
                _tail.SetPrevious(_head);
                _head.SetNext(_tail);
            }
        }
        else
        {
            _head = carNode;
            _head.SetNext(_tail);
            _tail.SetPrevious(_head);
        }
        _counter++;
        _cursor = _tail;
    }

    public void PrintCarListBasic()
    {
        for (_cursor = _head; _cursor != null; _cursor = _cursor.GetNext())
        {
            Console.WriteLine("Car: " + _cursor.GetCar().GetMake() + ", " + _cursor.GetCar().GetPrice()); 
        }
    }   

    public void PrintCarListFull()
    {
        for (_cursor = _head; _cursor != null; _cursor = _cursor.GetNext())
        {
            Console.WriteLine("Car: " + _cursor.GetCar().GetMake() + ", " + _cursor.GetCar().GetPrice());
            Console.WriteLine("Previous: " + _cursor.GetPrevious()?.GetCar().GetMake());
            Console.WriteLine("Next: " + _cursor.GetNext()?.GetCar().GetMake());
            Console.WriteLine(); 
        }
    }

}
