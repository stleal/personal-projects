using Core;
using System.Data.SqlClient;

namespace Infrastructure
{
    public class WondersquadRepository
    {

        // gets the connection string from the appsettings.json file 
        private readonly string _defaultConnectionString = ConnectionString.GetDefaultConnectionString();

        // Inserts a ToDo task into the database 
        public int InsertToDoTask(ToDoTask entity)
        {
            using (var connection = new SqlConnection(_defaultConnectionString))
            {
                entity.EstimatedCompletionDate = TimeZoneInfo.ConvertTimeFromUtc(entity.EstimatedCompletionDate, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")); 
                var taskRepo = new ToDoTaskRepository(connection);
                return taskRepo.InsertSql(DataAccessConstants.InsertIntoToDoTasksSql(), entity); 
            }
        }

        // Inserts a ToDo task into the database 
        public int InsertToDoTaskUsingStoredProcedure(ToDoTask entity)
        {
            using (var connection = new SqlConnection(_defaultConnectionString))
            {
                entity.CreatedDate = TimeZoneInfo.ConvertTimeFromUtc(entity.CreatedDate, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
                var taskRepo = new ToDoTaskRepository(connection);
                return taskRepo.InsertUsingSP(DataAccessConstants.InsertIntoToDoTasksSP, entity);
            }
        }

        // gets a ToDo task from the database by it's TaskId 
        public ToDoTask GetToDoTaskByTaskId(int id)
        {
            var result = new List<ToDoTask>();
            using (var connection = new SqlConnection(_defaultConnectionString))
            {
                var taskRepo = new ToDoTaskRepository(connection);
                result = taskRepo.ExecuteSql(DataAccessConstants.GetToDoTaskByTaskId(id)).ToList();
            }
            return result.Any() ? result.FirstOrDefault() : new ToDoTask();
        }

        // updates a ToDoTask in the database by it's TaskId 
        public int UpdateToDoTaskByTaskId(DateTime completionDate, int taskId, string notes)
        {
            using (var connection = new SqlConnection(_defaultConnectionString))
            {
                var taskRepo = new ToDoTaskRepository(connection);
                return taskRepo.Update(DataAccessConstants.UpdateToDoTaskByTaskId(completionDate, taskId, notes)); 
            }
        }

        // deletes a ToDoTask from the database 
        public int DeleteToDoTaskByTaskId(int taskId)
        {
            using (var connection = new SqlConnection(_defaultConnectionString))
            {
                var taskRepo = new ToDoTaskRepository(connection);
                return taskRepo.Delete(DataAccessConstants.DeleteToDoTaskByTaskId(taskId));
            }
        }

    }
}
