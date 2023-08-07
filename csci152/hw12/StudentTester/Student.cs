/*********************************************************************************************
 * Name: Sam Leal 
 * Date: 08/06/2023 
 * Filename: StudentTester.cs 
 * Description: Implement a class Student. For the purpose of this exercise, a student has a name 
 * and a total quiz score. Supply an appropriate constructor and methods getName(), addQuiz(int score), 
 * getTotalScore(), and getAverageScore(). To compute the latter, you also need to store the number of 
 * quizzes that the student took. 
*********************************************************************************************/
public class Student
{

    // global variables 
    private int _age;
    private int _gender;
    private DateTime _dob;
    private Guid _studentId; 
    private string _lastName; 
    private string _firstName;
    private string _salutation; // mr., mrs., Dr., etc... 
    private string _suffix; // sr., jr., n/a, etc... 
    private double _totalQuizScore;
    private int _numOfQuizzesTaken;
    private DateTime _graduationDate;
    private bool _alumni;
    private bool _enrolled;
    private bool _hasGraduted;
    private string _homeAddress; 
    private string _city;
    private string _state;
    private int _zip;
    private double _gpa; 

    // default constructor 
    public Student()
    {
        _numOfQuizzesTaken = 0; 
    }

    // constructor 
    public Student(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
        _numOfQuizzesTaken = 0; 
    }

    // add quiz score 
    public void AddQuiz(double score)
    {
        _totalQuizScore += score; 
        _numOfQuizzesTaken++; 
    }

    // get total score 
    public double GetTotalScore()
    {
        return _totalQuizScore; 
    }

    // get the average score 
    public double GetAverageScore()
    {
        return (_totalQuizScore / _numOfQuizzesTaken); 
    }

    // get the student's last name 
    public string GetLastName()
    {
        return _lastName; 
    }

    // get the student's first name 
    public string GetFirstName()
    {
        return _firstName; 
    }

}
