/**************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/07/2023 
 * Filename: ShapeTester.cs 
 * Description: Write a program that computes the volume and surface area of a sphere with radius r, 
 * a cylinder with a circular base with radius r and height h, and a cone with a circular base with radius r 
 * and height h. Then write a program that prompts the user for the values of r and h, calls the six methods, 
 * and prints the results. 
 * 
 * You should implement the following methods: 
 *      public static double sphereVolume(double r) 
 *      public static double sphereSurface(double r) 
 *      public static double cylinderVolume(double r, double h) 
 *      public static double coneVolume(double r, double h) 
 *      public static double coneSurface(double r, double h) 
 *  
 *  For fun, we are going to implement these using the following classes: 
 *      Shape.cs, Sphere.cs, Cylinder.cs, and Cone.cs 
 *  
 *  Remember to make your Sphere.cs, Cylinder.cs, and Cone.cs classes extend the Shape.cs class. 
**************************************************************************************************************/
public class Program
{

    public static void Main(string[] args)
    {

        // declare local variables 
        bool running; 
        double r, h, mass; 

        // initialize local variables 
        running = true; 

        // infinite loop 
        while (running)
        {

            // prompt the user for input 
            Console.Write("Please enter a value for radius: ");

            // get user input 
            r = Double.Parse(Console.ReadLine());

            // prompt the user for input 
            Console.Write("Please enter a value for height: ");

            // get user input 
            h = Double.Parse(Console.ReadLine());

            // prompt the user for input 
            Console.Write("Please enter a value for the mass: ");

            // get user input 
            mass = ConvertLbsToKgs(Double.Parse(Console.ReadLine()));

            // print a blank line 
            Console.WriteLine();

            // sphere 
            SphereVolume(r);
            SphereSurface(r);
            SphereDensity(r, mass);
            SphereWeight(r, mass);
            SphereThrow(r, mass, 60, 0, 8); 

            // cylinder 
            CylinderVolume(r, h);
            CylinderSurface(r, h);
            CylinderDensity(r, h, mass);
            CylinderWeight(r, h, mass);

            // cone 
            ConeVolume(r, h);
            ConeSurface(r, h);
            ConeDensity(r, h, mass);
            ConeWeight(r, h, mass); 

            // print a blank line 
            Console.WriteLine(); 

        }
    }

    // prints the Volume of a sphere 
    public static void SphereVolume(double r)
    {
        Sphere s = new Sphere(r);
        s.PrintSphereVolume(); 
    }

    // prints the Surface area of a sphere 
    public static void SphereSurface(double r)
    {
        Sphere s = new Sphere(r);
        s.PrintSphereSurface();
    }

    // prints the density of a sphere 
    public static void SphereDensity(double r, double mass)
    {
        Sphere s = new Sphere(r, mass: mass);
        s.PrintSphereDensity();
    }

    // prints the weight of a sphere 
    public static void SphereWeight(double r, double mass)
    {
        Sphere s = new Sphere(r, mass: mass);
        s.PrintSphereWeight();
    }

    // prints the acceleration of a Sphere 
    public static void SphereThrow(double r, double mass, double vi, double vf, double t)
    {
        Sphere s = new Sphere(r, mass: mass);
        s.SphereThrow(ConvertMphToMps(vi), ConvertMphToMps(vf), t);
        s.PrintSphereAcceleration(); 
    }

    // prints the Volume of a cylinder 
    public static void CylinderVolume(double r, double h)
    {
        Cylinder c = new Cylinder(r, h);
        c.PrintCylinderVolume(); 
    }

    // prints the Surface area of a cylinder 
    public static void CylinderSurface(double r, double h)
    {
        Cylinder c = new Cylinder(r, h);
        c.PrintCylinderSurface(); 
    }

    // prints the density of a cylinder 
    public static void CylinderDensity(double r, double h, double mass)
    {
        Cylinder c = new Cylinder(r, h, mass);
        c.PrintCylinderDensity();
    }

    // prints the weight of a cylinder 
    public static void CylinderWeight(double r, double h, double mass)
    {
        Cylinder c = new Cylinder(r, h, mass);
        c.PrintCylinderWeight(); 
    }

    // prints the Volume of a cone 
    public static void ConeVolume(double r, double h)
    {
        Cone c = new Cone(r, h);
        c.PrintConeVolume(); 
    }

    // prints the Surface area of a cone 
    public static void ConeSurface(double r, double h)
    {
        Cone c = new Cone(r, h);
        c.PrintConeSurface();
    }

    // prints the density of a cone 
    public static void ConeDensity(double r, double h, double mass)
    {
        Cone c = new Cone(r, h, mass);
        c.PrintConeDensity();
    }

    // prints the weight of a cone  
    public static void ConeWeight(double r, double h, double mass)
    {
        Cone c = new Cone(r, h, mass);
        c.PrintConeWeight();
    }

    // converts lbs to kgs 
    public static double ConvertLbsToKgs(double lbs)
    {
        return (lbs * 0.453592); 
    }

    // converts mph to mps 
    public static double ConvertMphToMps(double mph)
    {
        return (mph * 0.44704);
    }

}
