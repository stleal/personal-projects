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
        double r, h, mass; 

        // initialize local variables 
        r = 0.94;
        h = 1.03;
        mass = ConvertLbsToKgs(120); 

        // sphere 
        Shape sphere = new Shape(r, null);
        Console.WriteLine("Volume of a Sphere with a radius of " + r + " = " + sphere.SphereVolume()); 
        Console.WriteLine("Surface area of a Sphere with a radius of " + r + " = " + sphere.SphereSurface());

        // cylinder 
        Shape cylinder = new Shape(r, h);
        Console.WriteLine("Volume of a Cylinder with a radius of " + r + " and height of " + h + " = " + cylinder.CylinderVolume());
        Console.WriteLine("Surface area a Cylinder with a radius of " + r + " and height of " + h + " = " + cylinder.CylinderSurface());

        // cone 
        Shape cone = new Shape(r, h);
        Console.WriteLine("Volume of a Cone with a radius of " + r + " and height of " + h + " = " + cone.ConeVolume());
        Console.WriteLine("Surface area a Cone with a radius of " + r + " and height of " + h + " = " + cone.ConeSurface());

        // additional physics exercises 
        // density of a sphere 
        sphere = new Shape(r, null, mass);
        Console.WriteLine("Density of a Sphere with a mass of " + mass + "kgs = " + sphere.SphereDensity());

        // density of a cylinder 
        cylinder = new Shape(r, h, mass);
        Console.WriteLine("Density of a Cylinder with a mass of " + mass + "kgs = " + cylinder.CylinderDensity());

        // density of a cone 
        cone = new Shape(r, h, mass);
        Console.WriteLine("Density of a Cone with a mass of " + mass + "kgs = " + cone.ConeDensity());

    }

    // converts lbs to kgs 
    public static double ConvertLbsToKgs(double lbs)
    {
        return (lbs * 0.453592); 
    }

}
