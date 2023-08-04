namespace Core
{
    public class DataAccessConstants
    {

        #region Stored Procedure List 

        // CRUD 

        // Create SPs 
        public const string InsertIntoToDoTasksSP = "usp_ToDoApp_InsertToDoTask"; 

        // Read SPs 

        // Update SPs 

        // Delete SPs 

        #endregion



        #region SQL Commands List 

        // CRUD 

        // Create SQLs  
        public static string InsertIntoToDoTasksSql()
        {
            string query = "INSERT INTO ToDoTasks (UserId, CharacterId, CharacterName, TaskName, Description, EstimatedCompletionDate, CreatedDate, " +
                "IsCompleted, Notes) VALUES(@UserId, @CharacterId, @CharacterName, @TaskName, @Description, @EstimatedCompletionDate, '" +
                DateTime.Now.ToString() + "', " + "@IsCompleted, @Notes)"; 
            return query; 
        }

        // Read SQLs 
        public static string GetToDoTaskByTaskId(int taskId)
        {
            return "SELECT * FROM ToDoTasks WITH(NOLOCK) WHERE [TaskId] = " + taskId; 
        }

        // Update SQLs 
        public static string UpdateToDoTaskByTaskId(DateTime completionDate, int taskId, string completionNotes)
        {
            return "UPDATE ToDoTasks SET [CompletionDate] = '" + completionDate + "', [ModifiedDate] = '" + DateTime.Now.ToString() + 
                "', [IsCompleted] = 1, [CompletionNotes] = '" + completionNotes + "' WHERE [TaskId] = " + taskId; 
        }

        // DELETE SQLs 
        public static string DeleteToDoTaskByTaskId(int taskId)
        {
            return "DELETE FROM ToDoTasks WHERE [TaskId] = " + taskId;
        }

        #endregion

    }
}
