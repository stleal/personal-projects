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
public class SubrectangleQueries
{

    // global variables 
    private int[,] _rectangle; 

    public SubrectangleQueries(int[,] rectangle)
    {
        _rectangle = rectangle; 
    }

    // update Subrectangle 
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int i = row1; i <= row2; i++)
        {
            for (int j = col1; j <= col2; j++)
            {
                _rectangle[i, j] = newValue; 
            }
        }
    } 

    // gets the value 
    public int GetValue(int row, int col)
    { 
        return _rectangle[row, col]; 
    }

    // print the rectangle 
    public void PrintRectangle()
    {
        for (int i = 0; i < _rectangle.GetLength(0); i++)
        {
            for (int j = 0; j < _rectangle.GetLength(1); j++)
            {
                Console.Write(_rectangle[i, j] + " "); 
            }
            Console.WriteLine(); 
        }
        Console.WriteLine(); 
    }

}
