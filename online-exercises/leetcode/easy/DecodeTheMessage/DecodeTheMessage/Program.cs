/*******************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 09/02/2023 
 * Filename: DecodeTheMessage.cs 
 * Description: You are given the strings key and message, which represent a cipher key and a secret message, respectively. 
 * 
 * The steps to decode message are as follows:
 * 
 *   1. Use the first appearance of all 26 lowercase English letters in key as the order of the substitution table.
 *   2. Align the substitution table with the regular English alphabet.
 *   3. Each letter in message is then substituted using the table.
 *   4. Spaces ' ' are transformed to themselves.
 * 
 * Example 1: 
 * 
 * Input: key = "the quick brown fox jumps over the lazy dog", message = "vkbs bs t suepuv"
 * Output: "this is a secret"
*******************************************************************************************************************************/
public class Program
{

    // global variables 
    private static string _casing;
    private static string _alphabet;
    private static string _transformation;

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        string key, msg, encryptedMessage, decryptedMessage; 

        // initialize variables 
        _alphabet = "abcdefghijklmnopqrstuvwxyz";

        // unit test case 01  
        key = "Holy Roman Catholic Church";
        encryptedMessage = EncodeMessageFromFile(key, "Saint Bridget\'s Parish.txt");
        decryptedMessage = DecodeMessage(key, encryptedMessage); 

        // unit test case 02  
        key = "Framingham State University"; 
        encryptedMessage = EncodeMessageFromFile(key, "Framingham.txt");
        decryptedMessage = DecodeMessage(key, encryptedMessage);

        // unit test case 03  
        key = "Secret Key Goes Here";
        msg = "Hello, World! This is a test message for encryption and decryption.";
        encryptedMessage = EncodeMessage(key, msg);
        decryptedMessage = DecodeMessage(key, encryptedMessage);

        // unit test case 04  
        key = "Labor Day";
        encryptedMessage = EncodeMessageFromFile(key, "Sample.txt");
        decryptedMessage = DecodeMessage(key, encryptedMessage);

        // unit test case 05 
        key = "O Captain! My Captain!";
        encryptedMessage = EncodeMessageFromFile(key, "Poem.txt");
        decryptedMessage = DecodeMessage(key, encryptedMessage);

        // unit test case 06 
        // as per the leetcode assignment
        // given an encrypted message, and a key 
        // decode the message 
        // casing is optional 
        key = "the quick brown fox jumps over the lazy dog";
        encryptedMessage = "vkbs bs t suepuv";
        _casing = "1000 00 0 100000";
        decryptedMessage = DecodeMessage(key, encryptedMessage);

        // keeps the application running 
        Console.ReadLine();

    }

    // encodes the message 
    public static string EncodeMessage(string key, string message)
    {

        // declare local variables 
        string msg, encryptedMessage;

        // initialize local variables 
        msg = string.Empty; 

        // transform the key before encrypting the message 
        TransformKey(key);

        // save the message in a local variable 
        if (!string.IsNullOrEmpty(message))
        {
            msg = message; 
        }

        // encrypt the message 
        encryptedMessage = EncryptMessage(msg);

        // returns the encrypted message 
        return encryptedMessage; 

    }

    // encodes the message from file 
    public static string EncodeMessageFromFile(string key, string filename)
    {

        // declare local variables 
        string msg, encryptedMessage;

        // initialize local variables 
        msg = string.Empty;

        // transform the key before encrypting the message 
        TransformKey(key);

        // read from the file 
        if (!string.IsNullOrEmpty(filename))
        {

            try
            {

                // read from file 
                using (StreamReader sr = new StreamReader(filename))
                {
                    msg = sr.ReadToEnd();
                }

            }
            catch (IOException ex)
            {

                // display an error  
                Console.WriteLine("We're sorry, but the file could not be read: ");
                Console.WriteLine(ex.Message);

            }

        }

        // encrypt the message 
        encryptedMessage = EncryptMessage(msg);

        // returns the encrypted message 
        return encryptedMessage;

    }

    // decodes the message 
    public static string DecodeMessage(string key, string encryptedMessage)
    {

        // declare local variables 
        string decryptedMessage; 

        // initialize local variables 
        decryptedMessage = string.Empty; 

        // transform the key 
        TransformKey(key);

        // decrypt the encrypted message 
        decryptedMessage = DecryptMessage(encryptedMessage);

        // prints the decrypted message 
        Console.WriteLine("Decrypted Message: " + decryptedMessage);

        // prints a blank line 
        Console.WriteLine();

        // returns the decrypted message 
        return decryptedMessage; 

    }

    // transforms the key 
    public static void TransformKey(string key)
    {

        // declare local variables 
        int i; 

        // initialize local variables 
        i = 0;
        _transformation = string.Empty;

        // loop through the key 
        while (_transformation.Length < 26 && i < key.Length)
        {
            if (Char.IsLetter(key.ElementAt(i)) && !_transformation.Contains(key.ElementAt(i))) 
            {
                _transformation += key.ElementAt(i);
            }
            i++;
        }

        // reset index back to zero 
        i = 0;

        // append the remaining characters in the alphaet to the transformation string       
        while (i < 26)
        {
            if (!_transformation.Contains(_alphabet.ElementAt(i)))
            {
                _transformation += _alphabet.ElementAt(i);
            }
            i++; 
        }

    } 

    // encrypts the message 
    public static string EncryptMessage(string message)
    {

        // declare local variables 
        string encryptedMessage;

        // initialize local variables 
        _casing = string.Empty;
        encryptedMessage = string.Empty;

        // encrypts the message 
        for (int i = 0; i < message.Length; i++)
        {
            encryptedMessage += (Char.IsLetter(message.ElementAt(i))) ?
                _transformation.ElementAt(_alphabet.IndexOf(message.ToLower().ElementAt(i))) : message.ElementAt(i);
            if (Char.IsLetter(message.ElementAt(i)) && Char.IsUpper(message.ElementAt(i)))
            {
                _casing += "1"; 
            } 
            else if (Char.IsLetter(message.ElementAt(i)) && !Char.IsUpper(message.ElementAt(i)))
            {
                _casing += "0"; 
            }
            else if (!Char.IsLetter(message.ElementAt(i)))
            {
                _casing += message.ElementAt(i); 
            }
        }

        // prints the encrypted message 
        Console.WriteLine("Encrypted Message: " + encryptedMessage);

        // returns the encrypted message 
        return encryptedMessage; 

    }

    // decrypt the message 
    public static string DecryptMessage(string message)
    {

        // declare local variables 
        string decryptedMessage;

        // initialize local variables 
        decryptedMessage = string.Empty;

        // decrypts the message     
        for (int i = 0; i < message.Length; i++)
        {
            if (Char.IsLetter(message.ElementAt(i)) && ((_casing.Length > 0 && _casing.ElementAt(i).Equals('0')) || _casing.Length == 0))
            {
                decryptedMessage += _alphabet.ElementAt(_transformation.IndexOf(message.ElementAt(i))); 
            }
            else if (Char.IsLetter(message.ElementAt(i)) && (_casing.Length > 0 && _casing.ElementAt(i).Equals('1')))
            {
                decryptedMessage += _alphabet.ElementAt(_transformation.IndexOf(message.ElementAt(i))).ToString().ToUpper(); 
            }
            else if (!Char.IsLetter(message.ElementAt(i)))
            {
                decryptedMessage += message.ElementAt(i);
            }
        }

        // return the decrypted message 
        return decryptedMessage; 

    }

}
