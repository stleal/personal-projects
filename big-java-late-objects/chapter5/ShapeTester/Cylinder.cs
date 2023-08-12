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
public class Cylinder : Shape
{

    public Cylinder(double r, double h, double? mass = null) : base(r, h, mass)
    {
    }

    // returns the volume of a cylinder 
    public double CylinderVolume()
    {
        return (Math.PI * Math.Pow(GetRadius(), 2) * GetHeight()); 
    }

    // returns the surface area of a cylinder 
    public double CylinderSurface()
    {
        return ((double)((2 * Math.PI * GetRadius() * GetHeight()) + (2 * Math.PI * Math.Pow(GetRadius(), 2))));
    }

    // returns the density of a cylinder 
    public double CylinderDensity()
    {
        return ((double)(GetMass()/CylinderVolume()));
    }

    // prints the volume of a cylinder 
    public void PrintCylinderVolume()
    {
        Console.WriteLine("Volume of a Cylinder with a radius of " + GetRadius() + " and height of " + GetHeight() + " = " + CylinderVolume());
    }

    // prints the surface area of a cylinder 
    public void PrintCylinderSurface()
    {
        Console.WriteLine("Surface area a Cylinder with a radius of " + GetRadius() + " and height of " + GetHeight() + " = " + CylinderSurface());
    }

    // prints the density of a cylinder 
    public void PrintCylinderDensity()
    {
        Console.WriteLine("Density of a Cylinder with a mass of " + GetMass() + "kgs = " + CylinderDensity());
    }

    // prints the weight of a sphere 
    public void PrintCylinderWeight()
    {
        Console.WriteLine("Weight of a Cylinder with a mass of " + GetMass() + "kgs = " + GetWeight() + " Newtons/kg");
    }

} 
