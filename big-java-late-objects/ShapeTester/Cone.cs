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
public class Cone : Shape
{

    public Cone(double r, double h, double? mass = null) : base(r, h, mass)
    {
    }

    // returns the volume of a cone 
    public double ConeVolume()
    {
        return ((double)(Math.PI * Math.Pow(GetRadius(), 2) * (GetHeight()/3)));
    }

    // returns the surface area of a cone 
    public double ConeSurface()
    {
        return ((double)(Math.PI * GetRadius() * (GetRadius() + Math.Sqrt(Math.Pow(GetHeight(), 2) + Math.Pow(GetRadius(), 2)))));
    }

    // returns the density of a cone 
    public double ConeDensity()
    {
        return ((GetMass()/ConeVolume()));
    }

    // prints the volume of a cone 
    public void PrintConeVolume()
    {
        Console.WriteLine("Volume of a Cone with a radius of " + GetRadius() + " and height of " + GetHeight() + " = " + ConeVolume());
    }

    // prints the surface area of a cone 
    public void PrintConeSurface()
    {
        Console.WriteLine("Surface area a Cone with a radius of " + GetRadius() + " and height of " + GetHeight() + " = " + ConeSurface());
    }

    // prints the density of a cone 
    public void PrintConeDensity()
    {
        Console.WriteLine("Density of a Cone with a mass of " + GetMass() + "kgs = " + ConeDensity());
    }

    // prints the weight of a cone  
    public void PrintConeWeight()
    {
        Console.WriteLine("Weight of a Cone with a mass of " + GetMass() + "kgs = " + GetWeight() + " Newtons/kg");
    }

}