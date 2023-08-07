/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/07/2023 
 * Filename: Bug.cs 
 * Description: Write a class Bug that models a bug moving along a horizontal line. The bug 
 * moves either to the right or left. Initially, the bug moves to the right, but it can turn 
 * to change its direction. In each move, its position changes by one unit in the current 
 * direction. Provide a constructor: 
 *      public Bug(int initialPosition)
 * and methods:      
 *      public void turn() 
 *      public void move() 
 *      public int getPosition() 
 *  Sample usage: 
 *      Bug bugsy = new Bug(10); 
 *      bugsy.move(); // Now the position is 11 
 *      bugsy.turn(); 
 *      bugsy.move() // Now the position is 10 
 *  Your main method should construct a bug, make it move and turn a few times, and print the 
 *  actual and expected positions. 
*********************************************************************************************/
public class Bug
{

    // global variables 
    private int _position;
    private int _direction; 

    // default constructor 
    public Bug()
    {
        _position = 10;
        _direction = 1; 
    }

    // returns the current position of the Bug
    public int GetPosition()
    {
        return _position; 
    }

    // moves the Bug in a direction
    public void Move()
    {
        _position += _direction; 
    }

    // turns the Bug to the opposite direction 
    public void Turn()
    {
        _direction *= -1; 
    }

}
