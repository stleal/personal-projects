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
    private double? _weight; // weight = Force => newtons/kg 
    private const double ACCELERATION_OF_GRAVITY = 9.8; // meters per second squared 
    private double? _a; // acceleration 
    private double? _vi; // initial velocity 
    private double? _vf; // final velocity 
    private double? _t; // time 

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
        _a = null;
    }

    // Shape constructor  
    public Shape(double? r = null, double? h = null, double? mass = null)
    {
        _r = r;
        _h = h;
        _mass = mass;
        _weight = (_mass != null) ? (_mass * ACCELERATION_OF_GRAVITY) : null;
    }

    // gets the radius of the Shape 
    public double GetRadius()
    {
        return (double)_r;
    }

    // gets the height of the Shape 
    public double GetHeight()
    {
        return (double)_h;
    }

    // gets the mass of the Shape 
    public double GetMass()
    {
        return (double)_mass;
    }

    // gets the weight of the Shape 
    public double GetWeight()
    {
        return (double)_weight;
    }

    // gets the acceleration of the Shape 
    public double GetAcceleration()
    {
        return (double)_a;
    }

    // gets the initial velocity of the Shape 
    public double GetVelocityInitial()
    {
        return (double)_vi;
    }

    // sets the initial velocity of the Shape 
    public void SetVelocityInitial(double vi)
    {
        _vi = vi;
    }

    // sets the final velocity of the Shape 
    public void SetVelocityFinal(double vf)
    {
        _vf = vf;
    }

    // sets the time in momentum 
    public void SetTime(double t)
    {
        _t = t; 
    }

    // sets the acceleration of the Shape 
    public void SetAcceleration(double? a)
    {
        _a = a;
    }

    // calculates the acceleration 
    public void CalculateAcceleration()
    {
        SetAcceleration((_vf - _vi) / _t); 
    }

}
