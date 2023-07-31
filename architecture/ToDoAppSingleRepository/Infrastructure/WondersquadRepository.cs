using System.Data; 
using System.Data.SqlClient;

namespace Infrastructure.Repositories
{
    public class WondersquadRepository 
    {

        // gets the connection string from the appsettings.json file 
        private readonly string _defaultConnectionString = ConnectionString.GetDefaultConnectionString();

        // gets a ToDo task from the database by it's TaskId 
        public ToDoTask GetToDoTaskByTaskId(int id)
        {
            var result = new List<ToDoTask>();
            using (var connection = new SqlConnection(_defaultConnectionString))
            {
                var taskRepo = new ToDoTaskRepository(connection);
                result = taskRepo.Execute("SELECT * FROM ToDoTasks WITH(NOLOCK) WHERE [TaskId] = " + id, CommandType.Text).ToList(); 
            }
            return result.Any() ? result.FirstOrDefault() : new ToDoTask(); 
        }

        //public void InsertToDoTask(int userId, int charId, string charName, string taskName, string description, 
        //    DateTime estimatedCompletionDate, DateTime completionDate, DateTime createdDate, DateTime modifiedDate, 
        //    int isCompleted, string Notes)
        //{

        //    ToDoTask toDoTask = new ToDoTask();
        //    toDoTask.UserId = userId;
        //    toDoTask.CharacterId = charId; 


        //    using (var connection = new SqlConnection(_todoAppConnStr))
        //    {

        //    }

        //}

    }
}
