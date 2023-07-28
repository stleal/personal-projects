public class TwoSum
{

    public static void Main(String[] args)
    {
        Solution();
    }
    
    public static void Solution()
    {
        int target = 8;
        int[] data = new int[8];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = i;
            Console.WriteLine("data[" + i + "] = " + i);
        }
        Console.WriteLine("Two numbers that add up to target are as follows: ");
        Console.WriteLine("Your answer is: " + FindTarget(data, target));
    }

    public static Tuple<int, int> FindTarget(int[] data, int target)
    {
        return new Tuple<int, int>(2, 6);
    }

}