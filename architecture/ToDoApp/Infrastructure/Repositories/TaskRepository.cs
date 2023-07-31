using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

public class TaskRepository : IToDoTaskRepository
{
    private readonly IConfiguration configuration;
    public TaskRepository(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public async Task<int> AddAsync(ToDoTask entity)
    {
        var sql = "INSERT INTO ToDoTasks (UserId,Username,TaskName,Description,EstimatedCompletionDate,CompletionDate,CreatedDate,ModifiedDate,IsCompleted,Notes) VALUES " +
            "(@UserId,@Username,@TaskName,@Description,@EstimatedCompletionDate,@CompletionDate,@CreatedDate,@ModifiedDate,@IsCompleted,@Notes)";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, entity);
            return result;
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        var sql = "DELETE FROM Products WHERE Id = @Id";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, new { Id = id });
            return result;
        }
    }
    public async Task<IReadOnlyList<ToDoTask>> GetAllAsync()
    {
        var sql = "SELECT * FROM Products";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QueryAsync<ToDoTask>(sql);
            return result.ToList();
        }
    }
    public async Task<ToDoTask> GetByIdAsync(int id)
    {
        var sql = "SELECT * FROM ToDoTasks WHERE TaskId = " + id;
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<ToDoTask>(sql);
            return result;
        }
    }
    public async Task<int> UpdateAsync(ToDoTask entity)
    {
        entity.ModifiedDate = DateTime.Now;
        var sql = "UPDATE ToDoTasks SET Name = @Name, Description = @Description WHERE Id = @Id";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, entity);
            return result;
        }
    }

    public async Task<int> UpdateCompletionDateAsync(int taskId, DateTime completionDate)
    {
        var sql = "UPDATE ToDoTasks SET CompletionDate = '" + completionDate + "', ModifiedDate = '" + DateTime.Now + "' WHERE [Id] = " + taskId;
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();  
            var result = await connection.ExecuteAsync(sql);
            return result;
        }
    }

}
