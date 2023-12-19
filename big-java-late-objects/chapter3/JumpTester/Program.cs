/*****************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/11/2023 
 * Filename: JumpTester.cs 
 * Description: The average person can jump off the ground with a velocity of 7 mph without fear of leaving the planet. However, if an astronaut 
 * jumps with this velocity while standing on Halley's Comet, will the astronaut ever come back down? Create a program that allows the user to input 
 * a launch velocity (in mph) from the surface of Halley's Comet and determine whether a jumper will return to the surface. If not, the program should 
 * calculate how much more massive the comet must be in order to return the jumper to the surface. 
 * 
 * Hint: Escape velocity is vEscape = Sqrt(2 * (G*M)/R), where G = 6.67 * 10^-11 N*M^2/kg^2 is the gravitational constant, 
 * M = 1.3 * 10^22kg is the mass of Halley's comet, and R = 1.153 * 10^6m is its radius. 
*****************************************************************************************************************************************/
using JumpTester;

public class Program
{

    // global variables 

    // earth 
    private static double _massOfThePlanetEarth = (double)(5.9723 * Math.Pow(10, 24));
    private static double _radiusOfThePlanetEarth = 6371000;
    private static double _distanceFromEarthToMoon = 384472282; 

    // earth's moon 
    private static double _massOfTheEarthsMoon = (double)(7.3 * Math.Pow(10, 22));
    private static double _radiusOfTheEarthsMoon = (double)(1.74 * Math.Pow(10, 6));

    // Halley's Comet 
    private static double _massOfHalleysComet = (double)(1.3 * Math.Pow(10, 22));
    private static double _radiusOfHalleysComet = (double)(1.153 * Math.Pow(10, 6));

    // gravitational constant 
    private static float _gravitationalConstant = (float)(6.67 * Math.Pow(10, -11)); // G = N*M^2/kg^2

    public static void Main(string[] args)
    {

        // declare local variables 
        Planet p;
        bool running;
        double vLaunch; 

        // initialize local variables 
        running = true;
        p = new Planet();

        // infinite loops 
        while (running)
        {

            // prompt the user for the radius of the Planet  
            Console.Write("Please enter the radius of the Planet in meters: ");
            p.SetRadius(Double.Parse(Console.ReadLine())); 

            // prompt the user the launch velocity 
            Console.Write("Please enter the launch velocity of the space-craft in miles per hour: ");
            vLaunch = Double.Parse(Console.ReadLine());

            // calculate the mass of the Planet
            p.SetMass(CalculateMassByRadiusAndLaunchVelocity(p.GetRadius(), (vLaunch/2.23694)));

            // calculate the escape velocity
            p.SetEscapeVelocity(CalculateEscapeVelocityByRadiusAndMass(p.GetRadius(), p.GetMass())); 

            // display a message 
            Console.WriteLine("");
            Console.WriteLine("Mass of the Planet: " + p.GetMass() + "kg");
            Console.WriteLine("Radius of the Planet: " + p.GetRadius() + " meters");
            Console.WriteLine("Escape Velocity of the Planet: " + p.GetEscapeVelocity() + " miles per hour");
            Console.WriteLine("Mass proportion to the Planet Earth: " + (p.GetMass() / _massOfThePlanetEarth));
            Console.WriteLine("");

        }

        // Unit Test Case 
        UnitTest();

        // stop 
        Console.ReadLine(); 

    }

    // returns the mass of the space Object in kg 
    public static double CalculateMassByRadiusAndLaunchVelocity(double radius, double vLaunch)
    {
        return (Math.Pow((vLaunch), 2) * radius) / (2 * _gravitationalConstant); 
    }

    // returns the escape velocity of the space Object in miles per hour 
    public static double CalculateEscapeVelocityByRadiusAndMass(double radius, double mass)
    {
        return (Math.Sqrt((2 * _gravitationalConstant * mass) / radius)) * 2.23694; 
    }

    // Unit Testing 
    public static void UnitTest()
    {

        // declare local variables 
        double vLaunch;
        double vEscape;
        double gravitationalForce;
        double radius;
        double mass;
        double radiusComputed;

        // initialize local variables 
        vLaunch = 2682.24; // in meters per second 
        radius = _radiusOfThePlanetEarth * 0.667; // in meters 
        mass = (Math.Pow(vLaunch, 2) * radius) / (2 * _gravitationalConstant); // kg 
        radiusComputed = (mass * 2 * _gravitationalConstant) / (Math.Pow(vLaunch, 2));

        // calculate the Escape velocity 
        vEscape = (double)Math.Sqrt((2 * _gravitationalConstant * _massOfHalleysComet) / _radiusOfHalleysComet);

        // convert from meters per second to miles per hour 
        vEscape *= 2.23694;

        // print the escape velocity 
        Console.WriteLine("Escape Velocity of Halley's Comet: " + vEscape + " miles per hour");

        // calculate the gravitational force of the Earth on the moon 
        gravitationalForce = (double)((_gravitationalConstant * _massOfThePlanetEarth * _massOfTheEarthsMoon) / (Math.Pow(_distanceFromEarthToMoon, 2)));

        // print the gravitational force 
        Console.WriteLine("The Gravitational Force of the Earth on the Moon: " + gravitationalForce + " Newtons");

        // calculate the Escape velocity 
        Console.WriteLine("Given a mass of: " + mass + " kg, and a radius of 2/3 that of Earth: " + radius + " meters");
        vEscape = (double)Math.Sqrt((2 * _gravitationalConstant * mass) / radius);
        vEscape *= 2.23694; // convert to miles per hour 

        // print the escape velocity 
        Console.WriteLine("Escape Velocity: " + vEscape + " miles per hour");

        // print the computed radius 
        Console.WriteLine("The Computed Radius: " + radiusComputed + " meters");

        // keep the application running 
        Console.ReadLine();

    }

}
