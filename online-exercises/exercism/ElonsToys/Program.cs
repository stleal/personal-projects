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
public class ElonsToys
{

    // main 
    public static void Main(string[] args)
    {

        RemoteControlCar r = new RemoteControlCar();
        r.DistanceDisplay(); 
        r.BatteryDisplay();
        r.Drive();
        r.DistanceDisplay();
        r.BatteryDisplay();
        r.Drive();
        r.Drive();
        r.DistanceDisplay();
        r.BatteryDisplay();

        // drain the Battery 
        while (r.GetBatteryPercentage() > 0)
        {
            r.Drive();
            r.DistanceDisplay(); 
            r.BatteryDisplay(); 
        }

        r.Drive(); 

    }

}