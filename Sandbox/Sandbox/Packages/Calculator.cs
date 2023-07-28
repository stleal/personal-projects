namespace Packages
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y; 
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public void Run(string[] args)
        {
            Console.WriteLine(Add(int.Parse(args[1]), int.Parse(args[2])));
        }
    }
}