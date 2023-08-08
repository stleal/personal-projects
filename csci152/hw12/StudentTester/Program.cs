/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/06/2023 
 * Filename: StudentTester.cs 
 * Description: Implement a class Student. For the purpose of this exercise, a student has a name 
 * and a total quiz score. Supply an appropriate constructor and methods getName(), addQuiz(int score), 
 * getTotalScore(), and getAverageScore(). To compute the latter, you also need to store the number of 
 * quizzes that the student took. 
*********************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int i;
        char cmd; 
        Student[] s;
        string input;
        string[] name;

        // initialize local variables 
        i = -1; 
        s = new Student[10]; 
        input = string.Empty; 

        // infinite loop 
        while (input != "X" && input != "x")
        {

            // prompt the user 
            Console.Write("Please choose from one of the available commands: N, Q, T, A, S, or X: ");
            
            // get the user's input 
            input = Console.ReadLine().ToLower();

            // parse the command 
            cmd = input.ElementAt(0);

            // parse the Student Id if the command is not exit 
            if (input.Length > 1)
                i = int.Parse(input.ElementAt(1).ToString());

            // execute the command 
            switch(cmd)
            {
                case 'x':
                    Environment.Exit(0);
                    break; 
                    case 'n': 
                    Console.WriteLine("Student name is " + s[i].GetFirstName() + " " + s[i].GetLastName());
                    break;
                case 'q':
                    Console.Write("Please enter a Quiz score: ");
                    input = Console.ReadLine();
                    s[i].AddQuiz(Convert.ToDouble(input));
                    Console.WriteLine("Quiz added"); 
                    break;
                case 't':
                    Console.WriteLine("Total score is: " + s[i].GetTotalScore());
                    break;
                case 'a':
                    Console.WriteLine("Average score is: " + s[i].GetAverageScore());
                    break;
                case 's':
                    Console.Write("Please enter the Student's first and last name (separated by a space): ");
                    input = Console.ReadLine();
                    name = input.Split(" ");
                    s[i] = new Student(name[0], name[1]);
                    break; 
                default:
                    Console.WriteLine("No such command, please try again."); 
                    break;
            }
        }
        Console.WriteLine("Exiting StudentTester"); 
    }

}
