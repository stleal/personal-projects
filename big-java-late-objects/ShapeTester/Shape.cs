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
public class Shape
{

    // global variables 
    private double? _r; // radius 
    private double? _h; // height 
    private double? _volume; // volume 
    private double? _surfaceArea; // surface area 
    private double? _density; // density 
    private double? _mass; // mass 
    private double? _weight; // weight 
    private const double ACCELERATION_OF_GRAVITY = 9.8; // meters per second squared 

    // default constructor 
    public Shape()
    {
        _r = null;
        _h = null;
        _volume = null;
        _surfaceArea = null;
        _density = null;
        _mass = null;
        _weight = null;
    }

    // Shape constructor 01
    public Shape(double? r = null, double? h = null)
    {
        _r = r;
        _h = h;
    }

    // Shape constructor 02 
    public Shape(double? r = null, double? h = null, double? mass = null)
    {
        _r = r; 
        _h = h; 
        _mass = mass; 
    }

    // returns the volume of a sphere 
    public double SphereVolume()
    {
        return ((4 / 3) * Math.PI * Math.Pow((double)_r, 3));
    }

    // returns the surface area of a sphere 
    public double SphereSurface()
    {
        return ((4) * Math.PI * Math.Pow((double)_r, 2)); 
    }

    // calculates and returns the density 
    public double SphereDensity()
    {
        return ((double)(_mass / SphereVolume()));
    }

    // returns the volume of a cylinder 
    public double CylinderVolume()
    {
        return ((double)(Math.PI * Math.Pow((double)_r, 2) * _h)); 
    }

    // returns the surface area of a cylinder 
    public double CylinderSurface()
    {
        return ((double)((2 * Math.PI * _r * _h) + (2 * Math.PI * Math.Pow((double)_r, 2)))); 
    }

    public double CylinderDensity()
    {
        return ((double)(_mass / CylinderVolume()));
    }

    // returns the volume of a cone 
    public double ConeVolume()
    {
        return ((double)(Math.PI * Math.Pow((double)_r, 2) * (_h/3))); 
    }

    // returns the surface area of a cone 
    public double ConeSurface()
    {
        return ((double)(Math.PI * _r * (_r + Math.Sqrt(Math.Pow((double)_h, 2) + Math.Pow((double)_r, 2))))); 
    }

    public double ConeDensity()
    {
        return ((double)(_mass / ConeVolume()));
    }

}
