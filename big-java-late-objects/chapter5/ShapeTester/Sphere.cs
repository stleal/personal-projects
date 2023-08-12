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
 *      public static double cylinderSurface(double r, double h) 
 *      public static double coneVolume(double r, double h) 
 *      public static double coneSurface(double r, double h) 
 *  
 *  For fun, we are going to implement these using the following classes: 
 *      Shape.cs, Sphere.cs, Cylinder.cs, and Cone.cs 
 *  
 *  Remember to make your Sphere.cs, Cylinder.cs, and Cone.cs classes extend the Shape.cs class. 
**************************************************************************************************************/
public class Sphere : Shape
{

    public Sphere(double r, double? h = null, double? mass = null) : base(r, h, mass)
    {
    }

    // returns the volume of a sphere 
    public double SphereVolume()
    {
        return ((4/3) * Math.PI * Math.Pow(GetRadius(), 3));
    }

    // returns the surface area of a sphere 
    public double SphereSurface()
    {
        return ((4) * Math.PI * Math.Pow(GetRadius(), 2));
    }

    // returns the density of a sphere 
    public double SphereDensity()
    {
        return ((double)(GetMass()/SphereVolume()));
    }

    // throws a Sphere 
    public void SphereThrow(double vi, double vf, double t)
    {
        SetVelocityInitial(vi); 
        SetVelocityFinal(vf); 
        SetTime(t);
        CalculateAcceleration(); 
    }

    // prints the volume of a sphere 
    public void PrintSphereVolume()
    {
        Console.WriteLine("Volume of a Sphere with a radius of " + GetRadius() + " = " + SphereVolume());
    }

    // prints the surface area of a sphere 
    public void PrintSphereSurface()
    {
        Console.WriteLine("Surface area of a Sphere with a radius of " + GetRadius() + " = " + SphereSurface());
    }

    // prints the density of a sphere 
    public void PrintSphereDensity()
    {
        Console.WriteLine("Density of a Sphere with a mass of " + GetMass() + "kgs = " + SphereDensity());
    }

    // prints the weight of a sphere 
    public void PrintSphereWeight()
    {
        Console.WriteLine("Weight of a Sphere with a mass of " + GetMass() + "kgs = " + GetWeight() + " Newtons/kg");
    }

    // prints the acceleration of a sphere 
    public void PrintSphereAcceleration()
    {
        Console.WriteLine("Acceleration of a Sphere thrown at an initial velocity of: " + GetVelocityInitial() + " = " + GetAcceleration()); 
    }

}
