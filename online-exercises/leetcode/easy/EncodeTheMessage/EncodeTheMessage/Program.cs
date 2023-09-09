/*******************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 09/06/2023 
 * Filename: EncodeTheMessage.cs 
 * Description: An Encryption/Decryption algorithm that I came up with. 
 * 
 * Provided a target number, i.e.: 43913, and a key array of integers ("Key.txt"), decode the array back into it's original ASCII 
 * representation and convert it back into a string. 
 * 
 * Encoding: 
 * 1) Reads a message from a file 
 * 2) Converts it into it's ASCII representation 
 * 3) Gets the sum of the ASCII values, i.e.: target = 43913 
 * 4) Divides the target into x number of equal parts, where x is the size of the message (in number of characteres including 
 * spaces and special characters), i.e.: factor = 43913 / size = 94, where size = 467 
 * 5) Place the remainder from the division operation in array[size-1] 
 * 6) Encode the array by subtracting the ASCII value at ascii[i] from array[i]
 * 7) Save the encoded array into a file 
 * 
 * Decoding: 
 * 1) Call the DecodeMessageFromFile("Key.txt", "Output.txt"); 
 * 2) The decrypted message will be found in the DecryptedMessages folder with the "Output.txt" filename 
 * 
*******************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables  
        string message;

        // example 1 
        SaveKey(EncodeMessageFromFile("Saint Bridget\'s Parish.txt"), "Saint Bridget\'s Parish Encoded.txt"); 
        message = DecodeMessageFromFile("Saint Bridget's Parish Encoded.txt", "Saint Bridget's Parish.txt");
        Console.WriteLine("Decrypted Message: " + message);

        // example 2 
        SaveKey(EncodeMessageFromFile("Framingham.txt"), "Framingham Encoded.txt");
        message = DecodeMessageFromFile("Framingham Encoded.txt", "Framingham.txt");
        Console.WriteLine("Decrypted Message: " + message);

        // example 3 
        SaveKey(EncodeMessageFromFile("Poem.txt"), "Poem Encoded.txt");
        message = DecodeMessageFromFile("Poem Encoded.txt", "Poem.txt");
        Console.WriteLine("Decrypted Message: " + message);

        // example 4 
        SaveKey(EncodeMessageFromFile("Sample.txt"), "Sample Encoded.txt");
        message = DecodeMessageFromFile("Sample Encoded.txt", "Sample.txt");
        Console.WriteLine("Decrypted Message: " + message);

    }

    // encodes a message from a file 
    public static Tuple<int[], int> EncodeMessageFromFile(string filename)
    {

        // declare local variables 
        string message;
        Tuple<int[], int> tuple;

        // initialize local variables 
        tuple = new Tuple<int[], int>(new int[0], -1);

        try
        {

            // read from file 
            using (StreamReader sr = new StreamReader("../../../Messages/" + filename))
            {
                message = sr.ReadToEnd();
            }

            // encode the message 
            tuple = EncodeMessage(message);

        }

        catch (IOException ex)
        {
            Console.WriteLine("We're sorry, but there was an error reading from the file: ");
            Console.WriteLine(ex.Message);
        }

        // return the tuple 
        return tuple;

    }

    // decodes a message from a file 
    public static string DecodeMessageFromFile(string filename, string decodedFilename)
    {

        // declare local variables 
        int target;
        int[] decryptedCode;
        Tuple<int[], int> tuple;
        string[] messageContents;
        string encodedMessage, decodedMessage;

        // initialize local variables 
        decodedMessage = string.Empty;

        try
        {

            // read from file 
            using (StreamReader sr = new StreamReader("../../../Keys/" + filename))
            {
                encodedMessage = sr.ReadToEnd();
            }

            // split the message into an array 
            messageContents = encodedMessage.Split(" ");

            // initialize the key array
            decryptedCode = new int[messageContents.Length - 1];

            // fill the key array with each value from the encrypted message 
            for (int i = 0; i < messageContents.Length - 1; i++)
            {
                decryptedCode[i] = int.Parse(messageContents[i]);
            }

            // gets the target value from the end of the encrypted message 
            target = int.Parse(messageContents[messageContents.Length - 1]);

            // creates a new Tuple object for decryption purposes 
            tuple = new Tuple<int[], int>(decryptedCode, target);

            // decodes the message 
            decodedMessage = DecodeMessage(tuple);

            // write to file 
            using (StreamWriter sw = new StreamWriter("../../../DecryptedMessages/" + decodedFilename))
            {
                sw.WriteLine(decodedMessage);
            }

        }
        catch (IOException ex)
        {
            Console.WriteLine("We're sorry, but there was an error reading from the file: ");
            Console.WriteLine(ex.Message);
        }

        // returns the decoded message 
        return decodedMessage;

    }

    // encodes the message 
    public static Tuple<int[], int> EncodeMessage(string message)
    {

        // declare local variables 
        int[] ascii, key, encoding;
        int target, factor, remainder;

        // initialize local variables 
        target = 0;
        ascii = new int[message.Length];
        encoding = new int[message.Length];
        key = new int[message.Length];

        // display message 
        Console.WriteLine("Message: " + message); 

        // cast each individual character to an int
        for (int i = 0; i < message.Length; i++)
        {
            ascii[i] = (int)message[i];
            target += ascii[i];
        }
        Console.Write("ASCII Representation of the Message: "); 
        PrintArray(ascii);

        // factor 
        factor = target / message.Length;

        // remainder 
        remainder = target - (factor * message.Length);

        // fill the encoding array 
        for (int i = 0; i < encoding.Length; i++)
        {
            encoding[i] = factor;
        }

        // add the remainder to the parity/remainder bit 
        encoding[encoding.Length - 1] += remainder;
        Console.Write("Encoding (before subtracting ASCII values): "); 
        PrintArray(encoding);

        // fill the key array 
        for (int i = 0; i < encoding.Length; i++)
        {
            // compute the value 
            key[i] = encoding[i] - ascii[i];
        }
        Console.Write("Secret Key / Encoding (after subtracting ASCII values): ");
        PrintArray(key);

        // returns the key 
        return new Tuple<int[], int>(key, target); 

    } 

    // decodes the message 
    public static string DecodeMessage(Tuple<int[], int> tuple)
    {

        // declare local variables 
        string decryptedMessage;
        int[] key, decryptedCode;
        int target, factor, remainder;

        // initialize local variables 
        key = tuple.Item1; 
        target = tuple.Item2;
        factor = target / key.Length;
        remainder = target - (factor * key.Length);
        decryptedCode = new int[key.Length];
        decryptedMessage = string.Empty;

        // display messages 
        Console.WriteLine("Target: " + target);
        Console.WriteLine("Message size to be decrypted: " + key.Length);

        // fill the decrypted code 
        for (int i = 0; i < decryptedCode.Length - 1; i++)
        {
            
            // add or subtract from the decrypted code by key[i] 
            decryptedCode[i] = factor - key[i];

            // reconvert the ASCII value back to char 
            decryptedMessage += (char)decryptedCode[i]; 

        }

        // fill the remainder/parity bit 
        decryptedCode[decryptedCode.Length - 1] = factor - key[key.Length - 1] + remainder;
        decryptedMessage += (char)decryptedCode[decryptedCode.Length - 1];
        
        // print the decrypted code 
        PrintArray(decryptedCode);

        // return the decrypted code 
        return decryptedMessage; 

    }

    // saves a key to a file 
    public static void SaveKey(Tuple<int[], int> tuple, string filename)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("../../../Keys/" + filename))
            {
                for (int i = 0; i <  tuple.Item1.Length; i++)
                {
                    sw.Write(tuple.Item1[i] + " ");
                }
                sw.Write(tuple.Item2); 
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("We're sorry, but there was an error writing or saving to the file: ");
            Console.WriteLine(ex.Message);
        }
    }

    // prints an int array 
    public static void PrintArray(int[] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            Console.Write(data[i] + " "); 
        }
        Console.WriteLine(); 
    }

}
