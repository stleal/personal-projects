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
namespace JumpTester
{
    public class Planet
    {

        // global variables 
        private double _r;
        private double _mass;
        private double _escapeVelocity; 

        // default constructor 
        public Planet()
        {
        }

        // Planet constructor 
        public Planet(double radius, double mass)
        {
            _r = radius; 
            _mass = mass;
        }

        // set radius 
        public void SetRadius(double radius)
        {
            _r = radius; 
        }

        // set mass 
        public void SetMass(double mass)
        {
            _mass = mass;
        }

        // set escape velocity 
        public void SetEscapeVelocity(double escapeVelocity)
        {
            _escapeVelocity = escapeVelocity;
        }

        // gets the radius
        public double GetRadius()
        {
            return _r;
        }

        // gets the mass 
        public double GetMass()
        {
            return _mass; 
        }

        // gets the escape velocity 
        public double GetEscapeVelocity()
        {
            return _escapeVelocity; 
        }

    }

}
