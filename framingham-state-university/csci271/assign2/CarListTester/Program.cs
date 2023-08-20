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
public class Program
{

    // main 
    public static void Main(string[] args)
    {
        InsertCarNodesInOrder();
        InsertCarNodes();
    }

    // insert Car Nodes in order 
    public static void InsertCarNodesInOrder()
    {

        // declare local variables 
        Car car;
        CarNode carNode;
        CarList carList;

        // initialize local variables 
        carList = new CarList();

        // inserts a new Car Node
        car = new Car(2023, "Nissan", 27500, "Rogue", null, "Black"); 
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2021, "Chevrolet", 26500, "Silverado", null, "Black");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2024, "Tesla", 36500, "Model S", null, "Dark Navy Blue");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2024, "Tesla", 36500, "Model S", null, "Black");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2022, "Toyota", 30000, "RAV4", "LE", "Black");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2024, "BMW", 46500, "X6", null, "White");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2021, "Chevrolet", 26500, "Silverado", null, "Black");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2022, "Honda", 28000, "CRV", null, "Dark Gray");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2022, "Toyota", 30000, "RAV4", "LE", "Black");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2024, "Audi", 46500, "A4", null, "White");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2024, "Audi", 65000, "A4", null, "White");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // inserts a new Car Node
        car = new Car(2024, "BMW", 65000, "X6", null, "White");
        carNode = new CarNode(car);
        carList.InsertCarNodeInOrder(carNode);

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

        // prints a more detailed report of the linked list 
        carList.PrintCarListFull();

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());

        // prints whether or not the linked list is empty 
        Console.WriteLine("Is Empty?: " + carList.IsEmpty());

        // prints the first Node in the list 
        Console.WriteLine("First: " + carList.GetFirst().GetCar().GetMake() + ", " + carList.GetFirst().GetCar().GetPrice());

        // prints the last Node in the list 
        Console.WriteLine("Last: " + carList.GetLast().GetCar().GetMake() + ", " + carList.GetLast().GetCar().GetPrice());

        // prints the Node at the specified index 
        Console.WriteLine("Car at index " + 6 + ": " + carList.GetNodeAt(6).GetCar().GetMake() + ", " + carList.GetNodeAt(6).GetCar().GetPrice());

        // prints the Node at the specified index 
        Console.WriteLine("Car at index " + 0 + ": " + carList.GetNodeAt(0).GetCar().GetMake() + ", " + carList.GetNodeAt(0).GetCar().GetPrice());

        // prints the Node at the specified index 
        Console.WriteLine("Car at index " + (carList.GetSize() - 1) + ": " + carList.GetNodeAt(carList.GetSize()-1).GetCar().GetMake() + ", " + carList.GetNodeAt(carList.GetSize()-1).GetCar().GetPrice());

        // prints a blank link 
        Console.WriteLine();

        // removes a Car Node 
        carNode = carList.RemoveCarNode(26500);

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());
        Console.WriteLine("Removed: " + carNode.GetCar().GetYearMakeModelColor() + " from the linked list");
        Console.WriteLine();

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

        // removes a Car Node 
        carNode = carList.RemoveCarNode(28000);

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());
        Console.WriteLine("Removed: " + carNode.GetCar().GetYearMakeModelColor() + " from the linked list");
        Console.WriteLine();

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

        // removes a Car Node 
        carNode = carList.RemoveCarNode(46500);

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());
        Console.WriteLine("Removed: " + carNode.GetCar().GetYearMakeModelColor() + " from the linked list");
        Console.WriteLine();

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

        // removes a Car Node from the linked list by year, make, and price 
        carNode = carList.RemoveCarNode(2024, "BMW", 46500);

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());
        Console.WriteLine("Removed: " + carNode.GetCar().GetYearMakeModelColor() + " from the linked list");
        Console.WriteLine();

        // removes a Car Node from the linked list by year, make, and price 
        carNode = carList.RemoveCarNode(2024, "BMW", 65000);

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());
        Console.WriteLine("Removed: " + carNode.GetCar().GetYearMakeModelColor() + " from the linked list");
        Console.WriteLine();

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

    }

    // insert Car Nodes at the end of the list in no particular order 
    public static void InsertCarNodes()
    {

        // declare local variables 
        Car car;
        CarNode carNode;
        CarList carList;

        // initialize local variables 
        carList = new CarList();

        // inserts a new Car Node
        car = new Car(2023, "Nissan", 27500, "Rogue", null, "Black");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // inserts a new Car Node
        car = new Car(2021, "Chevrolet", 26500, "Silverado", null, "Black");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // inserts a new Car Node
        car = new Car(2024, "Tesla", 36500, "Model S", null, "Dark Navy Blue");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // inserts a new Car Node
        car = new Car(2024, "Tesla", 36500, "Model S", null, "Black");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // inserts a new Car Node
        car = new Car(2022, "Toyota", 30000, "RAV4", "LE", "Black");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // inserts a new Car Node
        car = new Car(2024, "BMW", 46500, "X6", null, "White");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // inserts a new Car Node
        car = new Car(2021, "Chevrolet", 26500, "Silverado", null, "Black");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // inserts a new Car Node
        car = new Car(2022, "Honda", 28000, "CRV", null, "Dark Gray");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // inserts a new Car Node
        car = new Car(2022, "Toyota", 30000, "RAV4", "LE", "Black");
        carNode = new CarNode(car);
        carList.InsertCarNode(carNode);

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

        // prints a more detailed report of the linked list 
        carList.PrintCarListFull();

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());

        // prints whether or not the linked list is empty 
        Console.WriteLine("Is Empty?: " + carList.IsEmpty());

        // prints the first Node in the list 
        Console.WriteLine("First: " + carList.GetFirst().GetCar().GetMake() + ", " + carList.GetFirst().GetCar().GetPrice());

        // prints the last Node in the list 
        Console.WriteLine("Last: " + carList.GetLast().GetCar().GetMake() + ", " + carList.GetLast().GetCar().GetPrice());

        // prints the Node at the specified index 
        Console.WriteLine("Car at index " + 6 + ": " + carList.GetNodeAt(6).GetCar().GetMake() + ", " + carList.GetNodeAt(6).GetCar().GetPrice());

        // prints the Node at the specified index 
        Console.WriteLine("Car at index " + 0 + ": " + carList.GetNodeAt(0).GetCar().GetMake() + ", " + carList.GetNodeAt(0).GetCar().GetPrice());

        // prints the Node at the specified index 
        Console.WriteLine("Car at index " + (carList.GetSize() - 1) + ": " + carList.GetNodeAt(carList.GetSize() - 1).GetCar().GetMake() + ", " + carList.GetNodeAt(carList.GetSize() - 1).GetCar().GetPrice());

        // prints a blank link 
        Console.WriteLine();

        // prints a blank link 
        Console.WriteLine();

        // removes a Car Node 
        carNode = carList.RemoveCarNode(26500);

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());
        Console.WriteLine("Removed: " + carNode.GetCar().GetYearMakeModelColor() + " from the linked list");
        Console.WriteLine();

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

        // removes a Car Node 
        carNode = carList.RemoveCarNode(28000);

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());
        Console.WriteLine("Removed: " + carNode.GetCar().GetYearMakeModelColor() + " from the linked list");
        Console.WriteLine();

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

        // removes a Car Node 
        carNode = carList.RemoveCarNode(46500);

        // prints the size of the linked list 
        Console.WriteLine("Size of the Linked List: " + carList.GetSize());
        Console.WriteLine("Removed: " + carNode.GetCar().GetYearMakeModelColor() + " from the linked list");
        Console.WriteLine();

        // prints the linked list
        carList.PrintCarListBasic();
        Console.WriteLine();

    }

} 
