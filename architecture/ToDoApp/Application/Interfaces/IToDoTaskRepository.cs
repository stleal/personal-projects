public interface IToDoTaskRepository : IGenericRepository<ToDoTask>
{
    Task<int> UpdateCompletionDateAsync(int taskId, DateTime completionDate); 
}