/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/16/2023 
 * Filename: WordCounter.cs 
 * Description: In this assignment, you will write a Word counter C# program which reads text from a file and prints, to the screen, 
 * a table indicating the number of occurrences of words of length 1,2,3, etc. For example: 
 *
 * Whether 'tis nobler in the mind to suffer
 * 
 * Should give: 
 *  1      0
 *  2      2
 *  3      2
 *  4      1 
 *  5      0    
 *  6      2 
 *  7      1
 *  
 * You will have to decide for yourself what is meant by a word. The simplest approach is to define a word to be any continuous sequence of upper 
 * or lower case letters. Thus 'tis is counted as a 3-letter word, with the apostrophe being skipped over along with spaces, punctuation, digits etc. 
 * 
 * For this purpose you may find it helpful to use the isLetter method from the Character class. You will need to use an array with elements corresponding to 
 * various possible word lengths. When you print out the results, you should only print occurrences up to the maximum length of word that was actually encountered 
 * in the file, so the last one printed is always greater than zero. 
 * 
 * Write a program that exercises the method you have written. Apply it to the test file Framingham.txt. Framingham.txt is a file in plain text format. 
 * You can create the file by saving some web-page content at http://www.framingham.edu/
********************************************************************************************************************************************************************/
using System.Text;

public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] o; 
        string t;
        FileStream fs;

        // initialize local variables 
        fs = new FileStream("../../../Sample.txt", FileMode.Open, FileAccess.Read);

        // read from a file 
        using (var sr = new StreamReader(fs, Encoding.UTF8))
        {
            t = sr.ReadToEnd();
        }

        // count the number of occurences 
        o = CountOccurences(t);

        // print the occurences 
        PrintOccurences(o); 

    }

    // counts the number of occurences 
    public static int[] CountOccurences(string t)
    {

        // declare local variables 
        string s; 
        string[] w;
        int[] o;
        int l; 

        // initialize local variables 
        l = 0;

        // remove any special characters 
        s = RemoveSpecialCharacters(t); 

        // split the text into a string array 
        w = s.Split(" "); 

        // find the longest word in the array 
        for (int i = 0; i < w.Length; i++)
        {
            l = (w[i].Length > l) ? w[i].Length : l;
        }

        // initialize the int array 
        o = new int[l+1]; 

        // count the number of occurences 
        for (int i = 0; i < w.Length; i++)
        {
            o[w[i].Length]++; 
        }

        // return the occurences array 
        return o; 

    }

    // prints the occurences array 
    public static void PrintOccurences(int[] o)
    {
        for (int i = 0; i < o.Length; i++)
        {
            Console.WriteLine(i + " " + o[i]);
        }
    }

    // removes all special characters from a string of text 
    public static string RemoveSpecialCharacters(string t)
    {

        // declare local variables 
        string s;

        // initialize local variables 
        s = t;

        // remove special characters 
        s = s.Replace(",", "");
        s = s.Replace("'", "");
        s = s.Replace("!", "");
        s = s.Replace("?", "");
        s = s.Replace(".", "");
        s = s.Replace("/", "");
        s = s.Replace("\"", "");

        // return s 
        return s; 

    }

}
