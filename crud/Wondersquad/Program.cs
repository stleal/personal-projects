using Microsoft.Data.SqlClient;

public class Wondersquad
{

    public static void Main(string[] args)
    {

        try
        {
            
            int userId = 0; 
            string username, email, firstName, lastName = "";
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();

            conn.DataSource = "(LocalDb)\\MSSQLLocalDB";
            conn.UserID = "Sam-PC\\LealS";
            conn.Password = "aPrZ8StMdhEh1!";
            conn.InitialCatalog = "Wondersquad";
            conn.ConnectionString = "server=(LocalDb)\\MSSQLLocalDB;database=Wondersquad;trusted_connection=true;encrypt=false"; 

            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT Id, Username, Email, FirstName, LastName FROM Users WITH(NOLOCK);"; 
                
                using(SqlCommand command = new SqlCommand(sql, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userId = reader.GetInt32(0); 
                            username = reader.GetString(1);
                            email = reader.GetString(2); 
                            firstName = reader.GetString(3);
                            lastName = reader.GetString(4);                             
                            Console.WriteLine("Id: " + userId + ", Username: " + username + ", Email: " + email + ", First Name: " + firstName + ", Last Name: " + lastName);
                        }
                    }
                }
            }

        }
        catch(SqlException ex)
        {
            Console.WriteLine(ex.ToString()); 
        }
        Console.WriteLine("\nDone. Press enter.");
        Console.ReadLine(); 
    }

}
