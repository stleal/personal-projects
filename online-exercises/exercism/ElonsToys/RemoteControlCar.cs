/**************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 10/21/2023 
 * Filename: ElonsToys.cs 
 * Description: In this exercise you'll be playing around with a remote controlled car, which you've finally saved enough money for to buy. 
 * Cars start with full (100%) batteries. Each time you drive the car using the remote control, it covers 20 meters and drains one percent of the battery. 
 * The remote controlled car has a fancy LED display that shows two bits of information: 
 * The total distance it has driven, displayed as: "Driven <METERS> meters". 
 * The remaining battery charge, displayed as: "Battery at <PERCENTAGE>%". 
 * If the battery is at 0%, you can't drive the car anymore and the battery display will show "Battery empty". 
 * You have six tasks, each of which will work with remote controlled car instances.
**************************************************************************************************************************************************************/
public class RemoteControlCar
{

    // global variables 
    private int _distanceDriven;
    private int _batteryPercentage; 

    // default constructor 
    public RemoteControlCar()
    {
        _distanceDriven = 0;
        _batteryPercentage = 100; 
    }

    public void Drive()
    {
        if (GetBatteryPercentage() > 0)
        {
            _distanceDriven += 20;
            _batteryPercentage -= 1; 
        }
        else
        {
            Console.WriteLine("Battery empty"); 
        }
    }

    public void DistanceDisplay()
    {
        Console.WriteLine("Driven " + GetDistanceDriven() + " meters"); 
    } 

    public void BatteryDisplay()
    {
        Console.WriteLine("Battery at " + GetBatteryPercentage() + "%"); 
    }

    public int GetDistanceDriven()
    {
        return _distanceDriven;
    }

    public int GetBatteryPercentage()
    {
        return _batteryPercentage; 
    }

}