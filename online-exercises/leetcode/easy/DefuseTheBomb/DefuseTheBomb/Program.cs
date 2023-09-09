/********************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 09/04/2023 
 * Filename: DefuseTheBomb.cs 
 * Description: You have a bomb to defuse, and your time is running out! Your informer will provide you with a circular array 
 * code of length of n and a key k. 
 * 
 * To decrypt the code, you must replace every number. All the numbers are replaced simultaneously. 
 * 
 *   If k > 0, replace the ith number with the sum of the next k numbers. 
 *   If k < 0, replace the ith number with the sum of the previous k numbers. 
 *   If k == 0, replace the ith number with 0. 
 *   
 * As code is circular, the next element of code[n-1] is code[0], and the previous element of code[0] is code[n-1]. 
 * Given the circular array code and an integer key k, return the decrypted code to defuse the bomb! 
 * 
 * Example 1: 
 * Input: code = [5,7,1,4], k = 3 
 * Output: [12,10,16,13] 
 * Explanation: Each number is replaced by the sum of the next 3 numbers. The decrypted code is [7+1+4, 1+4+5, 4+5+7, 5+7+1]. 
 * Notice that the numbers wrap around.
 * 
 * Example 2: 
 * Input: code = [1,2,3,4], k = 0 
 * Output: [0,0,0,0] 
 * Explanation: When k is zero, the numbers are replaced by 0.  
 * 
 * Example 3: 
 * Input: code = [2,4,9,3], k = -2 
 * Output: [12,5,6,13] 
 * Explanation: The decrypted code is [3+9, 2+3, 4+2, 9+4]. Notice that the numbers wrap around again. If k is negative, 
 * the sum is of the previous numbers. 
 * 
 * Example 4: 
 * Input: code = [12,29,0,24,29,4], k = 12 
 * Output: [196,196,196,196,196,196] 
 * Explanation: Randomly generated solution. 
********************************************************************************************************************************/
using System;

public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int k;
        Random r; 
        int[] code, decryptedCode; 

        // initialize local variables 
        r = new Random(); 

        // example 1
        k = 3;
        code = new int[] { 5, 7, 1, 4 }; 
        decryptedCode = Decrypt(code, k);

        // example 2 
        k = 0;
        code = new int[] { 1, 2, 3, 4 };
        decryptedCode = Decrypt(code, k);

        // example 3 
        k = -2;
        code = new int[] { 2, 4, 9, 3 };
        decryptedCode = Decrypt(code, k);

        // example 4
        k = r.Next(-16, 17);
        code = new int[r.Next(2, 8)]; 
        for (int i = 0; i < code.Length; i++)
        {
            code[i] = r.Next(0, 33); 
        }
        decryptedCode = Decrypt(code, k);

        // example 5
        k = r.Next(-32, 33);
        code = new int[r.Next(2, 16)];
        for (int i = 0; i < code.Length; i++)
        {
            code[i] = r.Next(0, 65);
        }
        decryptedCode = Decrypt(code, k);

        // example 6 
        k = 6; 
        code = GenerateHarmonicSequence(k, 884, null);
        decryptedCode = Decrypt(code, k); 

        // example 7 
        k = 12;
        code = GenerateHarmonicSequence(k, 1003, null);
        decryptedCode = Decrypt(code, k); 

        // keep the application running  
        Console.ReadLine();

    }

    // decrypts the code 
    public static int[] Decrypt(int[] code, int k)
    {

        // declare local variables 
        int index, direction; 
        int[] decryptedCode;

        // initialize local variables 
        index = 0; direction = -1; 
        decryptedCode = new int[code.Length];

        // only if k > 0 or k < 0 
        if (k != 0)
        {

            // direction of the loop 
            direction = (k > 0) ? 1 : direction;

            // decrypts the code 
            for (int i = 0; i < code.Length; i++)
            {

                // resets index 
                index = (i + direction);

                for (int j = 0; j < Math.Abs(k); j++)
                {

                    // re-posistions the index either at the
                    // start or end of the array 
                    // for a circular loop 
                    index = (index == code.Length) ? 0 : index;
                    index = (index < 0) ? code.Length - 1 : index;

                    // adds the current element to the decrypted code 
                    decryptedCode[i] += code[index];
                    index += direction;

                }

            }

        }

        // prints the original code 
        Console.Write("Code: "); 
        for (int i = 0; i < code.Length; i++)
        {
            Console.Write(code[i] + " "); 
        }
        Console.WriteLine();

        // prints the array 
        Console.Write("Decrypted Code: ");
        for (int i = 0; i < decryptedCode.Length; i++)
        {
            Console.Write(decryptedCode[i] + " "); 
        }
        Console.WriteLine();
        Console.WriteLine("k = " + k);
        Console.WriteLine();

        // returns the decrypted code 
        return decryptedCode; 

    }

    // generate a Harmonic sequence 
    public static int[] GenerateHarmonicSequence(int size, int target, int? kFactor = null)
    {

        // declare local variables 
        int[] harmonicCode; 
        int factor, product, remainder;
        int operation, index, value; 
        Random r; 

        // initialize local variables 
        harmonicCode = new int[size];
        factor = product = remainder = 0;
        r = new Random(); 

        // factor 
        factor = target / size;

        // product 
        product = factor * size;

        // remainder 
        remainder = target - product; 

        // fill code 
        for (int i = 0; i < harmonicCode.Length; i++)
        {
            harmonicCode[i] = factor; 
        }

        // add the remainder to the parity/remainder bit 
        harmonicCode[size - 1] += remainder;

        // print array 
        Console.WriteLine("Target: " + target);
        Console.Write("Preliminary Code: "); 
        PrintArray(harmonicCode);
        Console.WriteLine(); 

        // start at code[0]
        for (int i = 0; i < harmonicCode.Length; i++)
        {

            // pick a random index 
            index = r.Next(0, harmonicCode.Length);

            // randomly pick an operation, add or subtract (0 = add, 1 = subtract) 
            operation = r.Next(0, 2);

            // random number between 0, code[secondRandomIndex] + 1)
            value = (operation == 0) ? r.Next(0, harmonicCode[i] + 1) : r.Next(0, harmonicCode[index] + 1);

            // add or subtract at code[i] 
            harmonicCode[i] = (operation == 0) ? (harmonicCode[i] - value) : (harmonicCode[i] + value);

            // add or subtract at code[index] 
            harmonicCode[index] = (operation == 0) ? (harmonicCode[index] + value) : (harmonicCode[index] - value); 

        }

        // return code 
        return harmonicCode; 

    }

    public static void PrintArray(int[] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            Console.Write(data[i] + " ");
        }
    }

}
