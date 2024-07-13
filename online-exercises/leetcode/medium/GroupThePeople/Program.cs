/*********************************************************************************************************************************************
 * Name: Sam Leal
 * Date: 11/24/2023
 * Filename: GroupThePeople.cs
 * Description: There are n people that are split into some unknown number of groups. Each person is labeled with a
 * unique ID from 0 to n - 1. You are given an integer array groupSizes, where groupSizes[i] is the size of the group that
 * person i is in. For example, if groupSizes[1] = 3, then person 1 must be in a group of size 3. Return a list of groups such that
 * each person i is in a group of size groupSizes[i]. Each person should appear in exactly one group, and every person must be in a group.
 * If there are multiple answers, return any of them. It is guaranteed that there will be at least one valid solution for the given input.
 *
 * Constraints: (Specific Requirements / Acceptance Criteria)
 * groupSizes.length == n
 * 1 <= n <= 500
 * 1 <= groupSizes[i] <= n
*********************************************************************************************************************************************/
public class Program
{

    // main
    public static void Main(string[] args)
    {

        // declare local variables
        int[] groupSizes;
        List<List<int>> answer;

        // Unit Test Case 01
        groupSizes = new int[] { 3, 3, 3, 3, 3, 1, 3 };
        answer = GroupThePeople(groupSizes);
        PrintAnswer(answer);

        // Unit Test Case 02
        groupSizes = new int[] { 2, 1, 3, 3, 3, 2 };
        answer = GroupThePeople(groupSizes);
        PrintAnswer(answer);

        // Unit Test Case 03
        groupSizes = new int[] { 5, 4, 3, 2, 1, 8, 8, 10, 12, 24 };
        answer = GroupThePeople(groupSizes);
        PrintAnswer(answer);

        // // Unit Test Case 04
        // groupSizes = CreateIntArray(8);
        // answer = GroupThePeople(groupSizes);
        // PrintAnswer(answer);

        // // Unit Test Case 05
        // groupSizes = CreateIntArray(16);
        // groupSizes = ShuffleArray(groupSizes);
        // answer = GroupThePeople(groupSizes);
        // PrintAnswer(answer);

        // // Unit Test Case 06
        // groupSizes = CreateIntArray(32);
        // groupSizes = ShuffleArray(groupSizes);
        // answer = GroupThePeople(groupSizes);
        // PrintAnswer(answer);

        // // Unit Test Case 07
        // groupSizes = CreateIntArray(64);
        // groupSizes = ShuffleArray(groupSizes);
        // answer = GroupThePeople(groupSizes);
        // PrintAnswer(answer);

        // // Unit Test Case 08
        // groupSizes = CreateIntArray(128);
        // groupSizes = ShuffleArray(groupSizes);
        // answer = GroupThePeople(groupSizes);
        // PrintAnswer(answer);

    }

    private static void PrintAnswer(List<List<int>> answer)
    {
        foreach (List<int> group in answer)
        {
            Console.Write("[");
            foreach (int person in group)
            {
                Console.Write(person + ",");
            }
            Console.Write("]");
        }
        Console.WriteLine();
    }

    // returns a list of groups such that each person i is in a group of size groupSizes[i]
    public static List<List<int>> GroupThePeople(int[] groupSizes)
    {

        // declare local variables
        int i;
        int index;
        List<int> group;
        int[] groupIndex;
        List<List<int>> groups;

        // initialize local variables
        i = 0;
        index = 0;
        groups = new List<List<int>>();
        groupIndex = new int[groupSizes.Length];

        // groups the people
        foreach(int personSize in groupSizes)
        {
            List<int> availableGroup = GetAvailableGroup(personSize, groups, groupIndex);
            if (availableGroup.Count == 0)
            {
                availableGroup = new List<int>(new int[personSize]);
                groups.Add(availableGroup);
            }
            index = groups.IndexOf(availableGroup);
            availableGroup.Add(i);
            availableGroup.RemoveAt(0);
            groupIndex[index]++;
            i++;
        }

        // returns a list of groups
        return groups;

    }

    /*****************************************************************************************************************
     * returns a List<int> availableGroup, where the count of elements contained therein equals the given personSize,
     * returns an empty List<int> if no availableGroup is found contained within List<List<int>> groups
     ****************************************************************************************************************/
    public static List<int> GetAvailableGroup(int personSize, List<List<int>> groups, int[] currentIndex)
    {
        int index;
        List<int> availableGroup;
        index = 0;
        availableGroup = new List<int>();
        foreach (List<int> group in groups)
        {
            if (group.Count() == personSize && currentIndex.ElementAt(index) < personSize)
            {
                availableGroup = group;
                break;
            }
            index++;
        }
        return availableGroup;
    }

    // shuffles an Integer array
    public static int[] ShuffleArray(int[] ua)
    {
        int[] sa;
        Random r;
        List<int> l;
        int ri, count;
        count = 0;
        r = new Random();
        l = new List<int>();
        sa = new int[ua.Length];
        while (l.Count() < ua.Length)
        {
            ri = r.Next(0, ua.Length);
            if (!l.Contains(ri))
            {
                l.Add(ri);
                sa[count++] = ua[ri];
            }
        }
        return sa;
    }

    /************************************************************
     * creates an Integer array for Unit Testing purposes
     * for each number n, up to size s, the final array will
     * have n occurencies of each number
     ***********************************************************/
    public static int[] CreateIntArray(int size)
    {
        int count, triangularNumber;
        int[] array;
        count = 0;
        triangularNumber = GetTriangluarNumberByFormula(size);
        array = new int[triangularNumber];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                array[count++] = i + 1;
            }
        }
        return array;
    }

    // get the Triangular Number of size using the Triangle Formula
    public static int GetTriangluarNumberByFormula(int n)
    {
        return (n * (n + 1)) / 2;
    }

    // get the Triangular Number of n using a while loop
    public static int GetTriangluarNumberByLoop(int n)
    {
        int i, sum;
        sum = 0;
        i = n;
        while (i > 0)
        {
            sum += i--;
        }
        return sum;
    }

}
