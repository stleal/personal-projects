/*******************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/07/2023 
 * Filename: PayCheck.cs 
 * Description: In this program assignment, you will construct a class PayCheck. Your program will be used to print paychecks 
 * for a group of student assistants. 
 * 
 * Your class should contain at least the following: 
 * 
 *      a) Three variables to represent the name, the hourly wage and hours worked. 
 *      b) A method to deduct the federal and social security taxes. ( find about social security tax on the Internet.) 
 *         For simplicity, you may assume that both the federal and social security taxes use fixed rates. 
 *      c) A method to print a paycheck in certain format. 
 *      d) Static variables contain information like school name, tax rate, and/or other object-independent values. 
 *      
 * You should supply a main method (in the same OR different class) to test your program.  
 * 
 * The name, hourly wages and hours worked should be input to the program (standard input or command line argument), 
 * and the tax rates might be built-in values. 
********************************************************************************************************************************/
public class PayCheck
{

    // global variables 
    private string _name;
    private string _schoolName; 
    private double _hourlyWages;
    private int _hoursWorked;
    private double _grossIncome;
    private double _netPay;
    private double _federalDeducations;
    private double _stateDeductions; 
    private const double FEDERAL_TAX_RATE = 11.496;
    private const double STATE_TAX_RATE = 6.148; 

    // default constructor 
    public PayCheck(string name, string schoolName, double hourlyWage, int hoursWorked)
    {
        _name = name;
        _schoolName = schoolName;
        _hourlyWages = hourlyWage;
        _hoursWorked = hoursWorked;
    }

    // computes the student assistant's paycheck for the current pay period 
    public void ComputePayCheck()
    {
        _grossIncome = _hoursWorked * _hourlyWages;
        _federalDeducations = ((_grossIncome * FEDERAL_TAX_RATE) / 100);
        _stateDeductions = ((_grossIncome * STATE_TAX_RATE) / 100); 
        _netPay = _grossIncome - _federalDeducations - _stateDeductions;
    }

    // gets the student assistant's paycheck 
    public double GetPayCheck()
    {
        return _netPay; 
    }

    // prints the paycheck 
    public void PrintPayCheck()
    {

        // computes the paycheck 
        ComputePayCheck();

        // prints the paycheck 
        Console.WriteLine("PayCheck for: " + _name + " from " + _schoolName);
        Console.WriteLine("Hourly Rate: $" + _hourlyWages + "/hr");
        Console.WriteLine("Hours Worked: " + _hoursWorked); 
        Console.WriteLine("Gross Pay: $" + _grossIncome);
        Console.WriteLine("Federal Income Tax: $" + _federalDeducations);
        Console.WriteLine("State Income Tax: $" + _stateDeductions);
        Console.WriteLine("Net Pay: $" + _netPay);

        // prints a blank line for formatting purposes 
        Console.WriteLine(); 

    }

}
