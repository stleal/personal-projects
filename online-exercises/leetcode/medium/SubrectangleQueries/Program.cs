/**********************************************************************************************************************
 * Name: Sam Leal 
 * Date: 11/23/2023 
 * Filename: SubrectangleQueries.cs 
 * Description: Implement the class SubrectangleQueries which receives a rows x cols rectangle as a matrix of 
 * integers in the constructor and supports two methods: 
 * 
 *      1. updateSubrectangle(int row1, int col1, int row2, int col2, int newValue) 
 *         Updates all values with newValue in the subrectangle whose upper left coordinate is (row1,col1) and 
 *         bottom right coordinate is (row2,col2). 
 * 
 *      2. getValue(int row, int col) 
 *         Returns the current value of the coordinate (row,col) from the rectangle.
 *         
***********************************************************************************************************************/ 
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[,] rectangle;
        SubrectangleQueries sq;

        // initialize local variables 
        rectangle = CreateNewRectangle(4, 3, 1, 9); 

        // Subrectangle Query 
        sq = new SubrectangleQueries(rectangle);

        // print the value of a certain cell within the rectangle 
        Console.WriteLine("Before updating (0, 2): " + sq.GetValue(0, 2));

        // print the rectangle 
        sq.PrintRectangle();

        // update Subrectangle 
        sq.UpdateSubrectangle(0, 0, 2, 2, 6);

        // print the value of a certain cell within the rectangle 
        Console.WriteLine("After updating (0, 2): " + sq.GetValue(0, 2));

        // print the rectangle 
        sq.PrintRectangle();

        // Unit Case 01 
        rectangle = CreateNewRectangle(16, 16, 1, 9);
        sq = new SubrectangleQueries(rectangle);

        // print the value of a certain cell within the rectangle 
        Console.WriteLine("Before updating (4, 6): " + sq.GetValue(4, 6));

        // print the rectangle 
        sq.PrintRectangle();

        // update Subrectangle 
        sq.UpdateSubrectangle(3, 0, 7, 7, 6);

        // print the value of a certain cell within the rectangle 
        Console.WriteLine("After updating (4, 6): " + sq.GetValue(4, 6));

        // print the rectangle 
        sq.PrintRectangle();

        // stop 
        Console.ReadLine(); 

    } 

    // Creates a new Rectangle 
    public static int[,] CreateNewRectangle(int rows, int cols, int minRange, int maxRange)
    {
        Random r; 
        int[,] rectangle;
        r = new Random();
        rectangle = new int[rows, cols];
        for (int i = 0; i < rectangle.GetLength(0); i++)
        {
            for (int j = 0; j < rectangle.GetLength(1); j++)
            {
                rectangle[i, j] = r.Next(minRange, maxRange + 1);
            }
        }
        return rectangle; 
    }

}
