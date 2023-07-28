public class Calculator
{

    public static void Main(String[] args)
    {

        // get input from the user 
        Console.Write("Please enter a value for x: ");
        int x = int.Parse(Console.ReadLine());

        // get input from the user 
        Console.Write("Please enter a value for y: ");
        int y = int.Parse(Console.ReadLine());

        // print output of x + y 
        Console.WriteLine(Add(x, y));

        // prevent console window from closing 
        Console.ReadLine(); 

    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

}
